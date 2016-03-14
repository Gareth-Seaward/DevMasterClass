using System;
using CustomerInterface;

namespace CustomerLibrary.Validation
{
    public class LeadValidation : IValidationStratergy<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (string.IsNullOrEmpty(obj.CustomerName))
                throw new Exception("Customer Name is required");
            if (string.IsNullOrEmpty(obj.PhoneNumber))
                throw new Exception("Phone number is required");
        }
    }
}
