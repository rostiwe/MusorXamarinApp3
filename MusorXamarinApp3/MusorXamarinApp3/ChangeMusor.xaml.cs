using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusorXamarinApp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeMusor : ContentPage
    {
        public ChangeMusor()
        {
            InitializeComponent();
            stk2.IsVisible = false;
        }

        private void enter_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Ввод", "Успешно!", "Ок");
            Navigation.PopAsync();
        }

        private void Vibor_Clicked(object sender, EventArgs e)
        {
            if (NomerPartii.Text != "" && NomerPartii.Text != "1234")
            {
                DisplayAlert("Поиск", "Успешно!", "Ок");
                stk1.IsVisible = false;
                stk2.IsVisible = true;
                Ves.Text = "15";
                KontNomer.Text = "Контейнер 1";
                MusorTipe.Text = "1";
            }
            else
            {
                DisplayAlert("Поиск", "Партия не найдена!", "Ок");
            }
                

        }
    }
}