using CQRSTest.Commands;
using CQRSTest.Queries;
using System;
using System.Collections.Generic;

namespace CQRSTest.Events
{
    //singleton
    public class EventBroker
    {
        private static EventBroker instance;

        public static EventBroker Instance
        {
            get { return instance; }
            set { instance = value; }
        }
        private EventBroker() { }

        //1. All Events That Happened
        public IList<Event> Events { get; set; }
        //2. Commands do mutate the state of app
        public event EventHandler<ICommand> Commands;
        //3. Queries do not mutate the state of app
        public event EventHandler<IQuery> Queries;

        public void Command(ICommand c)
        {
            Commands?.Invoke(this, c);
        }
        public T Query<T>(Query<T> q)
        {
            Queries?.Invoke(this, q);
            return q.Result;
        }
    }
}
