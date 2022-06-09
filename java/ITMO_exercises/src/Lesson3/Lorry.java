package Lesson3;

import Lesson5.Dice;
import Lesson5.Scissors;

public class Lorry extends Car
{
    private String plate_num = null;
    private int wheels = 16;
    private double max_weight = 5000;

    public Lorry(int wheels, int max_weight ,String plate_num) {
        this.wheels = wheels;
        this.max_weight = max_weight;
        this.plate_num = plate_num;
    }

    public void wheeler_dealer(int wheels) {
        Car_retailer carretailer = new Car();
        carretailer.set_new_wheels();
    }

    public void build_divine_lorry()
    {
        Car.set_default_color("divine");
    }



    @Override
    public String toString() {
        return "Lorry{" +
                "plate_num='"+plate_num+'\''+
                ", wheels="  +wheels   +
                ", color="   +color    +
                ", max_weight=" + max_weight +
                '}';
    }
}
