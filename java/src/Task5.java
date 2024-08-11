import java.io.FileWriter;
import java.io.IOException;

import static Less1.Task4.writeToFile;

public class Task5 {

    public static void main(String[] args) {

        writeToFile("Task5.txt", "hello Aiym");

    }

    public static void writeToFile(String path, String content) {

        try (FileWriter fw = new FileWriter(path);) {
            fw.write(content);
            fw.flush();

        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
}


