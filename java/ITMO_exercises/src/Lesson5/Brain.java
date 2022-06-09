package Lesson5;

public class Brain
//{
//    public static String find_longest_word(String[] words) {
//        String longest_word = null;
//        int longest_length = 0;
//
//        for (String word : words) {
//            if (word.length() > longest_length) {
//                longest_word = word;
//                longest_length = word.length();
//            }
//
//        }
//        return longest_word;
//    }

{
    public static String find_longest_word(String what_i_say) {
        return compare_words(Scissors.cut_text(what_i_say));
    }

    public static String compare_words(String[] words)
    {
        String longest_word = null;
        int longest_length = 0;
        for (String word : words) {
            if (word.length() > longest_length) {
                longest_word = word;
                longest_length = word.length();
            }

        }
        return longest_word;
    }

    public static String reverse_word() {
        StringBuilder sb = new StringBuilder(Text.what_i_say);
        return String.valueOf(sb.reverse());
    }

    public static String find_random_word() {
        String random_word = Dice.pick_word(Scissors.cut_text(Head.remembers()));
        return random_word;
    }

    public static String find_word(String what_we_look_for) {
        String sample = Text.what_i_say;
        if(sample.contains(what_we_look_for))
        {
            count(sample, what_we_look_for);
        }
        return sample;
    }

    public static int count(String sample ,String what_we_look_for) {
        int count = 0;
        while (sample.contains(what_we_look_for))
        {
            sample = sample.replaceFirst(what_we_look_for, "x");
            count++;
        }
        System.out.println(count +" times");
        return count;
    }

}