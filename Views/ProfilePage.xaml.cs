//Parth Manchanda 
//Student ID - 991619566

using Finance_Manager;
using PersonalManager;
using PersonalManager.Models;

namespace PersonalManager.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            List<string> functions = new List<string>()
            {
                "UserProfile",
                "Settings",
                "QR code",
                "Saved",
                "Order and payments",
                "Digital Collectibles",
                "Favourites",
                "Terms and Conditions"
            };

            functionsListView.ItemsSource = functions;
            functionsListView.ItemSelected += OnFunctionSelected;
        }

        private async void OnFunctionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            string functionName = e.SelectedItem.ToString();
            functionsListView.SelectedItem = null;

            switch (functionName)
            {
                case "UserProfile":
                    await Navigation.PushAsync(new UserProfile());
                    break;
                //case "Settings":
                //    await Navigation.PushAsync(new Scanner());
                //    break;
                //case "QR code":
                //    await Navigation.PushAsync(new Settings());
                //    break;
                    // Add cases for the other functions here
            }
        }
    }
}
