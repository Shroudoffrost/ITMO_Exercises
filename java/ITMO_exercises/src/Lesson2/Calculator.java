package Lesson2;

import java.util.Scanner;

public class Calculator
{
    static double num_1;
    static double num_2;
    static double result;

    public static void run()
    {
        System.out.println("running calculator");
        Scanner scanner = new Scanner(System.in);
        Calculator.num_1 = scanner.nextDouble();
        String operator = scanner.next();

        switch (operator)
        {
            case "+":
                num_2 = scanner.nextDouble();
                Add(num_1, num_2);
                break;
            case "-":
                num_2 = scanner.nextDouble();
                Subtract(num_1, num_2);
                break;
            case "*":
                num_2 = scanner.nextDouble();
                Multiply(num_1, num_2);
                break;
            case "/":
                num_2 = scanner.nextDouble();
                Divide(num_1, num_2);
                break;
            case "^":
                Square(num_1);
                break;
            case "r":
                Root(num_1);
                break;
        }

    }

    public static void Add(double num_1, double num_2)
    {
        Calculator.result = num_1 + num_2;
        System.out.println(result);
                                      }

    public static void Subtract(double num_1, double num_2)
    {
        result = num_1 - num_2;
        System.out.println(result);
                                      }

    public static void Multiply(double num_1, double num_2)
    {
        result = num_1 * num_2;
        System.out.println(result);
                                      }

    public static void Divide(double num_1, double num_2)
    {
        result = num_1 / num_2;
        System.out.println(result);
                                      }

    public static void Square(double num_1)
    {
        result = num_1*num_1;
        System.out.println(result);
                                      }

    public static void Root(double num_1)
    {
        result = (int)num_1 >> 1;
        System.out.println(result);
    }
}
