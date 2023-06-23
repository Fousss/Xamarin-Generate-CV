using System;
using Xamarin.Forms;

namespace CVApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            // Retrieve the entered data
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string phone = PhoneEntry.Text;
            string address = AddressEntry.Text;

            // Create the CV string
            string cv = $"Name: {name}\nEmail: {email}\nPhone: {phone}\nAddress: {address}";

            // Display the CV in a new page
            Navigation.PushAsync(new CVPage(cv));
        }
    }
}
