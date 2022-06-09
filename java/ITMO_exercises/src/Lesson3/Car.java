package Lesson3;

import java.util.Scanner;

public class Car implements Car_retailer
{
    private static String _color = "transparent";
    public String          color = "transparent";
    public int            weight = 1500;
    public int         wheel_num = 0;


    public static void set_default_color(String new_color)
    {
        Car._color = new_color;
    }

    public void set_color(String new_color)
    {
        this.color = new_color;
    }

    public void set_weight(String weight)
    {
        this.weight = Integer.parseInt(weight);
    }

    public Car(){
    }

    public Car(String car_color)
    {
        this.color = car_color;
    }

    public Car(int car_weight)
    {
        this.weight = car_weight;
    }

    public Car(String car_color, int car_weight)
    {
        this.color = car_color;
        this.weight = car_weight;
    }

    @Override
    public void paint_job(String color)
    {
        this.color = color;
    }

    @Override
    public String toString()
    {
        return "Your car is "+color+","+weight+"kg";
                                                         }

    @Override
    public int set_new_wheels() {
        Scanner scanner = new Scanner(System.in);
        this.wheel_num = scanner.nextInt();
        return 0;
    }

    @Override
    public int check_wheels()
    {
        return wheel_num;
    }
}
