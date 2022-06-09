package Lesson5;

public class Pen {
    public void write_words(String text)
    {
        Text.what_i_say = text;
    }


    public static String reverse_text(String text)
    {
        StringBuilder buffer = new StringBuilder(text);
        return String.valueOf(buffer.reverse());
    }
}
