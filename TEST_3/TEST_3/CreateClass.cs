using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TEST_3
{
    class CreateClass
    {
        private string firstName = "";
        private string lastName = "";
        private string emailID = "";
        private string address = "";

        public string First_Name
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }

        public string Last_Name
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public string Email_ID
        {
            get { return emailID; }
            set
            {
                emailID = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        DataClassDataContext data = new DataClassDataContext();

        private bool active;

        public bool Active
        {
            get { return active; }
            set
            {
                active = value;
            }
        }

        public ICommand CreateClickCreate { get; set; }

        public Employee_Table CreateItem;

        public CreateClass()
        {
            CreateItem = new Employee_Table();
            CreateClickCreate = new Commands(OnCreateClickCreate);
        }

        public void OnCreateClickCreate()
        {
            VerifyDetails verify = new VerifyDetails();
            try
            {
                if (verify.Verify(First_Name, Last_Name, Email_ID))
                {
                    CreateItem.First_Name = First_Name;
                    CreateItem.Last_Name = Last_Name;
                    CreateItem.Email_ID = Email_ID;
                    CreateItem.Address = Address;
                    if (Active)
                        CreateItem.Status = "Active";
                    else
                        CreateItem.Status = "NotActive";
                    try
                    {
                        data.Employee_Tables.InsertOnSubmit(CreateItem);
                        MessageBox.Show("Entry Created");
                    }
                    catch (InvalidProgramException e)
                    {
                        MessageBox.Show("Item Already Created");
                    }
                    data.SubmitChanges();
                }
            }
            catch (InvalidProgramException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
