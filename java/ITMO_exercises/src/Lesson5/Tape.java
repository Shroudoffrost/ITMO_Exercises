package Lesson5;

public class Tape
{
    public static String glue_in_reverse_order(String[] words){
        StringBuffer sb = new StringBuffer();
        for(String word : words) {
            sb.append(word);
        }
        return sb.toString();
    }


}
