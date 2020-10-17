using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WiredBrainCoffee.CustomersApp
{
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
      this.Loaded += MainPage_Loaded;
    }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Customer added!");
            await messageDialog.ShowAsync();
        }

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
        //    List<Employee> emp = new List<Employee>(){
        //    new Employee() { emp_id = 209, emp_name = "Anjita", emp_gender = "Female", emp_hire_date = "12/3/2017", emp_salary = 20000 },
        //        new Employee() { emp_id = 210, emp_name = "Soniya", emp_gender = "Female", emp_hire_date = "22/4/2018", emp_salary = 30000 },
        //        new Employee() { emp_id = 211, emp_name = "Rohit", emp_gender = "Male", emp_hire_date = "3/5/2016", emp_salary = 40000 },
        //        new Employee() { emp_id = 212, emp_name = "Supriya", emp_gender = "Female", emp_hire_date = "4/8/2017", emp_salary = 40000 },
        //        new Employee() { emp_id = 213, emp_name = "Anil", emp_gender = "Male", emp_hire_date = "12/1/2016", emp_salary = 40000 },
        //        new Employee() { emp_id = 214, emp_name = "Anju", emp_gender = "Female", emp_hire_date = "17/6/2015", emp_salary = 50000 },
        //};
        //    var res = emp.Select(a => new { ID = a.emp_id, Name = a.emp_name });
        //
        }

        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(customerListGrid);
            // Alternative: int column = (int)customerListGrid.GetValue(Grid.ColumnProperty);

            int newColumn = column == 0 ? 2 : 0;


            Grid.SetColumn(customerListGrid, newColumn);

            // Alternative: customerListGrid.SetValue(Grid.ColumnProperty, newColumn);

            moveSymbolIcon.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;
        }
    }
}
