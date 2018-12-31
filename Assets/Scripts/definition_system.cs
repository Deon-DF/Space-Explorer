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
    public enum Planet_Class { planet, gas_giant, asteroid_belt }
    public Planet_Class planet_class = Planet_Class.planet;
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

    public enum Atmosphere { none, carbon_dioxide, hydrogen, helium, nitrogen, nitrogen_oxygen, methane, sulfur_dioxide }
    public Atmosphere atmosphere = Atmosphere.none;

}