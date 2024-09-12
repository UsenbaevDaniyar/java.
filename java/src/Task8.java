import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Task8 {
    public static void main(String[] args) {
        String[] planets = {"Mercury", "Venera", "Earth", "Mars", "Uran", "Neptune", "Pluto", "Jupiter", "Saturn"};

        List<String> planetList = new ArrayList<>();
        Random random = new Random();

        for (int i = 0; i < 20; i++) {
            int index = random.nextInt(planets.length);
            planetList.add(planets[index]);
        }

        System.out.println("listPlanet(Planets List): " + planetList);


        List<String> uniquePlanets = new ArrayList<>();
        List<Integer> counts = new ArrayList<>();

        for (String planet : planetList){
            int index = uniquePlanets.indexOf(planet);
            if (index == -1) {
                uniquePlanets.add(planet);
                counts.add(1);
            } else {
                counts.set(index, counts.get(index) + 1);
            }
        }
        System.out.println("kol-vo povtoreni planet" + uniquePlanets);
        for (int i = 0; i < uniquePlanets.size(); i++) {
            System.out.println(uniquePlanets.get(i) + ":" + counts.get(i));
        }
    }



}
