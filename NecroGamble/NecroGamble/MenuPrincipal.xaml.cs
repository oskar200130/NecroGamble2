﻿using System;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace NecroGamble
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            this.InitializeComponent();
        }

        private void NewGame_Button(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MenuPreparacion));
        }

        private void LoadGame_Button(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameMenu));
        }

        private void Options_Button(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(GameMenu));
        }

        private void Exit (object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
