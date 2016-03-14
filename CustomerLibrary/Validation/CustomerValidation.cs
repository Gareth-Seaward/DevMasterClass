using System;
using CustomerInterface;

namespace CustomerLibrary.Validation
{
    public class CustomerValidation : IValidationStratergy<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (string.IsNullOrEmpty(obj.CustomerName))
                throw new Exception("Customer Name is required");
            if (string.IsNullOrEmpty(obj.PhoneNumber))
                throw new Exception("Phone number is required");
            if (obj.BillAmount > 0)
                throw new Exception("Bill is required");
            if (obj.BillDate >= DateTime.Now)
                throw new Exception("Bill date is not proper");
        }
    }
}
