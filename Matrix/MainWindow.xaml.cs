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

namespace Matrix
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Matrix3x3 matrix3X3 = new Matrix3x3();
                matrix3X3.Matrix[0, 0] = Convert.ToDouble(textBox00.Text == "" ? textBox00.Text = "0" : textBox00.Text.Replace(".", ","));
                matrix3X3.Matrix[0, 1] = Convert.ToDouble(textBox01.Text == "" ? textBox01.Text = "0" : textBox01.Text.Replace(".", ","));
                matrix3X3.Matrix[0, 2] = Convert.ToDouble(textBox02.Text == "" ? textBox02.Text = "0" : textBox02.Text.Replace(".", ","));
                matrix3X3.Matrix[1, 0] = Convert.ToDouble(textBox10.Text == "" ? textBox10.Text = "0" : textBox10.Text.Replace(".", ","));
                matrix3X3.Matrix[1, 1] = Convert.ToDouble(textBox11.Text == "" ? textBox11.Text = "0" : textBox11.Text.Replace(".", ","));
                matrix3X3.Matrix[1, 2] = Convert.ToDouble(textBox12.Text == "" ? textBox12.Text = "0" : textBox12.Text.Replace(".", ","));
                matrix3X3.Matrix[2, 0] = Convert.ToDouble(textBox20.Text == "" ? textBox20.Text = "0" : textBox20.Text.Replace(".", ","));
                matrix3X3.Matrix[2, 1] = Convert.ToDouble(textBox21.Text == "" ? textBox21.Text = "0" : textBox21.Text.Replace(".", ","));
                matrix3X3.Matrix[2, 2] = Convert.ToDouble(textBox22.Text == "" ? textBox22.Text = "0" : textBox22.Text.Replace(".", ","));
                labelResult.Content = matrix3X3.GetDeterminant().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
