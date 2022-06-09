package Lesson5;

import Lesson5.*;

public class Frankensteins_reader
{
    public static void read_out_words()
    {
        String what_you_said = Head.remembers();
        Mouth.read_out_words(Scissors.cut_text(what_you_said));
    }

    public static void find_longest_word() {
        String what_you_said = Head.remembers();
        String longest_word = Brain.find_longest_word(what_you_said);
        Mouth.say_the_text(longest_word);
    }

    public static void say_is_word_a_palindrome(){
        Mouth.say_the_answer();
    }

    public static void say_random_word(){
        Mouth.say_the_text(Brain.find_random_word());
    }

    public static void count_entries() {
        Mouth.say_the_text(Brain.find_word(Text.word_we_look_for));
    }
}