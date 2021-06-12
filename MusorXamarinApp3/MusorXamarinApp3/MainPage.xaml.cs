using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace MusorXamarinApp3
{
    public partial class MainPage : ContentPage
    {
        const string BaseAddress = "https://musorwebapi.azurewebsites.net/";
        public MainPage()
        {
            InitializeComponent();
            LoadLoginPage();
            LoginvisableChange(false);
        }
        public void LoginvisableChange(bool isLogin, string name = "")
        {
            stack1.IsVisible = isLogin;
            stack2.IsVisible = !isLogin;
            if (isLogin)
            {
                login.Text = "Вы авторизованы как  " + name;
            }
            else login.Text = "Пользователь не авторизован!";

        }
        private async void Button1_Clicked(object sender, EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (resoult) =>
             {
                 Device.BeginInvokeOnMainThread(async () => {
                     await Navigation.PopAsync();
                     IsinbaseMessage(resoult.Text);
                 });

             };
        }
        public async void LoadLoginPage()
        {
            await Navigation.PushAsync(new LoginPage1(this));
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KodInfoEnter());
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            LoadLoginPage();
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MusorEnter());
        }
        void IsinbaseMessage(string str)
        {
            if (str == "zxi48sq3"|| str == "dfiie785")
            DisplayAlert("qr", "Код найден", "Ок");
            else
            DisplayAlert("qr", "Код отсутствует", "Ок");
        }

        private void LogAut_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Разлогин", "вы разлогинились", "Ок");
            LoadLoginPage();
        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangeMusor());
        }
    }
}
