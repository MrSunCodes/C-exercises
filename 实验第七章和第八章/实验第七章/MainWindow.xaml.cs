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

namespace 实验第七章和第八章
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)//name
        {

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)//basic_info
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)//other_info
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)//自动填写文本框
        {
            string a;
            string b;
            string c;
            a = "孙嘉硕";
            b = "201700800460";
            c = "很帅";
            textBox.Text = a;
            textBox1.Text = b;
            textBox2.Text = c;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)//弹出对话框
        {
            string name;
            string basic_info;
            string other_info;
            name = textBox.Text;
            basic_info = textBox1.Text;
            other_info = textBox2.Text;
            MessageBox.Show("姓名是：" + name + "\n" + "基本信息是：" + basic_info + "\n" + "其他信息是：" + other_info + "\n", "学生基本信息", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)//弹出新窗体
        {
            string a= textBox.Text;
            string b=textBox1.Text;
            string c=textBox2.Text;
            string[] s = new string[3];
            s[0] = a;
            s[1] = b;
            s[2] = c;
            Info info = new Info(s);
            info.Show();
        }
    }
}
