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
    public partial class Celery : ContentPage
    {
        public string[] Facts = {
            "Celery can reach the height of 3.3 feet.",
            "Celery is biennial plant, which means that plant ends its life cycle in two years.",
            "Each stalk ends with pinnate or bipinnate leaves that are serrated on the edges. Stalks and leaves are known as head of celery",
            "Celery produces creamy-white flowers that are arranged in the terminal inflorescence known as umbels",
            "Celery is low-energy vegetable. Due to low level of calories, celery is suitable for diets. Celery contains certain amounts of vitamins C, K, B2 and dietary fibers.",
            "Celery was initially used as medicine in treatment of toothache, insomnia, hypertension, anxiety, arthritis, rheumatism and to purify the blood."};
        public Random random = new Random();

        public Celery()
        {
            InitializeComponent();
        }

        void CeleryClick(object Sender, EventArgs e)
        {
            celeryLabel.Text = Facts[random.Next(6)];
        }
    }
}