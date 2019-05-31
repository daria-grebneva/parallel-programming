﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Linq;

namespace CurrencyExchangeReceiver
{
    public struct Info
    {
        public int Nominal;
        public string Currency;
        public decimal Value;

        public override string ToString()
        {
            return $"{Nominal} {Currency} по курсу {Value} руб.";
        }
    }   

    public struct ExternalInfo
    {
        public string charCode;
        public int nominal;
        public decimal value;
    }

    public class Currencies
    {
        public Dictionary<string, ExternalInfo> Valute;
    }

    public class RequestCurrency
    {
        public static async Task<R> GetAsync<R>(string url)
        {
            var result = default(R);
            WebClient client = new WebClient();
            Stream stream = null;
            try
            {
                stream = await client.OpenReadTaskAsync(url);
                StreamReader sr = new StreamReader(stream);
                string json = await sr.ReadToEndAsync();
                if (!string.IsNullOrWhiteSpace(json))
                {
                    result = JsonConvert.DeserializeObject<R>(json);
                }
            }
            finally
            {
                stream?.Close();
            }

            return result;
        }

        public static R Get<R>(string url)
        {
            var result = default(R);
            WebClient client = new WebClient();
            Stream stream = null;
            try
            {
                stream = client.OpenRead(url);
                StreamReader sr = new StreamReader(stream);
                string json = sr.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(json))
                {
                    result = JsonConvert.DeserializeObject<R>(json);
                }
            }
            finally
            {
                stream?.Close();
            }

            return result;
        }

        private const string Url = "https://www.cbr-xml-daily.ru/daily_json.js";

        public Currencies GetCurrencies()
        {
            return Get<Currencies>(Url);
        }

        public async Task<Currencies> GetCurrenciesAsync()
        {
            return await GetAsync<Currencies>(Url);
        }
    }

    public class CurrencyData
    {
        private readonly RequestCurrency _RequestCurrency;

        public CurrencyData(RequestCurrency RequestCurrency)
        {
            _RequestCurrency = RequestCurrency;
        }

        public List<Info> Get()
        {
            return Convert(_RequestCurrency.GetCurrencies());
        }

        public async Task<List<Info>> GetAsync()
        {
            return Convert(await _RequestCurrency.GetCurrenciesAsync());
        }

        private List<Info> Convert(Currencies Currencies)
        {
            if (Currencies == null)
                return new List<Info>();

            return Currencies.Valute.Values
                .Select(e => new Info
                {
                    Currency = e.charCode,
                    Nominal = e.nominal,
                    Value = e.value
                })
                .ToList();
        }
    }

    public class RequestNames
    {
        public List<string> GetCurrencies(string path)
        {
            using (var sr = new StreamReader(path))
            {
                string line = sr.ReadLine() ?? "";
                return line.Split(' ').ToList();
            }
        }

        public async Task<List<string>> GetCurrenciesAsync(string path)
        {
            using (var sr = new StreamReader(path))
            {
                string line = (await sr.ReadLineAsync()) ?? "";
                return line.Split(' ').ToList();
            }
        }
    }

    public class CurrencyUpdater
    {
        private readonly CurrencyData m_currencyData;
        private readonly RequestNames m_requestNames;
        private readonly CurrencySaver m_currencySaver;

        public CurrencyUpdater()
        {
            m_currencyData = new CurrencyData(new RequestCurrency());
            m_requestNames = new RequestNames();
            m_currencySaver = new CurrencySaver();
        }

        public void Update(string currencyNamesPath, string updatePath)
        {
            List<string> currencyNames = m_requestNames.GetCurrencies(currencyNamesPath);
            List<Info> currenciesInfo = m_currencyData.Get();
            if (currencyNames.Any())
            {
                currenciesInfo = currenciesInfo.Where(ci => currencyNames.Contains(ci.Currency)).ToList();
            }

            m_currencySaver.Save(updatePath, currenciesInfo);
        }

        public async Task UpdateAsync(string currencyNamesPath, string updatePath)
        {
            Task<List<string>> currencyNamesTask = m_requestNames.GetCurrenciesAsync(currencyNamesPath);
            Task<List<Info>> taskInfo = m_currencyData.GetAsync();
            List<string> currencyNames = await currencyNamesTask;
            List<Info> currenciesInfo = await taskInfo;

            if (currencyNames.Any())
            {
                currenciesInfo = currenciesInfo.Where(ci => currencyNames.Contains(ci.Currency)).ToList();
            }

            await m_currencySaver.SaveAsync(updatePath, currenciesInfo);
        }
    }

    public class CurrencySaver
    {
        public void Save( string path, List<Info> currencies )
        {
            using ( var sw = new StreamWriter( path ) )
            {
                foreach ( Info currency in currencies )
                {
                    sw.WriteLine( currency.ToString() );
                }
            }
        }

        public async Task SaveAsync( string path, List<Info> currencies )
        {
            using ( var sw = new StreamWriter( path ) )
            {
                foreach ( Info currency in currencies )
                {
                    await sw.WriteLineAsync( currency.ToString() );
                }
            }
        }
    }
}
