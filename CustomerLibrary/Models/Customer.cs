using CustomerInterface;

namespace CustomerLibrary.Models
{
    public class Customer : CustomerBase
    {
        public Customer(IValidationStratergy<ICustomer> validationStratergy) : base(validationStratergy) { }
    }
}
