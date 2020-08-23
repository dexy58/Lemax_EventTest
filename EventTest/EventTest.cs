using System;
using System.Collections.Generic;
using System.Text;

namespace EventTest
{
    public class EventTest
    {
        public bool Commited { get; set; }
    }

    public delegate void EventTestDelegate(EventTest args);

    public class Konekcija
    {
        public event EventTestDelegate TransactionCompleted;

        public void StartEvent()
        {
            TransactionCompleted(new EventTest { Commited = true });
        }
    }
}
