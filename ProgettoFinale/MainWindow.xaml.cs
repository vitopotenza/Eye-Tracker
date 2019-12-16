using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Tobii.Interaction.Wpf;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tobii.Interaction.Wpf;
using System.Windows;
using Tobii.Interaction;
using Tobii.Interaction.Wpf;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;
using System.Threading;
using System.Runtime.CompilerServices;


namespace ProgettoFinale
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    
        public partial class MainWindow : Window
        {
            public KeyboardWriterModel kwm;
            public TextToSpeechModel ttsm;


            public MainWindow()
            {

                InitializeComponent();
                kwm = new KeyboardWriterModel();
                ttsm = new TextToSpeechModel();

            }


            public void Key_OnHasGazeChanged(object sender, RoutedEventArgs e)
            {
                Console.WriteLine(kwm.TextPropriety);
                var label = e.Source as Label;
                if (label == null) { return; }
                bool hasGaze = label.GetHasGaze();
                string keyName = label.Name;
                if (hasGaze)
                    kwm.FindAndWriteKey(keyName, ttsm);

            }
        }
    }
