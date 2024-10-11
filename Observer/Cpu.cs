
using System;
using System.Collections.Generic;

namespace DesignPattern
{
    public class CPU : ISubject
    {
        /// <summary>
        /// Danh sách chứa các Observer
        /// </summary>
        private List<IObserver> _observers = new List<IObserver>();
        private string _message;

        /// <summary>
        /// Method đăng ký các Observer
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        // Method hủy đăng ký  các Observer
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Method thông báo tới các Observer
        /// </summary>
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.DisplayMessage(_message);
            }
        }

        public void PushMessage(string message)
        {
            _message = message;
            Notify();
        }
    }
}