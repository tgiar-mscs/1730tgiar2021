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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tgiar3c1
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            // Calc0
            try
            {
                int index = Int32.Parse(this.inputTextBox0a.Text);
                resultTextBox0.Text = Ex3cCalculations.Calc0(index);
            }
            catch
            {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid index: " + this.inputTextBox0a.Text);
            }

            // Calc1
            string search = this.inputTextBox1a.Text;
            resultTextBox1.Text = Ex3cCalculations.Calc1(search);

            // calc2
            int[] numbers2 = { 11, 22, 23, 34, 10 };
            resultTextBox2.Text = Ex3cCalculations.Calc2(numbers2).ToString();

            // calc3
            double[] numbers3 = { 11.1, 22.2, 23.3, 34.4, 9.0 };
            try
            {
                int count = Int32.Parse(this.inputTextBox3a.Text);
                resultTextBox3.Text = Ex3cCalculations.Calc3(numbers3, count).ToString("f1");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox3a.Text);

            }

            // calc4
            double[] numbers4 = new double[inputListBox4a.Items.Count];
            try
            {
                int count = Int32.Parse(inputListBox4a.Items.Count.ToString());
                for (int i = 0; i < count; i++)
                    numbers4[i] = Double.Parse(inputListBox4a.Items[i].ToString());

                resultTextBox4.Text = Ex3cCalculations.Calc3(numbers4, count).ToString("f1");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox3a.Text);
            }

            // Calc5
            double[] numbers5 = new double[inputListBox5a.Items.Count];
            try
            {
                int count = Int32.Parse(inputListBox5a.Items.Count.ToString());
                for (int i = 0; i < numbers5.Count(); i++)
                {
                    numbers5[i] = Double.Parse(inputListBox5a.Items[i].ToString());
                }
                   

                resultTextBox5.Text = Ex3cCalculations.Calc5(numbers5).ToString("f1");
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox3a.Text);
            }

            // Calc6
            double[] numbers6 = new double[inputListBox6a.Items.Count];

            for (int i = 0; i < numbers6.Count(); i++)
            {
                numbers6[i] = Double.Parse(inputListBox6a.Items[i].ToString());
            }
            double[] aboveAvg = Ex3cCalculations.Calc6(numbers6);

            //resultListBox6.Items.Add(aboveAvg[0]);
            //resultListBox6.Items.Add(aboveAvg[1]);
            foreach (double number in numbers6)
            {
                if (number > Ex3cCalculations.Calc5(numbers6))
                    resultListBox6.Items.Add(number);
            }

        }

        private void addItemButton4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double input = Double.Parse(this.inputTextBox4a.Text);
                this.inputListBox4a.Items.Add(input.ToString("n1"));
                this.resultTextBox4.Text = "";
                this.inputListBox4a.ScrollIntoView(inputListBox4a.Items[inputListBox4a.Items.Count - 1]);
            }
            catch
            {
                MessageBox.Show("Invalid input: " + this.inputTextBox4a.Text);
                this.inputListBox4a.Focus();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");

            inputTextBox0a.Focus();
        }

        private void inputTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

    
    }
}
