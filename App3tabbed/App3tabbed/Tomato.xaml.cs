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
    public partial class Tomato : ContentPage
    {
        public string[] Facts = {
            "Tomatoes originally came from Peru, where their Aztec name translated to plump thing with a navel",
            "Tomatoes increase in weight as they ripen, even after harvesting.",
            "Tomatoes are the richest source of lycopene which is important for the health of the prostate gland in men.",
            "Tomatoes were first brought to Europe in the mid 1500’s.",
            "A tomato is a fruit. The confusion arose after the 1890s when the US supreme court named them a vegetable for taxation purposes.",
            "There is no mention of tomatoes in either the bible or in the complete works of shakespeare."
            };
        public Random random = new Random();

        public Tomato()
        {
            InitializeComponent();
        }

        void TomatoClick(object Sender, EventArgs e)
        {

            tomatoLabel.Text = Facts[random.Next(6)];

        }
    }
}