using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TEST_3
{
    class UpdateClass : INotifyPropertyChanged
    {
        DataClassDataContext data = new DataClassDataContext();

        private string firstName;
        private string lastName;
        private string emailID;
        private string address;

        public event PropertyChangedEventHandler PropertyChanged;

        public string First_Name
        {
            get { return firstName; }
            set
            {
                firstName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("First_Name"));
                }
            }
        }

        public string Last_Name
        {
            get { return lastName; }
            set
            {
                lastName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Last_Name"));
                }
            }
        }

        public string Email_ID
        {
            get { return emailID; }
            set
            {
                emailID = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Email_ID"));
                }
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Address"));
                }
            }
        }

        Employee_Table UpdateItem;

        public UpdateClass(Employee_Table updateItem)
        {
            UpdateItem = updateItem;
            First_Name = updateItem.First_Name;
            Last_Name = updateItem.Last_Name;
            Email_ID = updateItem.Email_ID;
            Address = updateItem.Address;
            UpdateCommand = new Commands(OnUpdateClickUpdate);
        }

        public void OnUpdateClickUpdate()
        {
            VerifyDetails verify = new VerifyDetails();
            Employee_Table ToBeUpdated = (from item in data.Employee_Tables
                                          where item.Employee_ID == UpdateItem.Employee_ID
                                          select item).FirstOrDefault();
            try
            {
                if (verify.Verify(First_Name, Last_Name, Email_ID))
                {
                    ToBeUpdated.First_Name = First_Name;
                    ToBeUpdated.Last_Name = Last_Name;
                    ToBeUpdated.Address = Address;
                    if (Active)
                        ToBeUpdated.Status = "Active";
                    else
                        ToBeUpdated.Status = "NotActive";
                    data.SubmitChanges();
                    MessageBox.Show("Updated");
                }
            }
            catch (InvalidProgramException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private bool active;

        public bool Active
        {
            get { return active; }
            set
            {
                active = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Active"));
                }
            }
        }

        public ICommand UpdateCommand { get; set; }

    }
}
