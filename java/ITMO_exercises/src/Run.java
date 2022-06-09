import Lesson1.*;
import Lesson2.*;
import Lesson3.*;
import java.util.Arrays;
import java.util.Scanner;

import static java.lang.Integer.parseInt;
import static java.lang.System.in;
import static java.lang.System.out;

public class Run
{
    public static void main(String[] args)
    {
        boolean isRun = true;
        int lessonNum;
        int taskNum;
        String response;
        int carOption;
        int carWeight;
        String carColor;
        Scanner scanner = new Scanner(in);

        while (isRun)
        {
            out.print("pick lesson ");
            lessonNum = parseInt(scanner.next());

            switch (lessonNum)
            {
                case 1:
                    out.print("pick task ");
                    taskNum = parseInt(scanner.next());

                    switch (taskNum)
                    {
                        case 1:
                            Lesson1.Task_1();
                            break;
                        case 2:
                            Lesson1.Task_2();
                            break;
                        case 3:
                            Lesson1.Task_3();
                            break;
                        case 4:
                            Lesson1.Task_4();
                            break;
                        case 5:
                            Lesson1.Task_5();
                            break;
                        case 6:
                            Lesson1.Task_6();
                            break;
                                                }
                                                break;

                case 2:
                    out.print("pick task ");
                    taskNum = parseInt(scanner.next());
                    Lesson2 lesson2 = new Lesson2();

                    switch (taskNum)
                    {
                        case 1:
                            lesson2.Task_1();
                            break;
                        case 2:
                            lesson2.Task_2();
                            break;
                        case 3:
                            lesson2.Task_3();
                            break;
                        case 4:
                            lesson2.Task_4();
                            break;
                        case 5:
                            lesson2.Task_5();
                            break;
                        case 6:
                            lesson2.Task_6_search_by_key();
                            break;
                        case 7:
                            lesson2.Task_7_check_if_sorted_asc();
                            break;
                        case 8:
                            lesson2.Task_8_sizeable_array();
                            break;
                        case 9:
                            lesson2.Task_9_swap_ends();
                            break;
                        case 10:
                            Lesson2.Task_10_find_unique();
                            break;
                        case 11:
                            out.println(Arrays.toString(Lesson2.Task_11_merge_sort(lesson2.Task_8_sizeable_array())));
                            break;
                        case 12:
                            Calculator.run();
                            break;
                                                }
                                                break;

                case 3:
                    out.print("run class: Study — 1, Car — 2, House — 3, Tree — 4: ");
                    taskNum = parseInt(scanner.next());

                    switch (taskNum)
                    {
                        case 1:
                            Study study = new Study("Goddamnit, Java");
                            study.printCourse();
                            out.println(study);
                            break;
                        case 2:
                            Car car;
                            out.println("Set\ncolor  [1]\nweight [2]\nboth   [3]\nnone   [4]\nfor the car?");
                            carOption = scanner.nextInt();

                            switch (carOption)
                            {
                                case 1:
                                    out.print("Enter color: ");
                                    carColor = scanner.next();
                                    car = new Car(carColor);
                                    out.println(car);
                                    break;
                                case 2:
                                    out.print("Enter weight");
                                    carWeight = scanner.nextInt();
                                    car = new Car(carWeight);
                                    out.println(car);
                                    break;
                                case 3:
                                    out.print("Enter color and weight");
                                    carColor = scanner.next();
                                    carWeight = scanner.nextInt();
                                    car = new Car(carColor, carWeight);
                                    out.println(car);
                                    break;
                                case 4:
                                    car = new Car();
                                    out.println("default car\n"+car+"\n\nisn't really visible.");
                                    break;
                                             }
                                             break;
                        case 3:
                            House house_1 = new House("Ministry of Love", 3, 1984);
                            System.out.println(house_1);
                            House house_2 = new House("Ministry of truth", 2, 1984);
                            System.out.println(house_2);
                            house_1.getBuildingAge();
                            break;
                        case 4:
                            Tree birch = new Tree(50, "birch", true);
                            Tree oak = new Tree(300, "stick");
                            Tree tree = new Tree();
                            break;
                                                }
                                                break;

            }

            out.print("one more? y/n: ");
            response = scanner.next();


            if (response.equals("n"))
            {

                isRun = false;
                out.print("bye");
                                    }
            else
            {
                out.print("right, ");
                                        }

                                            }

                                                }
}
