import Less1.Robot1;

public class ProgramRobot {
    public static void main(String[] args) {
        Robot2 robot2 = new Robot2("name_2");
        System.out.println("______________");
        System.out.println(robot2);
        robot2.power();
        robot2.work();
        robot2.powerOff();
        robot2.work();

        robot2.power();
    }
}
