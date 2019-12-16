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
    /// Logica di interazione per ExitViews.xaml
    /// </summary>
    public partial class ExitViews : Window
    {
        public ExitViews()
        {
            InitializeComponent();
        }
        public void Esc_OnHasGazeChanged(object sender, RoutedEventArgs e)
        {

            var label = e.Source as Label;
            if (label == null) { return; }
            bool hasGaze = label.GetHasGaze();
            string keyName = label.Name;
            if (hasGaze)
                this.FindAndExecYesNoKey(label);

        }
        public void FindAndExecYesNoKey(Label label)
        {
            string labelName = label.Name;
            Window current = this;
            if (labelName.Equals("si_key"))
            { Application.Current.Shutdown(); }
            else if (labelName.Equals("no_key"))
            {
                current.Hide();
            }
        }
    }
}
