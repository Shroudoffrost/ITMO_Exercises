package Lesson5;

import java.util.Random;

public class Dice {
    public static String pick_word(String[] words)
    {
        int   limit = words.length + 1;
        Random dice = new Random();
        return words[dice.nextInt(limit-1)];
    }
}
