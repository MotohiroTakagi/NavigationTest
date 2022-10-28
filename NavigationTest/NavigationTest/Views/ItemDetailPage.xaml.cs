using NavigationTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NavigationTest.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}