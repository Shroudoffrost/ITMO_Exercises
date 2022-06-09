package Lesson6;

public class Client extends Human{
    private String client_at = "none";

    public Client(String bank_name)
    {
        this.client_at = bank_name;
    }

    public Client(String first_name, String last_name, String bank_name)
    {
        this.set_name(first_name, last_name);
        this.client_at = bank_name;
    }

    public String which_bank() {
        return client_at;
    }
}
