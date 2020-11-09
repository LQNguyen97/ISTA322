using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            Dispose();
        }

        public void Dispose()
        {
            //Console.WriteLine("In dispose method, Calculator being disposed");
            if (!disposed) 
            {
                Console.WriteLine("Calculator being disposed");
            }
            disposed = true;
            GC.SuppressFinalize(this);
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
