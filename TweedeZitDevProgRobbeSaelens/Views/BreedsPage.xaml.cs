using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweedeZitDevProgRobbeSaelens.Models;
using TweedeZitDevProgRobbeSaelens.Repositories;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TweedeZitDevProgRobbeSaelens.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BreedsPage : ContentPage
    {
        public BreedsPage()
        {
            InitializeComponent();
            LoadData();
            lvwOverview.ItemSelected += lvwOverview_ItemSelected;
        }
        public async void LoadData()
        {
            lvwOverview.ItemsSource = await DogRepository.GetAllBreedsAsync();
        }
        private void lvwOverview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new BreedsDetailPage(lvwOverview.SelectedItem as Breed));
        }
    }
}