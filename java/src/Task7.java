import java.util.*;

public class Task7 {
    public static void main(String[] args) {
        List<Integer> numbers = new ArrayList<>();
        Random random = new Random();

        for (int i = 0; i < 10; i++) {
            numbers.add(random.nextInt(100) + 1);
        }
        System.out.println("Nesortirovani spisok" + numbers);

        Collections.sort(numbers, Collections.reverseOrder());

//      todo если убрать , Collections.reverseOrder() отсортирует по возрастанию

        System.out.println("Otsortirovani spisok" + numbers);
    }
}
