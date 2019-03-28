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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RunButton
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        DoubleAnimation dA_X;
        DoubleAnimation dA_Y;
        TransformGroup tGroup;
        public MainWindow()
        {
            InitializeComponent();
            dA_X = new DoubleAnimation();
            dA_Y = new DoubleAnimation();
            dA_X.Duration = TimeSpan.FromSeconds(0.1);
            dA_Y.Duration = TimeSpan.FromSeconds(0.15);
            tGroup = new TransformGroup();
            tGroup.Children.Add(new TranslateTransform(0, 0));
        }

        private void ButtonPushMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok! You win!!! Congratulations!");
        }
        private void MoveControl(Control control)
        {
            control.RenderTransform = tGroup;
            dA_X.To = r.Next(0, (int)(canvas.Width - ButtonPushMe.Width));
            dA_Y.To = r.Next(0,(int)(canvas.Height - ButtonPushMe.Height));
            TranslateTransform tt = (control.RenderTransform as TransformGroup).Children[0] as TranslateTransform;
            tt.BeginAnimation(TranslateTransform.XProperty, dA_X);
            tt.BeginAnimation(TranslateTransform.YProperty, dA_Y);
        }

        private void ButtonPushMe_MouseEnter(object sender, MouseEventArgs e)
        {
            MoveControl(ButtonPushMe);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            canvas.Width = Width-6.4;
            canvas.Height = Height-30;
            if(canvas.Width<200 && canvas.Height<200)
                MessageBox.Show("It's not fair!!! I am just a simply button and I can't resist anymore!!! Where is the fair play??? ");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            canvas.Width = Width - 6.4;
            canvas.Height = Height - 30;
        }
    }
}
