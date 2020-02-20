using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App3tabbed
{
    public partial class Carrots : ContentPage
    {
        public Carrots()
        {
            InitializeComponent();
        }

        //hardcoded facts 
        public string[] Facts = {
            "Carrots were domesticated in the ancient empires located in today’s Iran and Afghanistan over 5000 years ago. From there, this great root vegetable spread across the known world.",
            "There are over 100 species of edible carrots today.",
            "Until 17th century, the only edible types of carrots had black, white, red and purple colors. The iconic orange carrots were created by selective breeding in Netherlands as a tribute to the ruling House of Orange.",
            "Since their arrival to ancient Greece and Rome to their expansion in medieval Europe, carrots were often used for their medicinal properties. Romans famously though that carrots are aphrodisiacs.",
            "87% of carrot is water.",
            "Carrots lost their bitterness, dryness of the core and gained sweetness only during 17th and 18th century.",
            "Carrot is one of the most sugary vegetables in the world. Only beet has it more.",
            "American cuisine did not approve of carrots for the longest time. They became fond of it only after their soldiers returned home from the World War I when they had constant contact with this great vegetable."
        };
        public Random random = new Random();//random number initialization

        void CarrotClick(object Sender, EventArgs e)
        {
            carrotLabel.Text = Facts[random.Next(6)];//generate a new random fact 
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            carrotLabel.Text = "click the button for a random fun fact";
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

        }
    }
}
