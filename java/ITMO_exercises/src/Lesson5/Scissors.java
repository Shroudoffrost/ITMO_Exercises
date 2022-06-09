package Lesson5;

public class Scissors {
    public static String[] cut_text(String text) {
        String delimiter = " ";
        return text.split(delimiter);
    }
}
