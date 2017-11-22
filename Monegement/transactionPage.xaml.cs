using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Monegement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class transactionPage : Page
    {
        public transactionPage()
        {
            this.InitializeComponent();
            ObservableCollection<TransactionItem> dataList = new ObservableCollection<TransactionItem>();
            TransactionItem t1 = new TransactionItem() { type = "Income", category = "Entertainment", nominal = "30000", notes = "test food", transaction_date = "23-11-2017", id_user = "001" };
            TransactionItem t2 = new TransactionItem() { type = "Income", category = "Entertainment", nominal = "30000", notes = "test food", transaction_date = "23-11-2017", id_user = "001" };
            TransactionItem t3 = new TransactionItem() { type = "Income", category = "Entertainment", nominal = "30000", notes = "test food", transaction_date = "23-11-2017", id_user = "001" };

            dataList.Add(t1);
            dataList.Add(t2);
            dataList.Add(t3);
            lvTransaction.ItemsSource = dataList;
        }
        private async void btnAddIncome_Click(object sender, RoutedEventArgs e)
        {

            AddIncomeDialog addIncome = new AddIncomeDialog();
            await addIncome.ShowAsync();

        }

        private async void btnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            AddExpenseDialog addExpense = new AddExpenseDialog();
            await addExpense.ShowAsync();

        }
    }
}
