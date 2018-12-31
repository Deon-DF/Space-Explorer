using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_controller : MonoBehaviour{

    #region Class_variables
    // Singleton
    public static game_controller id;


    public Ship player_ship;
    public Star_system current_system;
    public Planetoid current_planet;

    public enum Temperature_scale { Kelvin, Celsius, Farenheit }

    #endregion

    #region global settings
    // Game starting settings
    public Temperature_scale temperature_scale = Temperature_scale.Celsius;
    public Ship.Hull starting_hull = Ship.Hull.explorer;
    #endregion

    #region Unity_life

    void Awake()
    {
        if (!id)
        {
            id = this;
        } else
        {
            Debug.LogError("Duplicate instance of Game Controller spotted!");
            Application.Quit();
        }
    }

    void Start()
    {
        player_ship = new Ship(starting_hull);
        current_system = presets_systems.initialize_solar_system();

        game_gui.id.describe_ship(player_ship);
        game_gui.id.describe_system(current_system);
        game_gui.id.redraw_system_objects(current_system);
    }
    
    void Update()
    {

        
    }
    #endregion
}
