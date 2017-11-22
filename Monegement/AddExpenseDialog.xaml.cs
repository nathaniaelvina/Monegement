using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Monegement
{
    public sealed partial class AddExpenseDialog : ContentDialog
    {
        public AddExpenseDialog()
        {
            this.InitializeComponent();
            
            
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            string amount = txtAmount.Text;
            string category="Food";
            string date = dpExpense.Date.ToString();
            string type = "Expense";
            string name = txtDescription.Text;
            string id_user = "004";
            saveTransaction(type, category, amount, name, date, id_user);

          //  TransactionItem add = new TransactionItem() { type = type, category = category, nominal = amount, notes = name, transaction_date = date, id_user = id_user };
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        public async void saveTransaction(string type, string category, string amount, string name, string date, string id_user)
        {
            //fileName = user id + expense
            string fileName = "004" + "_Expense";
            string text = type + "#" + category + "#" + amount + "#" + name+"#" + date+"\n";
            StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile file = await localFolder.CreateFileAsync(fileName, CreationCollisionOption.GenerateUniqueName);
            await FileIO.WriteTextAsync(file, text);

        }
    }
}
