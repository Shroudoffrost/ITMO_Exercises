package Lesson6;

public abstract class Human {
    private String first_name = "john";
    private String last_name = "cena";
    private String full_name = "";

    public String get_name() {
        return full_name.concat(first_name+" "+last_name);
    }

    public void set_name(String first_name, String last_name)
    {
        this.first_name = first_name;
        this.last_name  = last_name;
    }

    @Override
    public String toString() {
        return get_name();
    }

    public Human() {
    }

    public Human(String first_name, String last_name) {

    }
}
