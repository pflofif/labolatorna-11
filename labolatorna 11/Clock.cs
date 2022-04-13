using System;
using System.Collections.Generic;
using System.Threading;
using labolatorna_11.Observer_Pattern;

namespace labolatorna_11
{
    public sealed class Clock : ISubject
    {
        private Clock() { }
        private static Clock _instance;

        private readonly List<IObserverLaba> _artistant = new();
        private int time;

        public static Clock GetInstance() => _instance ??= new Clock();
        public int UpdateTime()
        {
            if (time++ >= 24) return 0;
            Console.WriteLine($"ЧАС В МIСТI : {time}");
            Notify();
            Thread.Sleep(1000);

            return 1;
        }
        public void Attach(IObserverLaba subObj)
        {
            _artistant.Add(subObj);
        }
        public void Detach(IObserverLaba subObj)
        {
            _artistant.Remove(subObj);
        }
        public void Notify() => _artistant.ForEach(o => { o.Update(time); });

    }
}