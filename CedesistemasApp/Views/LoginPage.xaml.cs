using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CedesistemasApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
#if DEBUG
            txt_email.Text = "admin@admin.com";
            txt_password.Text = "admin";
#endif
        }

        async private void btn_login_Clicked(System.Object sender, System.EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            if(email == "admin@admin.com" && password == "admin")
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                await DisplayAlert("Error al ingresar", "El usuario y/o contraseña no son correctos", "Aceptar");
            }
        }
    }
}
