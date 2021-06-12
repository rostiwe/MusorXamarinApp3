using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace MusorXamarinApp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KodInfoEnter : ContentPage
    {
        string str;
        public KodInfoEnter()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Создание записи", "Запись созданна", "Ок");
        }
        void IsinbaseMessage(string cod)
        {
            if (cod == "zxi48sq3" || cod == "dfiie785")
            {
                str = cod;
                DisplayAlert("qr", "Код найден", "Ок");

            }
            else
            {
                DisplayAlert("qr", "Код отсутствует", "Ок");
                Navigation.PopAsync();
            }
        }

        private void ScanButton_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            Navigation.PushAsync(scan);
            scan.OnScanResult += (resoult) =>
            {
                Device.BeginInvokeOnMainThread(async () => {
                    await Navigation.PopAsync();
                    IsinbaseMessage(resoult.Text);
                });

            };
        }
    }
}