using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class RecourseManager
    {
        //Method injection
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log(); //log whichever logger service was selected
        }

        public void DoCreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
