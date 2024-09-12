package Less1;

/**
 * это задание на расчет коордитов вектора
 */

public class Point2D {
    public int x;
    public int y;

    /**
     *
     * @param valueX это координата х
     * @param valueY это координата у
     */

    public Point2D(int valueX, int valueY) {
        x = valueX;
        y = valueY;
    }

    public Point2D(int value) {
        this(value, value);
    }

    public Point2D(){
        this(0);
    }

//    public Point2D(){
//        x = 0;
//        y = 0;
//    }
//    public Point2D(int value){
//        x = value;
//        y = value;
//    }

    public int getX(){
        return x;
    }
    public int getY(){
        return y;
    }

    public void setX(int value) {

        this.x = value;
    }

    public void setY(int value) {

        this.y = value;
    }

    public String getInfo(){
        return String.format("x: %d; y: %d", x, y);
    }

    public String toString(){
        return getInfo();
    }

    public static double distance(Point2D a, Point2D b) {
        return Math.sqrt(Math.pow(a.x - b.x, 2) + Math.pow(a.y - b.y, 2));
    }

    }
