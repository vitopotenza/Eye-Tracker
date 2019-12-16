using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows;

namespace ProgettoFinale
{
    public class KeyboardWriterModel: INotifyPropertyChanged
    ///MODEL

    {
        public string Text;
        public bool isUpperCase = true;
        public KeyboardWriterModel()
        {

            Text = "";
            Application.Current.MainWindow.DataContext = this;
        }

        public string TextPropriety
        {
            get { return Text; }

            set
            {
                Text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TextPropriety)));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;




        public void FindAndWriteKey(string keyName, TextToSpeechModel ttsm)
        {

            switch (keyName)
            {
                case "q_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "Q";
                    else this.TextPropriety = this.TextPropriety + "q"; 
                    Console.WriteLine(Text);
                    break;
                case "w_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "W";
                    else this.TextPropriety = this.TextPropriety + "w";
                    Console.WriteLine(Text);
                    break;
                case "chiocchiola_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "@";
                    else this.TextPropriety = this.TextPropriety + "@";
                    Console.WriteLine(Text);
                    break;
                case "slash_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "\\";
                    else this.TextPropriety = this.TextPropriety + "\\";
                    Console.WriteLine(Text);
                    break;
                case "e_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "E";
                    else this.TextPropriety = this.TextPropriety + "e";
                    Console.WriteLine(Text);
                    break;
                case "r_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "R";
                    else this.TextPropriety = this.TextPropriety + "r";
                    Console.WriteLine(Text);
                    break;
                case "t_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "T";
                    else this.TextPropriety = this.TextPropriety + "t";
                    Console.WriteLine(Text);
                    break;
                case "y_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "Y";
                    else this.TextPropriety = this.TextPropriety + "y";
                    Console.WriteLine(Text);
                    break;
                case "u_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "U";
                    else this.TextPropriety = this.TextPropriety + "u";
                    Console.WriteLine(Text);
                    break;
                case "i_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "I";
                    else this.TextPropriety = this.TextPropriety + "i";
                    Console.WriteLine(Text);
                    break;
                case "o_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "O";
                    else this.TextPropriety = this.TextPropriety + "o";
                    Console.WriteLine(Text);
                    break;
                case "p_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "P";
                    else this.TextPropriety = this.TextPropriety + "p";
                    Console.WriteLine(Text);
                    break;
                case "a_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "A";
                    else this.TextPropriety = this.TextPropriety + "a";
                    Console.WriteLine(Text);
                    break;
                case "s_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "S";
                    else this.TextPropriety = this.TextPropriety + "s";
                    Console.WriteLine(Text);
                    break;
                case "d_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "D";
                    else this.TextPropriety = this.TextPropriety + "d";
                    Console.WriteLine(Text);
                    break;
                case "f_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "F";
                    else this.TextPropriety = this.TextPropriety + "f";
                    Console.WriteLine(Text);
                    break;
                case "g_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "G";
                    else this.TextPropriety = this.TextPropriety + "g";
                    Console.WriteLine(Text);
                    break;
                case "h_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "H";
                    else this.TextPropriety = this.TextPropriety + "h";
                    Console.WriteLine(Text);
                    break;
                case "j_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "J";
                    else this.TextPropriety = this.TextPropriety + "j";
                    Console.WriteLine(Text);
                    break;
                case "k_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "K";
                    else this.TextPropriety = this.TextPropriety + "k";
                    Console.WriteLine(Text);
                    break;
                case "l_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "L";
                    else this.TextPropriety = this.TextPropriety + "l";
                    Console.WriteLine(Text);
                    break;
                case "z_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "Z";
                    else this.TextPropriety = this.TextPropriety + "z";
                    Console.WriteLine(Text);
                    break;
                case "x_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "X";
                    else this.TextPropriety = this.TextPropriety + "x";
                    Console.WriteLine(Text);
                    break;
                case "c_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "C";
                    else this.TextPropriety = this.TextPropriety + "c";
                    Console.WriteLine(Text);
                    break;
                case "v_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "V";
                    else this.TextPropriety = this.TextPropriety + "v";
                    Console.WriteLine(Text);
                    break;
                case "b_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "B";
                    else this.TextPropriety = this.TextPropriety + "b";
                    Console.WriteLine(Text);
                    break;
                case "n_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "N";
                    else this.TextPropriety = this.TextPropriety + "n";
                    Console.WriteLine(Text);
                    break;
                case "m_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "M";
                    else this.TextPropriety = this.TextPropriety + "m";
                    Console.WriteLine(Text);
                    break;
                case "è_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "E'";
                    else this.TextPropriety = this.TextPropriety + "è";
                    Console.WriteLine(Text);
                    break;
                case "à_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "A'";
                    else this.TextPropriety = this.TextPropriety + "à";
                    Console.WriteLine(Text);
                    break;
                case "ì_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "I'";
                    else this.TextPropriety = this.TextPropriety + "ì";
                    Console.WriteLine(Text);
                    break;
                case "ò_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "O'";
                    else this.TextPropriety = this.TextPropriety + "ò";
                    Console.WriteLine(Text);
                    break;
                case "ù_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "U'";
                    else this.TextPropriety = this.TextPropriety + "ù";
                    Console.WriteLine(Text);
                    break;
                case "uno_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "1";
                    else this.TextPropriety = this.TextPropriety + "1";
                    Console.WriteLine(Text);
                    break;
                case "due_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "2";
                    else this.TextPropriety = this.TextPropriety + "2";
                    Console.WriteLine(Text);
                    break;
                case "tre_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "3";
                    else this.TextPropriety = this.TextPropriety + "3";
                    Console.WriteLine(Text);
                    break;
                case "quattro_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "4";
                    else this.TextPropriety = this.TextPropriety + "4";
                    Console.WriteLine(Text);
                    break;
                case "cinque_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "5";
                    else this.TextPropriety = this.TextPropriety + "5";
                    Console.WriteLine(Text);
                    break;
                case "sei_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "6";
                    else this.TextPropriety = this.TextPropriety + "6";
                    Console.WriteLine(Text);
                    break;
                case "sette_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "7";
                    else this.TextPropriety = this.TextPropriety + "7";
                    Console.WriteLine(Text);
                    break;
                case "otto_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "8";
                    else this.TextPropriety = this.TextPropriety + "8";
                    Console.WriteLine(Text);
                    break;
                case "nove_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "9";
                    else this.TextPropriety = this.TextPropriety + "9";
                    Console.WriteLine(Text);
                    break;
                case "zero_key":

                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "0";
                    else this.TextPropriety = this.TextPropriety + "0";
                    Console.WriteLine(Text);
                    break;
                case "puntointerrogativo_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "?'";
                    else this.TextPropriety = this.TextPropriety + "?";
                    Console.WriteLine(Text);
                    break;
                case "puntoescalamativo_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "!'";
                    else this.TextPropriety = this.TextPropriety + "!";
                    Console.WriteLine(Text);
                    break;
                case "virgola_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + ",";
                    else this.TextPropriety = this.TextPropriety + ",";
                    Console.WriteLine(Text);
                    break;

                case "punto_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + ".";
                    else this.TextPropriety = this.TextPropriety + ".";
                    Console.WriteLine(Text);
                    break;
                case "trattino_key":
                    if (this.isUpperCase) this.TextPropriety = this.TextPropriety + "-";
                    else this.TextPropriety = this.TextPropriety + "-";
                    Console.WriteLine(Text);
                    break;
                case "clear_key":
                    this.TextPropriety = "";
                    break;
                case "spazio_key":
                    this.TextPropriety = TextPropriety + " ";
                    Console.WriteLine(Text);
                    break;
                case "exit_key":
                    ExitViews ev = new ExitViews();
                    ev.Show();
                    break;
                case "canc_key":
                    if (this.TextPropriety.Length != 0)
                        this.TextPropriety = this.TextPropriety.Remove(this.TextPropriety.Length - 1);
                    break;
                case "audio_key":
                    Thread speakThread = new Thread(() => ttsm.ConvertToSpeech(this));
                    speakThread.Start();
                    break;
                case "web_key":
                    WebViews ggvw = new WebViews(this.TextPropriety);
                    ggvw.Show();
                    break;
                case "shift_key":
                    isUpperCase = !isUpperCase;
                    break;
            }
        }


    }
}
