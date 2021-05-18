﻿using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace NecroGamble
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    /// 

   
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            PauseMenu.Visibility = Visibility.Visible;
            ButtonPause.Visibility = Visibility.Collapsed;
            Background.Source = new BitmapImage(new Uri(this.BaseUri, @"\Assets\MenuPausa\fondoBatallaBlur.png"));
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            PauseMenu.Visibility = Visibility.Collapsed;
            ButtonPause.Visibility = Visibility.Visible;
            Background.Source = new BitmapImage(new Uri(this.BaseUri, @"\Assets\MenuPausa\fondoBatalla.png"));

        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            PauseMenu.Visibility = Visibility.Collapsed;
            ButtonPause.Visibility = Visibility.Visible;

            Background.Source = new BitmapImage(new Uri(this.BaseUri, @"\Assets\MenuPausa\fondoBatalla.png"));

        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            PauseMenu.Visibility = Visibility.Collapsed;
            ButtonPause.Visibility = Visibility.Visible;

            Background.Source = new BitmapImage(new Uri(this.BaseUri, @"\Assets\MenuPausa\fondoBatalla.png"));

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            PauseMenu.Visibility = Visibility.Collapsed;
            ExitMenu.Visibility = Visibility.Visible;
            ButtonPause.Visibility = Visibility.Collapsed;

            Background.Source = new BitmapImage(new Uri(this.BaseUri, @"\Assets\MenuPausa\BlurOptiones.png"));
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Background.Source = new BitmapImage(new Uri(this.BaseUri, @"\Assets\MenuPausa\fondoBatalla.png"));
            ExitMenu.Visibility = Visibility.Collapsed;
            PauseMenu.Visibility = Visibility.Visible;


        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Background.Source = new BitmapImage(new Uri(this.BaseUri, @"\Assets\MenuPausa\fondoBatalla.png"));
            ExitMenu.Visibility = Visibility.Collapsed;
            ButtonPause.Visibility = Visibility.Visible;
        }
    }



}
