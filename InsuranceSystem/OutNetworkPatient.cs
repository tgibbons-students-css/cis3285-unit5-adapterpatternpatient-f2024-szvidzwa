using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    //WARNING-YOU CANNOT CHANGE THIS CODE
    //USE AN ADAPTER CLASS FOR CHANGES

    class OutNetworkPatient
    {
        public OutNetworkPatient(string newName, int newPolicyNumber)
        {
            Name = newName;
            PolicyNumber = newPolicyNumber;
        }
        public string Name { get; set; }                // patient's full name
        public int PolicyNumber { get; set; }            // policy number
        public DateTime Dob { get; set; }               // date of birth

        public decimal CoveragePercent(decimal ProcedureCost)
        //returns the percent of the procedure cost that are covered
        {
            decimal percent;
            if (ProcedureCost < 1000.00M)
            {
                percent = 0.5M;
            }
            else
            {
                percent = 0.25M;
            }
            return percent;
        }

        // returns "yes" as a string if covered.
        public bool IsCovered(string patientName, int policyNumber)
        {
            if ((patientName == Name) && (policyNumber == PolicyNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getPatientName()
        {
            return Name;
        }
    }
}

