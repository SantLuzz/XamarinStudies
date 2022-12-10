using ProjetoTeste.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProjetoTeste.Views
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