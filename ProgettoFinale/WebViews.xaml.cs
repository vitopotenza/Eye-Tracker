using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tobii.Interaction.Wpf;

namespace ProgettoFinale
{
    /// <summary>
    /// Logica di interazione per WebViews.xaml
    /// </summary>
    public partial class WebViews : Window
    {
        public string site;

        public WebViews(string a)
        {
            InitializeComponent();
            site = a;

        }
        public string TextPropriety
        {
            get { return site; }
        }





        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    myweb.Source = new Uri("http://" + TextPropriety + ".it");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }



        public void Net_OnHasGazeChanged(object sender, RoutedEventArgs e)
        {

            var label = e.Source as Label;
            if (label == null) { return; }
            bool hasGaze = label.GetHasGaze();
            string keyName = label.Name;
            if (hasGaze)
                this.FindGoOrNot(label);

        }
        public void FindGoOrNot(Label label)
        {
            string labelName = label.Name;
            Window current = this;
            if (labelName.Equals("indietro_key"))
            { current.Hide(); }
            else if (labelName.Equals("vai_key"))
            {
                myweb.Source = new Uri("http://" + TextPropriety);

            }
        }
    }

        
}