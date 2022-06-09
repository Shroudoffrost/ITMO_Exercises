package Lesson1;

import java.util.Scanner;

import static java.lang.Integer.parseInt;

public class Lesson1
{
    public static void Task_1()
    {
        System.out.println("\n====== task 1 ====== \n");
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаю");
        System.out.println("Java");
        System.out.println("\n====== ------ ====== \n");
                                                            }

    public static void Task_2()
    {
        System.out.println("\n====== task 2 ====== \n");
        double task2_result1 = 0;
        int task2_result2 = 0;
        int t1a = 46;
        int t1b = 10;
        double t1c = 3.0;
        int t1d = 29;
        int t1e = 4;
        int t1f = -15;
        task2_result1 = (t1a+t1b) * (t1b/t1c);
        task2_result2 = t1d * t1e * t1f;

        System.out.println(task2_result1);
        System.out.println(task2_result2);
        System.out.println("\n====== --end-- ====== \n");
                                                            }

    public static void Task_3()
    {
        System.out.println("\n====== task 3 ====== \n");
        int number = 10500;
        double result = (number/10d)/10;
        System.out.println(result);
        System.out.println("\n====== --end-- ====== \n");
                                                            }

    public static void Task_4()
    {
        System.out.println("\n====== task 4 ====== \n");
        double t3a = 3.6;
        double t3b = 4.1;
        double t3c = 5.9;
        double task3_result = t3a*t3b*t3c;
        System.out.println(task3_result);
        System.out.println("\n====== --end-- ====== \n");
                                                            }

    public static void Task_5()
    {
        System.out.println("\n====== task 5 ====== \n");
        Scanner scanner = new Scanner(System.in);
        int input = 0;
        System.out.println("test number is initialized as "+input+" Enter your number to get it back");
        input = scanner.nextInt();
        System.out.println("here is your test number — "+input);
        System.out.println("\n====== --end-- ====== \n");
                                                            }

    public static void Task_6()
    {
        System.out.println("\n====== task 6 ====== \n");
        System.out.println("Enter number to check odd or even");
        int b = 0;
        Scanner scanner = new Scanner(System.in);
        b = scanner.nextInt();

        if (b % 2 == 0)
        {
            System.out.println(b+" is even");
                                                }
        else
        {
            System.out.println(b+" is odd");
                                                }

        System.out.println("\n====== --end-- ====== \n");

                                                            }

}
