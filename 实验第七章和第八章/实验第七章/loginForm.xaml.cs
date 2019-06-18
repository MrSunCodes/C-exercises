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

namespace 实验第七章和第八章
{
    /// <summary>
    /// loginForm.xaml 的交互逻辑
    /// </summary>
    public partial class loginForm : Window
    {
        private int ErrorTimes = 0;
        public loginForm()
        {
            InitializeComponent();
            //向combobox中加入元素          
            comboBox.Items.Add("管理员");
            comboBox.Items.Add("一般用户");
            comboBox.SelectedIndex = 0;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)//username
        {

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)//password
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = this.textBox.Text;
            string password = this.textBox1.Text;
            string com = comboBox.Text;
            if (com == "管理员")
            {
                if (password == "123abc")
                {
                    MainWindow mw = new MainWindow();
                    mw.WindowStartupLocation = WindowStartupLocation.Manual;
                    mw.Left = this.Left;
                    mw.Top = this.Top;
                    mw.Show();
                    this.Close();
                }
                else
                {
                    ErrorTimes++;
                    if (ErrorTimes >= 3)
                    {
                        MessageBox.Show("错误次数过多，程序即将退出！");
                        Application.Current.Shutdown();
                    }


                    MessageBox.Show("密码错误，请重试！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                if (password == "abcabc")
                {
                    MainWindow mw = new MainWindow();
                    mw.WindowStartupLocation = WindowStartupLocation.Manual;
                    mw.Left = this.Left;
                    mw.Top = this.Top;
                    mw.Show();
                    this.Close();
                }
                else
                {
                    ErrorTimes++;
                    if (ErrorTimes >= 3)
                    {
                        MessageBox.Show("错误次数过多，程序即将退出！");
                        Application.Current.Shutdown();
                    }
                    MessageBox.Show("密码错误，请重试！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
