using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class MortgageLoanManager: ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage loan payment plan has been made");
        }

        public void DoSth()
        {
            throw new NotImplementedException();
        }
    }
}
