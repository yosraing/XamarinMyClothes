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

namespace MapApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            Xamarin.FormsMaps.Init("domYIDXtQLKuWbBfsslO~Xyt1PTbtNLPJ7cFtNxX_OQ~AucEO-pzKx5LJCMO23J5DdZ3m1azfPhjGhCHFgNCxo_Sdn7D2H0EsFIpt4P1ZPwf");

            LoadApplication(new MapApp.App());
        }
    }
}
