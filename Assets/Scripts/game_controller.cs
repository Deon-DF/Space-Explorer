using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_controller : MonoBehaviour
{
    Ship player_ship;

    public GameObject ship_description;

    void describe_ship()
    {
        Text shiptext = ship_description.GetComponent<Text>();
        int i = 1;

        shiptext.text = "\"" + player_ship.name + "\"\n";

        foreach (Hull_Section hull_section in player_ship.hull_sections)
        {
            shiptext.text += "Hull Section " + i +":\n";
            foreach (Hull_Section.Subsystem subsystem in hull_section.subsystems)
            {
                shiptext.text += "- " + subsystem + "\n";

            }
            i++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player_ship = new Ship(Ship.Hull.explorer);
        describe_ship();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
