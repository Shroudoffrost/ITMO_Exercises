package Lesson5;

public class Text
{
    public static String what_i_say = "dendandrical nomastic sample Ce text goes CeCr right Ce here!";
    //public static String     what_you_said = "tenet";
    //public static String     what_you_said = "ololol ol ool";
    public static String word_we_look_for = "o";
    public static String    reversed_text = Brain.reverse_word();
    public static String    is_palindrome = String.valueOf(what_i_say.equals(reversed_text));
    public static String[] words;

    public void set_text(String text)
    {
        Text.what_i_say = text;
    }

    @Override
    public String toString() {
        return what_i_say;
    }


}

