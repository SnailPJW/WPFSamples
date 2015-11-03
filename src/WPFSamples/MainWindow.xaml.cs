﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.ListBox.SelectionChanged += (sender, args) =>
            {
                this.Flyout.IsOpen = this.ListBox.SelectedItem != null;
            };

            this.LoadSamples();
        }

        private async void LoadSamples()
        {
            this.DataContext = await Sample.LoadFromCurrentAssemblyAsync();

            await Task.Delay(50);

            this.ListBox.SelectedItem = null;
        }

        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            var hyperLink = sender as Hyperlink;
            Process.Start(hyperLink.NavigateUri.AbsoluteUri);
        }

        private void LaunchSample_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var sample = button.DataContext as Sample;
            if (sample != null)
            {
                var window = Activator.CreateInstance(sample.WindowType) as SampleWindow;
                if (window != null)
                {
                    if (!string.IsNullOrEmpty(sample.RelatedUrl))
                    {
                        window.Source = new Uri(sample.RelatedUrl);
                    }
                    
                    window.Show();
                }
            }
        }
    }
}
