using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PDC03_MODULE07.Model;
using PDC03_MODULE07.ViewModel;
using System.Runtime.CompilerServices;

namespace PDC03_MODULE07.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowEmployeePage : ContentPage
    {
        EmployeeViewModel viewModel;
        public ShowEmployeePage()
        {
            InitializeComponent();
            viewModel = new EmployeeViewModel();
        }

        private void showEmployeePage()
        {
            var res = viewModel.GetAllEmployees().Result;
            lstData.ItemsSource = res;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            showEmployeePage();
        }

        private void btnAddRecord_Clicked(object sender, EventArgs e)
        {
            //this.Navigation.PushAsync(new AddEmployee());
        }
    }
}