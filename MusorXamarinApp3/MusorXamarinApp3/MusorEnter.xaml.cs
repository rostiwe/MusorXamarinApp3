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
    public partial class MusorEnter : ContentPage
    {
        public MusorEnter()
        {
            InitializeComponent();
        }

        private void enter_Clicked(object sender, EventArgs e)
        {
            if (NomerPartii.Text == ""|| Ves.Text == "" || KontNomer.Text == "" || MusorTipe.Text == "")
                DisplayAlert("Ввод", "Заполните строки!", "Ок");
            else DisplayAlert("Ввод", "Ввод прошёл успешно!", "Ок");
        }
    }
}