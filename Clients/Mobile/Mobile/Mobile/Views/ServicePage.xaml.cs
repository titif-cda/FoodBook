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
    public sealed partial class ServicePage : Page
    {
        private ServiceVM VM;

        public ServicePage()
        {
            VM = new ServiceVM();
            this.InitializeComponent();
        }

        private void ResaButton_Click(object sender, RoutedEventArgs e)
        {
            if(VM.LoadService())
            {
                myCalendarDatePicker.DateFormat = "{dayofweek.full}‎ {day.integer} {month.full}‎ ‎‎{year.full}";
                //!not logged
                
                if (VM.IsLog)
                {
                    Frame.Navigate(typeof(ResaPage));
                }
                else
                {
                    Frame.Navigate(typeof(LoginPage));
                }
               
                //else
                //Resa page
            }
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

    }
}
