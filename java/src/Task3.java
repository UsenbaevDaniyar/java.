import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.Scanner;

public class Task3 {
    public static void main(String[] args) {

        System.out.println("Enter your name: ");
//        String name = new Scanner(System.in);
        Scanner sc = new Scanner(System.in);
        String name = sc.nextLine();

//        System.out.println("Your name =" + name);

        LocalDateTime now = LocalDateTime.now();

        if (now.isBefore(LocalDateTime.of(LocalDate.now(), LocalTime.of(18, 0)))) {
            System.out.println("Good day, " + name);
        }
//        else if (now.isAfter(LocalDateTime.of(LocalDate.now(), LocalTime.of(18, 0)))) {
//            System.out.println("Good evening " + name);
//        }
        else {
            System.out.println("Good evening " + name);
        }
    }
}
