package Lesson3;

import Lesson5.Dice;
import Lesson5.Scissors;

public class GIBDD {
    public static String get_plate() {
        String[] set_of_words = Scissors.cut_text("completely different chars here");
        return "LRRY "+ Dice.pick_word(set_of_words);
    }
}
