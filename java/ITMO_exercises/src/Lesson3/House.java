package Lesson3;

import java.util.Scanner;

public class House
{
    private String name;
    private int storeys;
    private int buildDate;
    private static int nextId = 1000;
    private int Id;


    public House(String name, int storeys, int buildDate)
    {
        this.name = name;
        this.storeys = storeys;
        this.buildDate = buildDate;
        Id = nextId;
        nextId++;
                    }

    public void setInfo()
    {
        Scanner scanner = new Scanner(System.in);

        System.out.print("set name");
        String name = scanner.nextLine();

        System.out.print("set number of storeys");
        int storeys = scanner.nextInt();

        System.out.print("set build date");
        int build_date = scanner.nextInt();

        this.storeys = storeys;
        buildDate = build_date;
        this.name = name;
                       }

    public void getBuildingAge()
    {

        System.out.println();
    }

    @Override
    public String toString()
    {
        if (storeys > 1)
        {
            return Id+"\n" + name + "\n" + storeys + " storeys\n" + "Built in " + buildDate;
                                                                                                }
        else
        {
            return Id+"\n" + name + "\n" + storeys + " storey\n" + "Built in " + buildDate;
                                                                                                }

                                                                                                    }
}
