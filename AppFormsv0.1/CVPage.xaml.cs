using Xamarin.Forms;

namespace CVApp
{
    public partial class CVPage : ContentPage
    {
        public CVPage(string cv)
        {
            InitializeComponent();
            CVLabel.Text = cv;
        }
    }
}
