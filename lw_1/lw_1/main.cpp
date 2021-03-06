#include "stdafx.h"

using namespace std;

namespace
{
using arr = vector<double>;
using matrix = vector<arr>;

struct Matrix
{
	unsigned int begin;
	unsigned int end;
	unsigned int line;
	unsigned int column;
	unsigned int size;
	matrix* m;
	istream* input;
};

} // namespace

void showUsage()
{
	cout << "<programmName.exe> <inputFileName> <numberOfThreads>" << endl;
}

void checkInput(int argc)
{
	if (argc != 3)
	{
		throw std::invalid_argument("wrong number of arguments");
	}
}

ifstream checkFileExists(char* fileName)
{
	ifstream inFile;
	inFile.open(fileName);
	if (!inFile)
	{
		throw std::invalid_argument("input file doesn't exists");
	}
	else
	{
		return inFile;
	}
}

int getThreadNumber(int thread, int size)
{
	return (thread > size) ? size : thread;
}

DWORD WINAPI checkZeroMinor(CONST LPVOID lpVoidMatrix)
{
	auto matrix = (Matrix*)lpVoidMatrix;
	unsigned int i = matrix->column;
	unsigned int k = matrix->line;

	for (unsigned int t = matrix->begin; t < matrix->end; ++t)
	{
		if (t != k && !(abs((*(matrix->m))[t][i]) < 0.1))
		{
			for (unsigned int p = i + 1; p < (*(matrix->m)).size(); ++p)
			{
				(*(matrix->m))[t][p] -= (*(matrix->m))[k][p] * (*(matrix->m))[t][i];
			}
		}
	}

	ExitThread(0);
	DWORD dwResult = 0;
	return dwResult;
}

DWORD WINAPI initialize(CONST LPVOID lpMatrixInitDescription)
{
	auto matrix = (Matrix*)lpMatrixInitDescription;
	double num;
	arr line;

	for (unsigned int i = 0; i < matrix->size; i++)
	{
		line.clear();

		for (unsigned int k = 0; k < matrix->size; k++)
		{
			(*(matrix->input)) >> num;
			line.push_back(num);
		}

		(*(matrix->m)).push_back(line);
	}

	DWORD dwResult = 0;
	return dwResult;
}

void initMatrix(istream& input, double& threadNumber, matrix& inputMatrix, int& matrixSize)
{
	input >> matrixSize;
	auto* matrix = new Matrix;
	threadNumber = getThreadNumber(threadNumber, matrixSize);
	matrix->input = &input;
	matrix->m = &inputMatrix;
	matrix->size = matrixSize;

	auto lpVoidMatrix = (LPVOID)matrix;
	HANDLE* handle = new HANDLE;
	*handle = CreateThread(NULL, 0, &initialize, lpVoidMatrix, 0, NULL);
	WaitForMultipleObjects(1, handle, true, INFINITE);
}

int getMatrixRang(matrix inputMatrix, int& matrixSize, double threadNumber)
{
	matrix matrixCopy(inputMatrix);
	int result = matrixSize;
	vector<bool> isAlreadyUsed(matrixSize);

	for (unsigned int i = 0; i < matrixSize; i++)
	{
		unsigned int k;

		for (k = 0; k < matrixSize; k++)
		{
			double number = matrixCopy[k][i];

			if (!isAlreadyUsed[k] && !(abs(number) < 0.1))
			{
				break;
			}
		}

		if (k == matrixSize)
		{
			--result;
			continue;
		}

		isAlreadyUsed[k] = true;
		for (unsigned int t = i + 1; t < matrixSize; t++)
		{
			matrixCopy[k][t] = matrixCopy[k][t] / matrixCopy[k][i];
		}

		int step = matrixSize / threadNumber;
		int threads = threadNumber;
		HANDLE* handles = new HANDLE[threadNumber];

		for (unsigned int t = 0; threads != 0; t += step)
		{
			--threads;
			auto* matrix = new Matrix;
			matrix->m = &matrixCopy;
			matrix->column = i;
			matrix->line = k;
			matrix->begin = t;

			matrix->end = (threads != 0) ? (t + step) : matrixSize;
			auto lpVoidMatrix = (LPVOID)matrix;
			handles[threads] = CreateThread(NULL, 0, &checkZeroMinor, lpVoidMatrix, 0, NULL);
		}

		WaitForMultipleObjects(threadNumber, handles, true, INFINITE);
	}

	return result;
}

int main(int argc, char* argv[])
{
	HANDLE process = GetCurrentProcess();
	SetProcessAffinityMask(process, 0b1);
	unsigned int start = clock();

	try
	{
		checkInput(argc);
		auto file = checkFileExists(argv[1]);
		auto threadNumber = stod(argv[2]);
		matrix inputMatrix;
		int matrixSize = 0;
		initMatrix(file, threadNumber, inputMatrix, matrixSize);
		cout << getMatrixRang(inputMatrix, matrixSize, threadNumber) << '\n';
		unsigned int end = clock();
		cout << "_______________" << endl;
		cout << "time: " << end - start << endl;
	}
	catch (std::exception& e)
	{
		std::cout << e.what() << '\n';
	}

	return 0;
}
