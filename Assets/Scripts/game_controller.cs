using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_controller : MonoBehaviour
{
    Ship player_ship;
    Star_system current_system;

    public GameObject ship_name;
    public GameObject ship_parts;
 
    public GameObject system_name;
    public GameObject system_description;

    #region Starting_Objects
    void initialize_ship()
    {
        player_ship = new Ship(Ship.Hull.explorer);
    }

    void initialize_system()
    {
        Star_system solar_system = new Star_system();
        solar_system.name = "Solar system";

        Star sun = new Star();
        sun.name = "Sun";
        sun.star_class = Star.Star_Class.G;

        solar_system.stars.Add(sun);

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
    void Start()
    {
        initialize_ship();
        initialize_system();

        describe_ship();
        describe_system();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    #endregion
}
