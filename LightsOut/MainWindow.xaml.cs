using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace LightsOut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void toggleAdjButtons(List<Button> btnList)
        {
            foreach (Button b in btnList)
            {
                if (b.Background == Brushes.Yellow)
                    b.Background = Brushes.LightGray;
                else
                    b.Background = Brushes.Yellow;
            }
        }

        private void incrementCounter()
        { 
            int count;
            int.TryParse(ClickCount.Text, out count);
            count++;
            ClickCount.Text = count.ToString();
        }

        private void resetCounter()
        {
            ClickCount.Text = "0";
        }

        private void btn_0_0_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_0_0, btn_0_1, btn_1_0 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_0_1_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_0_1, btn_0_0, btn_0_2, btn_1_1 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_0_2_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_0_2, btn_0_1, btn_0_3, btn_1_2 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_0_3_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_0_3, btn_0_2, btn_0_4, btn_1_3 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_0_4_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_0_4, btn_0_3, btn_1_4 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_1_0_Click(object sender, RoutedEventArgs e)
        {
            List <Button> btnList = new List<Button>() { btn_1_0, btn_0_0, btn_1_1, btn_2_0 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_1_1_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_1_1, btn_0_1, btn_1_0, btn_1_2, btn_2_1 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_1_2_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_1_2, btn_0_2, btn_1_1, btn_1_3, btn_2_2 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_1_3_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_1_3, btn_0_3, btn_1_2, btn_1_4, btn_2_3 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_1_4_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_1_4, btn_0_4, btn_1_3, btn_2_4 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_2_0_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_2_0, btn_1_0, btn_2_1, btn_3_0 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_2_1_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_2_1, btn_1_1, btn_2_0, btn_2_2, btn_3_1 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_2_2_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_2_2, btn_1_2, btn_2_1, btn_2_3, btn_3_2 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_2_3_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_2_3, btn_1_3, btn_2_2, btn_2_4, btn_3_3 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_2_4_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_2_4, btn_1_4, btn_2_3, btn_3_4 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_3_0_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_3_0, btn_2_0, btn_3_1, btn_4_0 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_3_1_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_3_1, btn_2_1, btn_3_0, btn_3_2, btn_4_1 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_3_2_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_3_2, btn_2_2, btn_3_1, btn_3_3, btn_4_2 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_3_3_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_3_3, btn_2_3, btn_3_2, btn_3_4, btn_4_3 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_3_4_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_3_4, btn_2_4, btn_3_3, btn_4_4 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_4_0_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_4_0, btn_3_0, btn_4_1 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_4_1_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_4_1, btn_3_1, btn_4_0, btn_4_2 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_4_2_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_4_2, btn_3_2, btn_4_1, btn_4_3 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_4_3_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_4_3, btn_3_3, btn_4_2, btn_4_4 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void btn_4_4_Click(object sender, RoutedEventArgs e)
        {
            List<Button> btnList = new List<Button>() { btn_4_4, btn_3_4, btn_4_3 };
            toggleAdjButtons(btnList);
            incrementCounter();
        }

        private void AppExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearAllLights_Click(object sender, RoutedEventArgs e)
        {
            btn_0_0.Background = Brushes.LightGray;
            btn_0_1.Background = Brushes.LightGray;
            btn_0_2.Background = Brushes.LightGray;
            btn_0_3.Background = Brushes.LightGray;
            btn_0_4.Background = Brushes.LightGray;
            btn_1_0.Background = Brushes.LightGray;
            btn_1_1.Background = Brushes.LightGray;
            btn_1_2.Background = Brushes.LightGray;
            btn_1_3.Background = Brushes.LightGray;
            btn_1_4.Background = Brushes.LightGray;
            btn_2_0.Background = Brushes.LightGray;
            btn_2_1.Background = Brushes.LightGray;
            btn_2_2.Background = Brushes.LightGray;
            btn_2_3.Background = Brushes.LightGray;
            btn_2_4.Background = Brushes.LightGray;
            btn_3_0.Background = Brushes.LightGray;
            btn_3_1.Background = Brushes.LightGray;
            btn_3_2.Background = Brushes.LightGray;
            btn_3_3.Background = Brushes.LightGray;
            btn_3_4.Background = Brushes.LightGray;
            btn_4_0.Background = Brushes.LightGray;
            btn_4_1.Background = Brushes.LightGray;
            btn_4_2.Background = Brushes.LightGray;
            btn_4_3.Background = Brushes.LightGray;
            btn_4_4.Background = Brushes.LightGray;
            resetCounter();
        }

        private void SetAllLights_Click(object sender, RoutedEventArgs e)
        {
            btn_0_0.Background = Brushes.Yellow;
            btn_0_1.Background = Brushes.Yellow;
            btn_0_2.Background = Brushes.Yellow;
            btn_0_3.Background = Brushes.Yellow;
            btn_0_4.Background = Brushes.Yellow;
            btn_1_0.Background = Brushes.Yellow;
            btn_1_1.Background = Brushes.Yellow;
            btn_1_2.Background = Brushes.Yellow;
            btn_1_3.Background = Brushes.Yellow;
            btn_1_4.Background = Brushes.Yellow;
            btn_2_0.Background = Brushes.Yellow;
            btn_2_1.Background = Brushes.Yellow;
            btn_2_2.Background = Brushes.Yellow;
            btn_2_3.Background = Brushes.Yellow;
            btn_2_4.Background = Brushes.Yellow;
            btn_3_0.Background = Brushes.Yellow;
            btn_3_1.Background = Brushes.Yellow;
            btn_3_2.Background = Brushes.Yellow;
            btn_3_3.Background = Brushes.Yellow;
            btn_3_4.Background = Brushes.Yellow;
            btn_4_0.Background = Brushes.Yellow;
            btn_4_1.Background = Brushes.Yellow;
            btn_4_2.Background = Brushes.Yellow;
            btn_4_3.Background = Brushes.Yellow;
            btn_4_4.Background = Brushes.Yellow;
            resetCounter();
        }
    }
}
