using System.Collections;
using System.Collections.Generic;

public class Star_system
{
    public string name;
    public float coordinate_x = 0f;
    public float coordinate_y = 0f;
    public List<Star> stars = new List<Star>();
    public List<Planetoid> planets = new List<Planetoid>();
}

public class Star
{
    public string name;
    public enum Star_Class { O, B, A, F, G, K, M }
    public Star_Class star_class = Star_Class.M;

    public string description
    {
        get
        {
            switch (star_class)
            {
                case Star_Class.O:
                    return "O-type stars are extremely luminous and extremely hot blue stars.";
                case Star_Class.B:
                    return "B-type stars are very luminous and hot blue stars.";
                case Star_Class.A:
                    return "A-type stars are host bluish-white or white stars.";
                case Star_Class.F:
                    return "F-type stars white bright stars.";
                case Star_Class.G:
                    return "G-type stars are yellow stars with mediocre surface temperature.";
                case Star_Class.K:
                    return "K-type stars are orange stars.";
                case Star_Class.M:
                    return "Class M stars are red in color and less hot than other star types.";
                default:
                    return "";
            }
        }
    }
}

public class Planetoid
{
    public string name;
    public enum Planet_Class { chtonian, silicate, ice, gas_giant, asteroid_belt }
    public enum Planet_Size { mesoplanet, sub_planet, planet, super_planet, mini_giant, giant, super_giant, dense_belt, sparce_belt, normal_belt }
    public enum Planet_Surface { barren, lava, ice, ocean }
    public enum Planet_Atmosphere { none, carbon_dioxide, hydrogen, helium, nitrogen, nitrogen_oxygen, methane, sulfur_dioxide }
    public enum Planet_Atmos_Pressure { none, minimal, low, average, high, extreme }
    public enum Planet_Temperature { frozen = 0, very_cold = 1, cold = 2, average = 3, hot = 4, very_hot = 5, scorching = 6 }
    public enum Planet_Gravity { none, very_low, low, average, high, very_high, enormous }

    public Planet_Size planet_size = Planet_Size.mesoplanet;
    public Planet_Class planet_class = Planet_Class.silicate;
    public Planet_Gravity planet_gravity = Planet_Gravity.very_low;
    public Planet_Surface planet_surface = Planet_Surface.barren;
    public Planet_Atmosphere planet_atmosphere = Planet_Atmosphere.none;
    public Planet_Atmos_Pressure planet_atmos_pressure = Planet_Atmos_Pressure.none;


    public enum Planet_Feature { greenhouse_effect, dust_storms }

    public List<Planet_Feature> planet_features = new List <Planet_Feature>();

    // These values will be modified by planet climate features
    Planet_Temperature planet_temp = Planet_Temperature.frozen;

    public Planet_Temperature planet_temperature {
        get
        {
            if (planet_features.Contains(Planet_Feature.greenhouse_effect))
            {
                if ( (int)planet_temp < 6)
                {

                }
                return planet_temp + 1;
            } else return planet_temp;
        }
        set
        {
            planet_temp = value;

        }
    }


    public int discovery_level = 0;
    public string sprite_path;

    public float orbit = 1f;
    public float surface_temperature_min = 184;
    public float surface_temperature_mean = 288;
    public float surface_temperature_max = 330;
    public float atmosphere_pressure = 101f;
    public float radius = 1f;
    public float mass = 1f;
    public float gravity = 1f;



}