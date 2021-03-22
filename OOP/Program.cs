using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            RequirementLoanManager requirementLoanManager = new RequirementLoanManager();
            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.MakeAnApplication(mortgageLoanManager, databaseLoggerService);  //It calculates whatever loan is sent from the RecourseManager

            List<ICreditManager> credits = new List<ICreditManager>() { requirementLoanManager, vehicleLoanManager };
            //recourseManager.DoCreditPreinformation(credits);

        }
    }
}
