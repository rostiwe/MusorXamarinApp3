using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusorXamarinApp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage1 : ContentPage
    {
        string login = "Rostiwe";
        string Password = "1234";
        MainPage mainPage;
        const string BaseAddress = "https://musorwebapi.azurewebsites.net/";
        public LoginPage1(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
            mainPage.LoginvisableChange(false);
        }

        private void Enterbutton_Clicked(object sender, EventArgs e)
        {
        //    HttpClient httpClient = new HttpClient();
        //    HttpContent httpContent = new HttpContent();
        //    var acces = await httpClient.PostAsync(BaseAddress+"Token",);

            Autorise();
        }
        private void Autorise()
        {
            //string loginstring = loginString.Text;
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                if ((login == loginString.Text) && (Password == passwordString.Text))
                {
                    mainPage.LoginvisableChange(true, loginString.Text);
                    Navigation.PopAsync();
                }
                else
                {
                    DisplayAlert("Авторизация", "Авторизация не прошла", "Ок");
                }
            }
            else
            {
                DisplayAlert("Авторизация", "Нет подключения к сети", "Ок");
            }
        }


        //class LoginService
        //{
        //    public async Task Login(string username, string password)
        //    {
        //        HttpWebRequest request = new HttpWebRequest(new Uri(String.Format("{0}Token", BaseAddress)));
        //        request.Method = "POST";

        //        string postString = String.Format("username={0}&amp;password={1}&amp;grant_type=password",
        //        HttpUtility.HtmlEncode(username), HttpUtility.HtmlEncode(password));
        //        byte[] bytes = Encoding.UTF8.GetBytes(postString);
        //        using (Stream requestStream = await request.GetRequestStreamAsync())
        //        {
        //            requestStream.Write(bytes, 0, bytes.Length);
        //        }

        //        try
        //        {
        //            HttpWebResponse httpResponse = (HttpWebResponse)(await request.GetResponseAsync());
        //            string json;
        //            using (Stream responseStream = httpResponse.GetResponseStream())
        //            {
        //                json = new StreamReader(responseStream).ReadToEnd();
        //            }
        //            TokenResponseModel tokenResponse = JsonConvert.DeserializeObject(json);
        //            return tokenResponse.AccessToken;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new SecurityException("Bad credentials", ex);
        //        }
        //    }
        //}
    }
}