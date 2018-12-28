using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class go_star_system : MonoBehaviour
{

    public GameObject go_star;
    public GameObject go_star_name;
    public GameObject go_star_type;

    public GameObject[] go_planets = new GameObject[10];
    public GameObject[] go_planet_names = new GameObject[10];
    public GameObject[] go_planet_stats = new GameObject[10];


    GameObject[] planets = new GameObject[10];

    public void redraw_system_objects (Star_system starsystem)
    {
        go_star_name.GetComponent<Text>().text = starsystem.stars[0].name;

        go_star_type.GetComponent<Text>().text = starsystem.stars[0].star_class.ToString() + " Type";

        int planet_count = starsystem.planets.Count;

        for (int i = 0; i <= 9; i++)
        {
            if (i < planet_count)
            {
                go_planets[i].SetActive(true);
                go_planet_names[i].GetComponent<Text>().text = starsystem.planets[i].name;
                go_planet_stats[i].GetComponent<Text>().text = get_planet_stats_text(starsystem.planets[i]);
            }
            else
            {
                go_planets[i].SetActive(false);
                go_planet_names[i].GetComponent<Text>().text = "";
                go_planet_stats[i].GetComponent<Text>().text = "";
            }
        }

    }

    string get_planet_stats_text (Planetoid planet)
    {
        string temp = "";

        if (planet.planet_class == Planetoid.Planet_Class.planet)
        {
            temp += "Orbit: " + planet.orbit + " AU\n";
            temp += "Radius: " + planet.radius + " E\n";
            temp += "Mass: " + planet.mass + " E\n";
            temp += "Gravity: " + planet.gravity + " g\n\n";

            if (game_controller._instance.temperature_scale == game_controller.Temperature_scale.Kelvin)
            {
                temp += "T min: " + planet.surface_temperature_min + " K\n";
                temp += "T mean: " + planet.surface_temperature_mean + " K\n";
                temp += "T max: " + planet.surface_temperature_max + " K";
            } else if (game_controller._instance.temperature_scale == game_controller.Temperature_scale.Celsius)
            {
                temp += "T min: " + (planet.surface_temperature_min - 273) + " C\n";
                temp += "T mean: " + (planet.surface_temperature_mean - 273) + " C\n";
                temp += "T max: " + (planet.surface_temperature_max - 273) + " C";
            } else
            {
                temp += "T min: " + (planet.surface_temperature_min * 9 / 5 - 460) + " F\n";
                temp += "T mean: " + (planet.surface_temperature_mean * 9 / 5 - 460) + " F\n";
                temp += "T max: " + (planet.surface_temperature_max *9 / 5 - 460) + " F";
            }
        }
        return temp;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
