package Lesson5;

public class Mouth
{
    public static void read_out_words(String[] words) {
        for (String word : words) {
            System.out.println(word);
        }
    }

    public static void say_reversed_word()
    {
        System.out.println(Text.reversed_text);
    }

    public static void say_the_answer()
    {
        System.out.println(Text.is_palindrome);
    }


    public static void say_the_text(String word)
    {
        System.out.println(word);
    }
//    public static String display_random_word(String random_word) {
//        return Text.random_word;
//    }
//
//    public static void display_text_fully_reversed() {
//        System.out.println(Text.text_reversed_by_word);
//    }
}
