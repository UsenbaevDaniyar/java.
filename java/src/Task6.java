import java.io.*;

public class Task6 {
    public static void main(String[] args) {
        
        writeToFile("Task5.txt", "hello Aim\nDanik");
        readFile("Task5.txt");
    }

    private static void writeToFile(String path, String content) {
        try(FileWriter fw = new FileWriter(path);) {
            fw.write(content);
            fw.flush();

        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    private static String readFile(String path) {

        String line;

        try(BufferedReader br = new BufferedReader(new FileReader(path))) {

            while ((line = br.readLine()) != null) {

                System.out.println(line);
            }

        } catch (IOException e) {
            throw new RuntimeException(e);
        }

        return line;

    }
}
