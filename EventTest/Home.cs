using System;

namespace EventTest
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Konekcija connection = new Konekcija();

            connection.TransactionCompleted += (e) =>
            {
                if (!e.Commited)
                {
                    return;
                }
                Console.WriteLine("Hello World! Event");
            };

            connection.StartEvent();
        }
    }
}
