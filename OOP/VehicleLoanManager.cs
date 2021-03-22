using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle loan payment plan has been made");
        }

        public void DoSth()
        {
            throw new NotImplementedException();
        }
    }
}
