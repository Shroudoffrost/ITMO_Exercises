using System;

namespace Basic_calculator
{
    public class ALU
    {
        public static int power_ = 1;
        public static bool is_calculated_ = false;
        public static bool is_fraction_ = false;
        public static bool is_power_on_ = false;
        public static bool is_op_1_current_ = true;
        public static double operand_1_ = 0;
        public static double operand_2_ = 0;
        public static double result_ = 0;
        public static string operator_ = "bindind source";

        public static void Append_num(int num)
        {
            if(is_op_1_current_)
            {
                if(is_fraction_)
                {
                    power_--;
                    operand_1_ = operand_1_ + (num * Math.Pow(10,power_));
                }
                else operand_1_ = operand_1_ * 10 + num;
            }
            else
            {
                if(is_fraction_)
                {
                    power_--;
                    operand_2_ = operand_2_ + (num * Math.Pow(10,power_));
                }
                else operand_2_ = operand_2_ * 10 + num;
            }
        }

        public static void Calculate()
        {
            switch(operator_)
            {
                case "+":
                    result_ = operand_1_ + operand_2_;
                break;
                    
                case "-":
                    result_ = operand_1_ - operand_2_;
                break;

                case "*":
                    result_ = operand_1_ * operand_2_;
                break;

                case "/":
                    result_ = operand_1_ / operand_2_;
                break;

                case "%":
                    result_ = operand_1_ % operand_2_;
                break;

                case "√":
                    result_ = Math.Sqrt(operand_1_);
                break;
            }
        }
    }
}
