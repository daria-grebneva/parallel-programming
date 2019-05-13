﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lw3
{
    public interface ICriticalSection
    {
        //Вход в критическую секцию
        void Enter();

        //Вход в критическую секцию (timeout – таймаут в мс). Если произошел вход в критическую секцию, то возвращается - true. Если произошел выход по таймауту, то false
        bool TryEnter(int timeout);

        //Устанавливается количество попыток входа в критическую секцию в методе Enter перед блокированием потока
        void SetSpinCount(int count);

        //Выход из критической секции
        void Leave();
    }
}
