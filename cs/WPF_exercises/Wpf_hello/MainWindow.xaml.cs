using System;
using System.IO;
using System.Collections.Generic;
using System.Windows;

namespace Wpf_hello
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn_set_name.IsEnabled = false;
            btn_show_name.IsEnabled = false;
        }

        private void btn_set_name_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new
                StreamWriter("username.txt");
                sw.WriteLine(tb_name.Text);
                sw.Close();
                btn_show_name.IsEnabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_name_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader("username.txt");
                label_name.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
             }
             catch(Exception ex)
             {
                MessageBox.Show(ex.Message);
             }
        }

        private void tb_name_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            btn_set_name.IsEnabled = true;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            myTextBox.Text = DateTime.Now.ToString();
        }
    }
}
