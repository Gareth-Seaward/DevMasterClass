using System;
using System.Globalization;
using System.Windows.Forms;
using CustomerFactory;
using CustomerInterface;

namespace WindowsCustomerUI
{
    public partial class CustomerScreen : Form
    {
        public CustomerScreen()
        {
            InitializeComponent();
        }

        public string SelectedCustomerType
        {
            get { return cbCustomerType.SelectedText; }
            protected set { cbCustomerType.SelectedText = value; }
        }

        public string CustomerName
        {
            get { return tbCustomerName.Text; }
            protected set { tbCustomerName.Text = value; }
        }

        public string PhoneNumber
        {
            get { return tbPhoneNumber.Text; }
            protected set { tbPhoneNumber.Text = value; }
        }

        public string Address
        {
            get { return tbAddress.Text; }
            protected set { tbAddress.Text = value; }
        }

        public decimal BillAmount
        {
            get { return Convert.ToDecimal(tbBillAmount.Text); }
            protected set { tbBillAmount.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public DateTime BillDate
        {
            get { return dtBillDate.Value; }
            protected set { dtBillDate.Value = value; }
        }

        public ICustomer AddCustomer()
        {
            var icust = Factory<ICustomer>.Create(SelectedCustomerType);

            icust.CustomerName = CustomerName;
            icust.PhoneNumber = PhoneNumber;
            icust.Address = Address;
            icust.BillAmount = BillAmount;
            icust.BillDate = BillDate;
            return icust;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newCustomer = AddCustomer();
        }
    }
}
