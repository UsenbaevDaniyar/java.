import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Task2{

    static final Logger LOGGER = Log.getLogger(Task2.class.getName());

    public static void main(String[] args) {

        writeToFile("lesson2.txt", "D:\\Git Lern\\Лекция ЗЯП1");

    }

    public static List<String> readDir(String path) {

        File folder = new File(path);

        if (!folder.isDirectory()) {
            throw new RuntimeException("File is not directory");
        }

        File[] files = folder.listFiles();
        List<String> result = new ArrayList<>();

        for (File file : files) {

            String name = file.getName();
            result.add(name);
            if (isThrow()) {
                LOGGER.log(Level.INFO, "Error reading directory: " + folder.getAbsolutePath());
            }

        }

        return result;
    }
        public static void writeToFile(String pathIn, String pathOut) {
        List<String> list = readDir(pathOut);

        try(FileWriter fw = new FileWriter(pathIn)) {
            for(String s : list) {
                fw.write(s + "\n");
                fw.flush();
                if (isThrow()) {
                    LOGGER.log(Level.INFO, "Error writing directory: " +s);
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

        }

        private static boolean isThrow() {
        int a = 0;
        int b = 2;
        int digit = a + (int) (Math.random() * b);
            System.out.println(digit);
            return digit > 0;
        }

}




