using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TweedeZitDevProgRobbeSaelens.Models;
using TweedeZitDevProgRobbeSaelens.Repositories;

namespace TweedeZitDevProgRobbeSaelens.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BreedsDetailPage : ContentPage
    {

        public BreedsDetailPage()
        {
            InitializeComponent();
            btnBack.Clicked += btnBack_Clicked_1;

        }

        public BreedsDetailPage(Breed breed)
        {
            InitializeComponent();
            lblName.Text = breed.Name;
            //lblOrigin.Text = breed.Origin;
            lblTemperament.Text = breed.Temperament;
            lblName.Text = breed.Name;
            lblWeight.Text = breed.weight.Metric;
            lblHeight.Text = breed.height.Metric;
            lblLife.Text = breed.LifeSpan;
            Img.Source = breed.image.Url;
        }

        private void btnBack_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync(); // gaat naar vorige pagina
        }
    }
}