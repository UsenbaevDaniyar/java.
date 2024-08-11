import java.util.Locale;

public class Main {
    public static void main(String[] args) {

        Task1(10);

    }

    private static void foo() {
        String str = "heLLLo wOrLd";
        System.out.println(str.toLowerCase());
    }

    public static void Task1(int n) {

        String c1 = "c1";
        String c2 = "c2";

        StringBuilder result = new StringBuilder();
        int k = n * 2;

        for (int i = 0; i < k; i++) {
            result.append(c1);
            result.append(c2);
        }

        System.out.println(result);
    }
}


