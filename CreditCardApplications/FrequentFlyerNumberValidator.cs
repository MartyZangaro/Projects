using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApplications
{
    class FrequentFlyerNumberValidator : IFrequentFlyerNumberValidator
    {
        public bool IsValid(string frequentFlyerNumber)
        {
            throw new NotImplementedException("demo");
        }

        public void IsValid(string frequentFlyerNumber, out bool isValid)
        {
            throw new NotImplementedException("demo");
        }

        public IServiceInformation ServiceInformation
        {
            get
            {
                throw new NotImplementedException("demo");
            }
        }
    }
}
