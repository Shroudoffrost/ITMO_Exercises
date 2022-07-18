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

namespace Basic_calculator
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

        private void btn_on_Click(object sender, RoutedEventArgs e)
        {
            if (ALU.is_power_on_) return;
            else
            {
                ALU.is_power_on_ = true;
                ALU.is_calculated_ = false;
                ALU.operand_1_ = 0;
                ALU.operand_2_ = 0;
                ALU.result_ = 0;
                main_display.Text = ALU.operand_1_.ToString();
                small_display.Text = "";
            }
        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            if (ALU.is_power_on_)
            {
                ALU.is_calculated_ = false;
                ALU.operand_1_ = 0;
                ALU.operand_2_ = 0;
                ALU.result_ = 0;
                ALU.power_ = 1;
                main_display.Text = ALU.operand_1_.ToString();
                small_display.Text = "";
            }
            else return;
        }

        private void btn_pnt_Click(object sender, RoutedEventArgs e)
        {
            ALU.is_fraction_ = true;
            ALU.power_ = 0;
        }

        private void btn_00_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(0);
            ALU.Append_num(0);
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(0);
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(1);
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(2);
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(3);
        }
        
        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(4);
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(5);
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(6);
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(7);
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(8);
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            ALU.Append_num(9);
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            ALU.is_op_1_current_ = false;
            ALU.operator_ = "+";
            small_display.Text = ALU.operand_1_.ToString() + " + ";
            main_display.Text = ALU.operand_2_.ToString();
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            ALU.is_op_1_current_ = false;
            ALU.operator_ = "-";
            small_display.Text = ALU.operand_1_.ToString() + " - ";
            main_display.Text = ALU.operand_2_.ToString();
        }

        private void btn_mul_Click(object sender, RoutedEventArgs e)
        {
            ALU.is_op_1_current_ = false;
            ALU.operator_ = "*";
            small_display.Text = ALU.operand_1_.ToString() + " * ";
            main_display.Text = ALU.operand_2_.ToString();
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            ALU.is_op_1_current_ = false;
            ALU.operator_ = "/";
            small_display.Text = ALU.operand_1_.ToString() + " / ";
            main_display.Text = ALU.operand_2_.ToString();
        }

        private void btn_mod_Click(object sender, RoutedEventArgs e)
        {
            ALU.is_op_1_current_ = false;
            ALU.operator_ = "%";
            small_display.Text = ALU.operand_1_.ToString() + " % ";
            main_display.Text = ALU.operand_2_.ToString();
        }

        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {
            if(ALU.operand_1_ <= 0) main_display.Text = "Nan";
            else ALU.operator_ = "√";
            ALU.is_op_1_current_ = false;
            
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            ALU.Calculate();
            ALU.is_calculated_ = true;
            ALU.power_ = 1;
            ALU.is_fraction_ = false;
            ALU.is_op_1_current_ = true;
            small_display.Text = "";
            main_display.Text = ALU.result_.ToString();
        }

        private void main_display_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
