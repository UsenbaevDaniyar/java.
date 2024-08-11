package Less1;

import java.io.FileWriter;
import java.io.IOException;

public class Task4 {
    private static FileWriter fw;

    public static void main(String[] args) {

        writeToFile("Task4.txt", "hello danik");

    }

    public static void writeToFile(String path, String content) {

        try {
            fw = new FileWriter(path);
            fw.write(content);
            fw.flush();

        } catch (IOException e) {
            throw new RuntimeException(e);
        } finally {
            try {
                fw.close();
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
