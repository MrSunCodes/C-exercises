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
    /// Info.xaml 的交互逻辑
    /// </summary>
    public partial class Info : Window
    {
        private string[] s = new string[3];
        public Info(string[] s)
        {
            this.s[0] = s[0];
            this.s[1] = s[1];
            this.s[2] = s[2];
            InitializeComponent();
            this.textBox.Text = this.s[0];
            this.textBox1.Text = this.s[1];
            this.textBox2.Text = this.s[2];
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)//basic_info
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)//name
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)//other_info
        {

        }
    }
}
