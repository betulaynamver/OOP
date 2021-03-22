using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class RequirementLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Requirement loan payment plan has been made");
        }

        public void DoSth()
        {
            throw new NotImplementedException();
        }
    }
}
