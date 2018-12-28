using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_controller : MonoBehaviour


{
    // Singleton
    public static game_controller _instance;

    // Game starting settings
    public Temperature_scale temperature_scale;
    public Ship.Hull starting_hull = Ship.Hull.explorer;

    Ship player_ship;
    Star_system current_system;

    public enum Temperature_scale { Kelvin, Celsius, Farenheit }

    public GameObject ship_name;
    public GameObject ship_parts;
 
    public GameObject system_name;
    public GameObject system_description;
    public go_star_system system_go;

    #region Starting_Objects
    void initialize_ship()
    {
        player_ship = new Ship(starting_hull);
    }

    void initialize_solar_system()
    {
        Star_system solar_system = new Star_system();
        solar_system.name = "Solar system";

        // Generate star
        Star sun = new Star();
        sun.name = "Sun";
        sun.star_class = Star.Star_Class.G;

        solar_system.stars.Add(sun);

        // Generate planets
        Planetoid mercury = new Planetoid();
        mercury.name = "Mercury";
        mercury.orbit = 0.4f;
        mercury.radius = 0.38f;
        mercury.mass = 0.06f;
        mercury.gravity = 0.38f;

        mercury.surface_temperature_min = 80; // Kelvin
        mercury.surface_temperature_mean = 340; // Kelvin
        mercury.surface_temperature_max = 700; // Kelvin
        mercury.atmosphere_pressure = 0; // kPa

        Planetoid venus = new Planetoid();
        venus.name = "Venus";
        venus.orbit = 0.7f;
        venus.radius = 0.95f;
        venus.mass = 0.8f;
        venus.gravity = 0.9f;

        venus.surface_temperature_min = 720; // Kelvin
        venus.surface_temperature_mean = 740; // Kelvin
        venus.surface_temperature_max = 760; // Kelvin
        venus.atmosphere_pressure = 9200; // kPa

        Planetoid earth = new Planetoid();
        earth.name = "Earth";
        earth.orbit = 1f;
        earth.radius = 1f;
        earth.mass = 1f;
        earth.gravity = 1f;

        earth.surface_temperature_min = 184; // Kelvin
        earth.surface_temperature_mean = 288; // Kelvin
        earth.surface_temperature_max = 330; // Kelvin
        earth.atmosphere_pressure = 101f; // kPa

        Planetoid mars = new Planetoid();
        mars.name = "Mars";
        mars.orbit = 1.5f;
        mars.radius = 0.53f;
        mars.mass = 0.1f;
        mars.gravity = 0.38f;

        mars.surface_temperature_min = 130; // Kelvin
        mars.surface_temperature_mean = 210; // Kelvin
        mars.surface_temperature_max = 308; // Kelvin
        mars.atmosphere_pressure = 0.65f; //kPa

        solar_system.planets.Add(mercury);
        solar_system.planets.Add(venus);
        solar_system.planets.Add(earth);
        solar_system.planets.Add(mars);

        current_system = solar_system;
    }
    #endregion

    #region Debug_interface

    void describe_ship()
    {
        Text ship_name_text = ship_name.GetComponent<Text>();
        Text ship_parts_text = ship_parts.GetComponent<Text>();
        int i = 1;

        ship_name_text.text = "\"" + player_ship.name + "\"";
        ship_parts_text.text = "";

        foreach (Hull_Section hull_section in player_ship.hull_sections)
        {
            ship_parts_text.text += "Hull Section " + i + ":\n";
            foreach (Subsystem subsystem in hull_section.subsystems)
            {
                ship_parts_text.text += "- " + subsystem.name + "\n";

            }
            i++;
        }
    }

    void describe_system()
    {
        Text system_name_text = system_name.GetComponent<Text>();
        Text system_description_text = system_description.GetComponent<Text>();

        system_name_text.text = current_system.name;
        system_description_text.text = current_system.stars[0].description;
    }

    #endregion

    #region Unity_life
    // Start is called before the first frame update
    void Awake()
    {
        if (!_instance)
        {
            _instance = this;
        } else
        {
            Debug.LogError("Duplicate instance of Game Controller spotted!");
            Application.Quit();
        }
    }

    void Start()
    {
        initialize_ship();
        initialize_solar_system();

        describe_ship();
        describe_system();

        system_go.redraw_system_objects(current_system);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    #endregion
}
