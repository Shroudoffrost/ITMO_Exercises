package Lesson3;

import java.util.Scanner;

import static java.lang.System.out;

public class Run_car_old {
    public static void main(String[] args) {
        int carOption;

        Scanner scanner = new Scanner(System.in);

        Car car;
        out.println("Set\ncolor  [1]\nweight [2]\nboth   [3]\nnone   [4]\nfor the car?");
        carOption = scanner.nextInt();

        switch (carOption)
        {
            case 1:
                out.print("Enter color: ");
                car = new Car(scanner.nextLine());
                out.println(car);
                break;
            case 2:
                out.print("Enter weight");
                car = new Car(scanner.nextInt());
                out.println(car);
                break;
            case 3:
                out.print("Enter color and weight");
                car = new Car(scanner.nextLine(), scanner.nextInt());
                out.println(car);
                break;
            case 4:
                car = new Car();
                out.println("default car\n"+car+"\n\nisn't really visible.");
                break;
        }
    }
}
