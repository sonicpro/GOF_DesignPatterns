using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IObserver = Observer.Interfaces.IObserver;

namespace Observer
{
    public class ClockTimer : Subject
    {
        private int state;

        private readonly CancellationTokenSource token;

        public ClockTimer()
        {
            token = new CancellationTokenSource();
            Task.Run(StartTimer);
        }
        
        public int SecondsPassed()
        {
            return state;
        }

        public override void Detach(IObserver observer)
        {
            base.Detach(observer);
            if (!observers.Any())
            {
                token.Cancel();
            }
        }

        #region Helper functions

        private void StartTimer()
        {
            try
            {
                while (true)
                {
                    Task.Delay(1000, token.Token).Wait();
                    state++;
                    Notify();
                }
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Any(e => e.GetType() == typeof(TaskCanceledException)))
                {
                    // exit gracefully
                }
                else
                {
                    throw;
                }
            }
        }

        #endregion
    }
}
