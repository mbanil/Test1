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
    class ViewModel : INotifyPropertyChanged
    {
        DataClassDataContext data = new DataClassDataContext();
        private List<Employee_Table> empList;
        private Employee_Table selectedEmployee;

        public event PropertyChangedEventHandler PropertyChanged;

        public Employee_Table SelectedEmployee
        {
            get { return selectedEmployee; }
            set
            {
                selectedEmployee = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedEmployee"));
            }
        }

        public List<Employee_Table> EmployeeList
        {
            get { return empList; }
            set { empList = value; }
        }

        public ICommand CreateCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public ICommand UpdateCommand { get; set; }

        public ICommand RefreshCommand { get; set; }

        public ViewModel()
        {
            EmployeeList = (from i in data.Employee_Tables select i).ToList();
            CreateCommand = new Commands(OnCreateClick);
            DeleteCommand = new Commands(OnDeleteClick);
            UpdateCommand = new Commands(OnUpdateClick);
            RefreshCommand = new Commands(OnRefreshClick);
        }

        public async void OnRefreshClick()
        {
            //List<Employee_Table> newTable = new List<Employee_Table>();
            //newTable = await getData();
        }

        //public List<Employee_Table> getData()
        //{
        //    Thread.Sleep(5000);
        //    EmployeeList = (from i in data.Employee_Tables select i).ToList();
        //    return EmployeeList;
        //}

        public void OnUpdateClick()
        {
            if (SelectedEmployee == null)
            {
                MessageBox.Show("Select the item to be updated");
            }
            else
            {
                Employee_Table updateEmployee = (from i in data.Employee_Tables
                                                 where i.Employee_ID == SelectedEmployee.Employee_ID
                                                 select i).FirstOrDefault();
                Update update = new Update(updateEmployee);
                update.Show();
            }
        }

        public void OnDeleteClick()
        {
            if (SelectedEmployee == null)
            {
                MessageBox.Show("Select the item to be deleted");
            }
            else
            {
                Employee_Table deleteEmployee = (from i in data.Employee_Tables
                                                 where i.Employee_ID == SelectedEmployee.Employee_ID
                                                 select i).FirstOrDefault();
                if (deleteEmployee.Status == "NotActive")
                {
                    data.Employee_Tables.DeleteOnSubmit(deleteEmployee);
                    data.SubmitChanges();
                    EmployeeList = (from i in data.Employee_Tables select i).ToList();
                    MessageBox.Show("Item Deleted");
                }
                else
                {
                    MessageBox.Show("Active Employees cant be deleted");
                }
            }
        }

        public void OnCreateClick()
        {
            Create create = new Create();
            create.Show();
        }
    }
}
