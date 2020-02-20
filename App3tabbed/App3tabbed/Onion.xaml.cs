using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Onion : ContentPage
    {

        public Onion()
        {
            InitializeComponent();
        }

        //hardcoded facts 
        public string[] Facts = {
           "One average sized onion has 30 calories.",
           "The largest onion ever grown weighed around 5kg.",
           "Onions are currently 6th most popular vegetable crop in the world, judging only by its production.",
           "Yellow onion is the most popular type of onion. It takes staggering 75% of the world’s onion production.",
           "You can get rid of onion breath by eating fresh parsley.",
           "Consumption of onions in the United States rose 50% in the last 20 years. Currently, average American eats 8.5 kg of fresh onions each year."
            };
        public Random random = new Random();//random number initialization

        

        void OnionClick(object Sender, EventArgs e)
        {
            onionLabel.Text = Facts[random.Next(6)];//generate a new random fact 
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            onionLabel.Text = "click the button for a random fun fact";
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

        }
    }
}