package Lesson5;

public class Head {
    public static String remembers() {
        return Text.what_i_say;
    }

    public static void memorizes(String memo) {
        Text.what_i_say = memo;
    }
}
