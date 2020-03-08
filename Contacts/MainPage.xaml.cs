using Contacts.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

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
            txtName.Unfocused += TxtName_Unfocused;
            txtLastName.Unfocused += TxtLastName_Unfocused;
            txtEmail.Focused += TxtEmail_Focused;
            txtEmail.Unfocused += TxtEmail_Unfocused;
            txtPhone.Focused += TxtPhone_Focused;
            txtPhone.Unfocused += TxtPhone_Unfocused;
            txtAddress.Focused += TxtAddress_Focused;
            txtAddress.Unfocused += TxtAddress_Unfocused;


        }

        private void TxtAddress_Unfocused(object sender, FocusEventArgs e)
        {
            txtAddress.BackgroundColor = Color.White;
        }

        private void TxtAddress_Focused(object sender, FocusEventArgs e)
        {
            txtAddress.BackgroundColor = Color.Yellow;
        }

        private void TxtPhone_Unfocused(object sender, FocusEventArgs e)
        {
            txtPhone.BackgroundColor = Color.White;
        }

        private void TxtPhone_Focused(object sender, FocusEventArgs e)
        {
            txtPhone.BackgroundColor = Color.Yellow;
        }

        private void TxtEmail_Unfocused(object sender, FocusEventArgs e)
        {
            txtEmail.BackgroundColor = Color.White;
        }

        private void TxtEmail_Focused(object sender, FocusEventArgs e)
        {
            txtEmail.BackgroundColor = Color.Yellow;
        }

        private void TxtLastName_Unfocused(object sender, FocusEventArgs e)
        {
            txtLastName.BackgroundColor = Color.White;
        }

        private void TxtName_Unfocused(object sender, FocusEventArgs e)
        {
            txtName.BackgroundColor = Color.White;
        }

        private void TxtName_Focused(object sender, FocusEventArgs e)
        {
            txtName.BackgroundColor = Color.Yellow;
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            Contact newPerson = new Contact()
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text
                
            };

            using(SQLiteConnection con = new SQLiteConnection(App.FilePath))
            {
                con.CreateTable<Contact>();
                int rowsAdded = con.Insert(newPerson);
            }
            
        }

        private void txtLastName_Focused(object sender, FocusEventArgs e)
        {
            txtLastName.BackgroundColor = Color.Yellow;
        }
    }
}
