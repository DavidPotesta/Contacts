using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contacts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
          public MainPage()
        {
            InitializeComponent();
            txtName.Focused += TxtName_Focused;
        }

        private void TxtName_Focused(object sender, FocusEventArgs e)
        {
            txtName.BackgroundColor = Color.Red;
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            txtName.Text = "David";
            txtLastName.Text = "Potesta";
        }

        private void txtLastName_Focused(object sender, FocusEventArgs e)
        {
            txtLastName.BackgroundColor = Color.Yellow;
        }
    }
}
