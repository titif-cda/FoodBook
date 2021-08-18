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
    public sealed partial class ResaPage : Page
    {
        private ResaVM VM;
            
            public ResaPage()
        {
            VM = new ResaVM();
            this.InitializeComponent();
        }

        private async void AnnulerResa_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog contentDialog = new ContentDialog()
            {
                Title = "Bye",
                Content = "Vous avez annulé ",
                CloseButtonText = "Ok"
            };
            await contentDialog.ShowAsync();
            Frame.Navigate(typeof(MetsPage));
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private async void AddResa_Click(object sender, RoutedEventArgs e)
        {
            if (VM.AdBooking())
            {
                ContentDialog contentDialog = new ContentDialog()
                {
                    Title = "Bravo",
                    Content = "Reservation réussie",
                    CloseButtonText = "Ok"
                };
                await contentDialog.ShowAsync();
            }
        }
    }
}
