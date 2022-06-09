package Lesson6;

public class Bank_officer extends Human
{
    private String job = "";

    public Bank_officer(String this_bank)
    {
        this.work(this_bank);
    }

    private void work(String specific_bank) {
        this.job = specific_bank;
    }

    @Override
    public String toString() {
        return "I work at "+ job;
    }

    public void call_your_daddy()
    {
        System.out.println("and his name is "+super.get_name());
    }
}
