using System;
using System.Collections.Generic;
using System.Threading;

namespace BBarSimulator
{
    class Bar
    {
        private Semaphore semaphore;
        private List<Customer> customers;

        public Bar(int capacity = 10)
        {
            semaphore = new Semaphore(capacity, capacity);
            customers = new List<Customer>();
        }

        public void Enter(Customer c)
        {
            semaphore.WaitOne();
            lock (customers)
            {
                customers.Add(c);
            }
        }

        public void Leave(Customer c)
        {
            semaphore.Release();
            lock (customers)
            {
                customers.Remove(c);
            }
        }
    }
}
