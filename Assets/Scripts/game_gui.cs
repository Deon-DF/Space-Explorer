using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_gui : MonoBehaviour
{

    #region Class_variables
    public GameObject ship_name;
    public GameObject ship_parts;

    public GameObject system_name;
    public GameObject system_description;

    public GameObject go_star;
    public GameObject go_star_name;
    public GameObject go_star_type;

    public GameObject[] go_planets = new GameObject[10];
    public GameObject[] go_planet_names = new GameObject[10];
    public GameObject[] go_planet_stats = new GameObject[10];
    public GameObject[] go_planet_sprites = new GameObject[10];

    public GameObject planet_description;
    public GameObject planet_view_sprite;

    public GameObject system_camera;
    public GameObject planet_camera;

    public static game_gui id;
    #endregion

    #region Draw_main_UI
    public void describe_ship(Ship ship)
    {
        Text ship_name_text = game_gui.id.ship_name.GetComponent<Text>();
        Text ship_parts_text = game_gui.id.ship_parts.GetComponent<Text>();
        int i = 1;

        ship_name_text.text = "\"" + ship.name + "\"";
        ship_parts_text.text = "";

        foreach (Hull_Section hull_section in ship.hull_sections)
        {
            ship_parts_text.text += "Hull Section " + i + ":\n";
            foreach (Subsystem subsystem in hull_section.subsystems)
            {
                ship_parts_text.text += "- " + subsystem.name + "\n";

            }
            i++;
        }
    }
    #endregion

    #region Draw_system_elements

    public void describe_system(Star_system star_system)
    {
        Text system_name_text = system_name.GetComponent<Text>();
        Text system_description_text = system_description.GetComponent<Text>();

        system_name_text.text = star_system.name;
        system_description_text.text = star_system.stars[0].description;
    }

    public string generate_planet_description(Planetoid planet)
    {
        string temp = "";

        if (planet.planet_class == Planetoid.Planet_Class.planet || planet.planet_class == Planetoid.Planet_Class.gas_giant)
        {
            temp += "Orbit: " + planet.orbit + " AU\n";
            temp += "Radius: " + planet.radius + " E\n";
            temp += "Mass: " + planet.mass + " E\n";
            temp += "Gravity: " + planet.gravity + " g\n\n";

            if (game_controller.id.temperature_scale == game_controller.Temperature_scale.Kelvin)
            {
                temp += "T min: " + planet.surface_temperature_min + " K\n";
                temp += "T mean: " + planet.surface_temperature_mean + " K\n";
                temp += "T max: " + planet.surface_temperature_max + " K";
            }
            else if (game_controller.id.temperature_scale == game_controller.Temperature_scale.Celsius)
            {
                temp += "T min: " + (planet.surface_temperature_min - 273) + " C\n";
                temp += "T mean: " + (planet.surface_temperature_mean - 273) + " C\n";
                temp += "T max: " + (planet.surface_temperature_max - 273) + " C";
            }
            else
            {
                temp += "T min: " + (planet.surface_temperature_min * 9 / 5 - 460) + " F\n";
                temp += "T mean: " + (planet.surface_temperature_mean * 9 / 5 - 460) + " F\n";
                temp += "T max: " + (planet.surface_temperature_max * 9 / 5 - 460) + " F";
            }
        }
        else
        {
            temp += "Orbit: " + planet.orbit + " AU\n";
        }

        return temp;
    }


    public void redraw_system_objects(Star_system starsystem)
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
                go_planet_sprites[i].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> (starsystem.planets[i].sprite_path);
                go_planet_stats[i].GetComponent<Text>().text = game_gui.id.generate_planet_description(starsystem.planets[i]);
            }
            else
            {
                go_planets[i].SetActive(false);
                go_planet_names[i].GetComponent<Text>().text = "";
                go_planet_stats[i].GetComponent<Text>().text = "";
            }
        }

    }
    #endregion

    #region Buttons
    public void switch_to_planet_view(int position)
    {
        game_controller.id.current_planet = game_controller.id.current_system.planets[position - 1];
        Debug.Log(game_controller.id.current_planet.name);

        

        planet_description.GetComponent<Text>().text = game_controller.id.current_planet.name + ":\n\n\n" + generate_planet_description(game_controller.id.current_planet);
        planet_view_sprite.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> (game_controller.id.current_planet.sprite_path);

        system_camera.SetActive(false);
        planet_camera.SetActive(true);


    }

    public void switch_to_system_view()
    {
        planet_camera.SetActive(false);
        system_camera.SetActive(true);
    }

    #endregion

    #region Unity_Life
    void Awake()
    {
        if (!id)
        {
            id = this;
        }
        else
        {
            Debug.LogError("Duplicate instance of Game GUI spotted!");
            Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
