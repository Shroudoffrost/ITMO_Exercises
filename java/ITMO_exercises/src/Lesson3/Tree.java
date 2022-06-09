package Lesson3;

public class Tree
{
    private boolean isAlive = true;
    private int age;
    private String name;

    public Tree(int age, String name)
    {
        this.age = age;
        this.name = name;
                       }

    public Tree(int age, String name, boolean isAlive)
    {
        this.age = age;
        this.name = name;
        this.isAlive = isAlive;
                                  }

    public Tree()
    {
        System.out.println("The tree has been planted");
                                                       }
}
