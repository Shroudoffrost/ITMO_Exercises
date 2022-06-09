package Lesson3;

import Lesson5.Frankensteins_reader;

public class Drive_car {
    public static void main(String[] args)
    {
        Car_retailer kamaz = new Lorry(18, 7000, GIBDD.get_plate());
        System.out.println(kamaz);
        kamaz.paint_job("black");
    }
}
