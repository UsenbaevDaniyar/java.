package Less1;

public class Robot1 {

    public int level;

    private String name;

    public Robot1(String name, int level)
    {
     this.name = name;
     this.level = level;
    }
    public void  powerOn(){
        this.startBIOS();
        this.startOS();
        this.sayHi();
    }
    public void powerOff(){
        this.sayBue();
        this.stopOS();
        this.stopBIOS();
    }

    public int getLevel(){
        return this.level;
    }
    public String getName(){
        return this.name;
    }
    private void startBIOS() {
        System.out.println("Start BIOS...");
    }
    private void startOS(){
        System.out.println("StartOS...");
    }
    private void sayHi() {
        System.out.println("HelloWorld");
    }
    public void stopBIOS(){
        System.out.println("StopBIOS");
    }
    public void stopOS(){
        System.out.println("StopOS");
    }
    public void sayBue(){
        System.out.println("Bue");
    }
    public void work(){
        System.out.println("Working");
    }
}
