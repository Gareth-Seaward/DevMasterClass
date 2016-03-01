using System;
using CustomerInterface;

namespace CustomerLibrary.Models
{
    public abstract class CustomerBase : ICustomer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        private readonly IValidationStratergy<ICustomer> _validationStratergy;

        protected CustomerBase(IValidationStratergy<ICustomer> validationStratergy)
        {
            _validationStratergy = validationStratergy;
        }

        public void Validate()
        {
            _validationStratergy.Validate(this);
        }

        public ICustomer Clone()
        {
            return (ICustomer) MemberwiseClone();
        }
    }
}
