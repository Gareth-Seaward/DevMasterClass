using CustomerInterface;

namespace CustomerLibrary.Models
{
    public class Lead : CustomerBase
    {
        public Lead(IValidationStratergy<ICustomer> validationStratergy):base(validationStratergy){ }
    }
}
