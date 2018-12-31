using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class presets_systems
{

    public static Star_system initialize_solar_system()
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
        mercury.planet_size = Planetoid.Planet_Size.sub_planet;
        mercury.planet_class = Planetoid.Planet_Class.silicate;
        mercury.planet_temperature = Planetoid.Planet_Temperature.scorching;
        mercury.planet_surface = Planetoid.Planet_Surface.barren;
        mercury.planet_atmosphere = Planetoid.Planet_Atmosphere.none;
        mercury.planet_atmos_pressure = Planetoid.Planet_Atmos_Pressure.none;
        mercury.planet_gravity = Planetoid.Planet_Gravity.very_low;
        mercury.sprite_path = "GFX/Space/Planets/Preset/mercury";
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
        venus.planet_size = Planetoid.Planet_Size.planet;
        venus.planet_class = Planetoid.Planet_Class.silicate;
        venus.planet_gravity = Planetoid.Planet_Gravity.average;
        venus.planet_temperature = Planetoid.Planet_Temperature.very_hot;
        venus.planet_surface = Planetoid.Planet_Surface.barren;
        venus.planet_atmosphere = Planetoid.Planet_Atmosphere.carbon_dioxide;
        venus.planet_atmos_pressure = Planetoid.Planet_Atmos_Pressure.extreme;

        venus.planet_features.Add(Planetoid.Planet_Feature.greenhouse_effect);

        venus.sprite_path = "GFX/Space/Planets/Preset/venus";
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
        earth.planet_size = Planetoid.Planet_Size.planet;
        earth.planet_class = Planetoid.Planet_Class.silicate;
        earth.planet_temperature = Planetoid.Planet_Temperature.average;
        earth.planet_gravity = Planetoid.Planet_Gravity.average;
        earth.planet_surface = Planetoid.Planet_Surface.ocean;
        earth.planet_atmosphere = Planetoid.Planet_Atmosphere.nitrogen_oxygen;
        earth.sprite_path = "GFX/Space/Planets/Preset/earth";

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
        mars.planet_size = Planetoid.Planet_Size.planet;
        mars.planet_class = Planetoid.Planet_Class.silicate;
        mars.planet_temperature = Planetoid.Planet_Temperature.cold;
        mars.planet_gravity = Planetoid.Planet_Gravity.low;
        mars.planet_surface = Planetoid.Planet_Surface.barren;
        mars.planet_atmosphere = Planetoid.Planet_Atmosphere.carbon_dioxide;
        mars.sprite_path = "GFX/Space/Planets/Preset/mars";

        mars.orbit = 1.5f;
        mars.radius = 0.53f;
        mars.mass = 0.1f;
        mars.gravity = 0.38f;

        mars.surface_temperature_min = 130; // Kelvin
        mars.surface_temperature_mean = 210; // Kelvin
        mars.surface_temperature_max = 308; // Kelvin
        mars.atmosphere_pressure = 0.65f; //kPa


        Planetoid asteroid_belt = new Planetoid();
        asteroid_belt.name = "Asteroid\nBelt";
        asteroid_belt.planet_size = Planetoid.Planet_Size.normal_belt;
        asteroid_belt.planet_class = Planetoid.Planet_Class.asteroid_belt;
        asteroid_belt.orbit = 3f;

        Planetoid jupiter = new Planetoid();
        jupiter.name = "Jupiter";
        jupiter.planet_size = Planetoid.Planet_Size.giant;
        jupiter.planet_class = Planetoid.Planet_Class.gas_giant;
        jupiter.orbit = 5.2f;
        jupiter.radius = 11.2f;
        jupiter.mass = 317.8f;
        jupiter.gravity = 2.53f;

        jupiter.surface_temperature_min = 110; // Kelvin
        jupiter.surface_temperature_mean = 160; // Kelvin
        jupiter.surface_temperature_max = 180; // Kelvin
        jupiter.atmosphere_pressure = 70f; //kPa

        Planetoid saturn = new Planetoid();
        saturn.name = "Saturn";
        saturn.planet_class = Planetoid.Planet_Class.gas_giant;
        saturn.planet_size = Planetoid.Planet_Size.giant;
        saturn.orbit = 9.5f;
        saturn.radius = 9.45f;
        saturn.mass = 95.2f;
        saturn.gravity = 1.07f;

        saturn.surface_temperature_min = 80; // Kelvin
        saturn.surface_temperature_mean = 130; // Kelvin
        saturn.surface_temperature_max = 150; // Kelvin
        saturn.atmosphere_pressure = 140f; //kPa

        Planetoid uranus = new Planetoid();
        uranus.name = "Uranus";
        uranus.planet_class = Planetoid.Planet_Class.gas_giant;
        uranus.planet_size = Planetoid.Planet_Size.giant;
        uranus.orbit = 19.2f;
        uranus.radius = 4f;
        uranus.mass = 14.5f;
        uranus.gravity = 0.89f;

        uranus.surface_temperature_min = 45; // Kelvin
        uranus.surface_temperature_mean = 75; // Kelvin
        uranus.surface_temperature_max = 90; // Kelvin
        uranus.atmosphere_pressure = 0.65f; //kPa

        Planetoid neptune = new Planetoid();
        neptune.name = "Neptune";
        neptune.planet_class = Planetoid.Planet_Class.gas_giant;
        neptune.planet_size = Planetoid.Planet_Size.giant;
        neptune.orbit = 30f;
        neptune.radius = 3.89f;
        neptune.mass = 17.1f;
        neptune.gravity = 1.14f;

        neptune.surface_temperature_min = 55; // Kelvin
        neptune.surface_temperature_mean = 70; // Kelvin
        neptune.surface_temperature_max = 80; // Kelvin
        neptune.atmosphere_pressure = 0.65f; //kPa

        Planetoid kuiper_belt = new Planetoid();
        kuiper_belt.name = "Kuiper\nBelt";
        kuiper_belt.planet_class = Planetoid.Planet_Class.asteroid_belt;
        kuiper_belt.planet_size = Planetoid.Planet_Size.sparce_belt;
        kuiper_belt.orbit = 40f;

        kuiper_belt.surface_temperature_min = 33; // Kelvin
        kuiper_belt.surface_temperature_mean = 44; // Kelvin
        kuiper_belt.surface_temperature_max = 55; // Kelvin
        kuiper_belt.atmosphere_pressure = 0; //kPa


        solar_system.planets.Add(mercury);
        solar_system.planets.Add(venus);
        solar_system.planets.Add(earth);
        solar_system.planets.Add(mars);
        solar_system.planets.Add(asteroid_belt);
        solar_system.planets.Add(jupiter);
        solar_system.planets.Add(saturn);
        solar_system.planets.Add(uranus);
        solar_system.planets.Add(neptune);
        solar_system.planets.Add(kuiper_belt);

        return solar_system;
    }
}
