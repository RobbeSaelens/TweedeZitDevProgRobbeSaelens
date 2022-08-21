using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TweedeZitDevProgRobbeSaelens.Models;
using TweedeZitDevProgRobbeSaelens.Repositories;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TweedeZitDevProgRobbeSaelens.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavouritesPage : ContentPage
    {
        // private List<ImageShort> image;
        public FavouritesPage()
        {
            InitializeComponent();
            LoadData();
            //this.Delete();
        }

        public async void LoadData()
        {
            lvwOverview.ItemsSource = await DogRepository.GetAllFavouritesAsync();
            lblCounter.Text = "1" ;

            RefreshView refreshView = new RefreshView();
            ICommand refreshCommand = new Command(() =>
            {
                // IsRefreshing is true
                lvwOverview.ItemsSource = "";
                refreshView.IsRefreshing = false;
            });
            refreshView.Command = refreshCommand;

            CarouselView carouselView = new CarouselView();
            refreshView.Content = carouselView;

        }

        //private void Delete()
        //{
        //    DogRepository.DeleteFavourite(image.Id);
        //    DisplayAlert("", "Dog deleted from favourites", "OK");

        //}
    }
}