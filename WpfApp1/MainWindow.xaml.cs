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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double moneyincome, moneypay, moneyneed, finalday;

            moneyincome = Convert.ToDouble(income.Text);
            moneypay = Convert.ToDouble(pay.Text);
            moneyneed = Convert.ToDouble(need.Text);

            finalday = Math.Ceiling(moneyneed / (moneyincome - moneypay));

            if (finalday < 0)
            {
                MessageBox.Show("คุณมีรายจ่ายไม่เพียงพอต่อความต้องการ");
                DayTextBox.Text = Convert.ToString(finalday);
            }
            else
            {
                MessageBox.Show("คุณต้องใช้เวลาทั้งหมด " + finalday + " วัน");
                DayTextBox.Text = Convert.ToString(finalday);
            }

            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void surname_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

    }
}
