﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
