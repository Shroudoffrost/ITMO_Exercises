package Lesson6;

public class Human_tester {
    public static void main(String[] args)
    {
        Client client = new Client("Tom","Smithson" ,"Banco rottO");
        System.out.println(client.get_name()+"\n"+client.which_bank());

        Bank_officer banker = new Bank_officer("Sderbank");
        banker.set_name("Incontinentia","Buttocks");
        System.out.println(banker);
    }
}
