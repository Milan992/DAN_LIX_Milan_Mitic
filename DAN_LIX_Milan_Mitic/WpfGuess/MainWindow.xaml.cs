using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfGuess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // list of cards
        static List<string> cards = new List<string>() { "A", "B", "C", "D", "E", "F", "H", "I", "A", "B", "C", "D", "E", "F", "H", "I" };
        // string to place first opened field
        static string openedFirst;
        // string to place second opened field
        static string openedSecond;
        static bool firstGuess = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Shuffle(cards);
            EnableAllButtons();
        }

        private void EnableAllButtons()
        {
            btn1_1.IsEnabled = true;
            btn1_1.Content = "";
            btn1_2.IsEnabled = true;
            btn1_2.Content = "";
            btn1_3.IsEnabled = true;
            btn1_3.Content = "";
            btn1_4.IsEnabled = true;
            btn1_4.Content = "";

            btn2_1.IsEnabled = true;
            btn2_1.Content = "";
            btn2_2.IsEnabled = true;
            btn2_2.Content = "";
            btn2_3.IsEnabled = true;
            btn2_3.Content = "";
            btn2_4.IsEnabled = true;
            btn2_4.Content = "";

            btn3_1.IsEnabled = true;
            btn3_1.Content = "";
            btn3_2.IsEnabled = true;
            btn3_2.Content = "";
            btn3_3.IsEnabled = true;
            btn3_3.Content = "";
            btn3_4.IsEnabled = true;
            btn3_4.Content = "";

            btn4_1.IsEnabled = true;
            btn4_1.Content = "";
            btn4_2.IsEnabled = true;
            btn4_2.Content = "";
            btn4_3.IsEnabled = true;
            btn4_3.Content = "";
            btn4_4.IsEnabled = true;
            btn4_4.Content = "";
        }

        private static Random rng = new Random();
        /// <summary>
        /// Shufles a list elements in random order.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void btn1_1_Click(object sender, RoutedEventArgs e)
        {
            btn1_1.Content = cards[0];
            if (firstGuess)
            {
                openedFirst = cards[0];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[0];
                if (openedFirst == openedSecond)
                {
                    btn1_1.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn1_1.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn1_2_Click(object sender, RoutedEventArgs e)
        {
            btn1_2.Content = cards[1];
            if (firstGuess)
            {
                openedFirst = cards[1];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[1];
                if (openedFirst == openedSecond)
                {
                    btn1_2.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn1_2.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn1_3_Click(object sender, RoutedEventArgs e)
        {
            btn1_3.Content = cards[2];
            if (firstGuess)
            {
                openedFirst = cards[2];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[2];
                if (openedFirst == openedSecond)
                {
                    btn1_3.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn1_3.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn1_4_Click(object sender, RoutedEventArgs e)
        {
            btn1_4.Content = cards[3];
            if (firstGuess)
            {
                openedFirst = cards[3];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[3];
                if (openedFirst == openedSecond)
                {
                    btn1_4.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn1_4.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn2_1_Click(object sender, RoutedEventArgs e)
        {
            btn2_1.Content = cards[4];
            if (firstGuess)
            {
                openedFirst = cards[4];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[4];
                if (openedFirst == openedSecond)
                {
                    btn2_1.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn2_1.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn2_2_Click(object sender, RoutedEventArgs e)
        {
            btn2_2.Content = cards[5];
            if (firstGuess)
            {
                openedFirst = cards[5];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[5];
                if (openedFirst == openedSecond)
                {
                    btn2_2.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn2_2.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn2_3_Click(object sender, RoutedEventArgs e)
        {
            btn2_3.Content = cards[6];
            if (firstGuess)
            {
                openedFirst = cards[6];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[6];
                if (openedFirst == openedSecond)
                {
                    btn2_3.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn2_3.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn2_4_Click(object sender, RoutedEventArgs e)
        {
            btn2_4.Content = cards[7];
            if (firstGuess)
            {
                openedFirst = cards[7];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[7];
                if (openedFirst == openedSecond)
                {
                    btn2_4.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn2_4.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }


        private void btn3_1_Click(object sender, RoutedEventArgs e)
        {
            btn3_1.Content = cards[8];
            if (firstGuess)
            {
                openedFirst = cards[8];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[8];
                if (openedFirst == openedSecond)
                {
                    btn3_1.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn3_1.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn3_2_Click(object sender, RoutedEventArgs e)
        {
            btn3_2.Content = cards[9];
            if (firstGuess)
            {
                openedFirst = cards[9];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[9];
                if (openedFirst == openedSecond)
                {
                    btn3_2.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn3_2.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn3_3_Click(object sender, RoutedEventArgs e)
        {
            btn3_3.Content = cards[10];
            if (firstGuess)
            {
                openedFirst = cards[10];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[10];
                if (openedFirst == openedSecond)
                {
                    btn3_3.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn3_3.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn3_4_Click(object sender, RoutedEventArgs e)
        {
            btn3_4.Content = cards[11];
            if (firstGuess)
            {
                openedFirst = cards[11];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[11];
                if (openedFirst == openedSecond)
                {
                    btn3_4.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn3_4.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn4_4_Click(object sender, RoutedEventArgs e)
        {
            btn4_4.Content = cards[15];
            if (firstGuess)
            {
                openedFirst = cards[15];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[15];
                if (openedFirst == openedSecond)
                {
                    btn4_4.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn4_4.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn4_3_Click(object sender, RoutedEventArgs e)
        {
            btn4_3.Content = cards[14];
            if (firstGuess)
            {
                openedFirst = cards[14];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[14];
                if (openedFirst == openedSecond)
                {
                    btn4_3.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn4_3.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn4_2_Click(object sender, RoutedEventArgs e)
        {
            btn4_2.Content = cards[13];
            if (firstGuess)
            {
                openedFirst = cards[13];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[13];
                if (openedFirst == openedSecond)
                {
                    btn4_2.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn4_2.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void btn4_1_Click(object sender, RoutedEventArgs e)
        {
            btn4_1.Content = cards[12];
            if (firstGuess)
            {
                openedFirst = cards[12];
                firstGuess = false;
            }
            else
            {
                openedSecond = cards[12];
                if (openedFirst == openedSecond)
                {
                    btn4_1.IsEnabled = false;
                    CheckButtons();
                }
                else
                {
                    btn4_1.Content = "";
                    ClearContent();
                }
                firstGuess = true;
            }
        }

        private void CheckButtons()
        {
            if (btn1_1.Content != "")
            {
                btn1_1.IsEnabled = false;
            }
             if (btn1_2.Content != "")
            {
                btn1_2.IsEnabled = false;
            }
             if (btn1_3.Content != "")
            {
                btn1_3.IsEnabled = false;
            }
             if (btn1_4.Content != "")
            {
                btn1_4.IsEnabled = false;
            }
             if (btn2_1.Content != "")
            {
                btn2_1.IsEnabled = false;
            }
             if (btn2_2.Content != "")
            {
                btn2_2.IsEnabled = false;
            }
             if (btn2_3.Content != "")
            {
                btn2_3.IsEnabled = false;
            }
             if (btn2_4.Content != "")
            {
                btn2_4.IsEnabled = false;
            }
             if (btn3_1.Content != "")
            {
                btn3_1.IsEnabled = false;
            }
             if (btn3_2.Content != "")
            {
                btn3_2.IsEnabled = false;
            }
             if (btn3_3.Content != "")
            {
                btn3_3.IsEnabled = false;
            }
             if (btn3_4.Content != "")
            {
                btn3_4.IsEnabled = false;
            }
             if (btn4_1.Content != "")
            {
                btn4_1.IsEnabled = false;
            }
             if (btn4_2.Content != "")
            {
                btn4_2.IsEnabled = false;
            }
             if (btn4_3.Content != "")
            {
                btn4_3.IsEnabled = false;
            }
             if (btn4_4.Content != "")
            {
                btn4_4.IsEnabled = false;
            }
        }
        private void ClearContent()
        {
            btn1_1.Content = "";

            btn1_2.Content = "";

            btn1_3.Content = "";

            btn1_4.Content = "";

            btn2_1.Content = "";

            btn2_2.Content = "";

            btn2_3.Content = "";

            btn2_4.Content = "";

            btn3_1.Content = "";

            btn3_2.Content = "";

            btn3_3.Content = "";

            btn3_4.Content = "";

            btn4_1.Content = "";

            btn4_2.Content = "";

            btn4_3.Content = "";

            btn4_4.Content = "";
        }

    }
}
