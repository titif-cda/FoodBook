using Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Mobile.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private LoginVM VM;

        public LoginPage()
        {
            VM = new LoginVM();
            this.InitializeComponent();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private async void ValiderButton_Click(object sender, RoutedEventArgs e)
        {
            var loginProcess = VM.SignIn();
            ContentDialog contentDialogCon = new ContentDialog()
            {
                Content = "Connexion en cours",
                DefaultButton = ContentDialogButton.None
            };
            contentDialogCon.ShowAsync();

            if (await loginProcess)
            {
                contentDialogCon.Hide();
                Frame.Navigate(typeof(ResaPage));
            }
            else
            {
                contentDialogCon.Hide();

                ContentDialog contentDialog = new ContentDialog()
                {
                    Title = "Erreur de connexion",
                    Content = "Password ou Login invalide",
                    CloseButtonText = "Ok"
                };
                await contentDialog.ShowAsync();
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegisterPage));
        }
    }
}
