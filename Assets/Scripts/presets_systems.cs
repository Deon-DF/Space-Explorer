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
        mercury.planet_class = Planetoid.Planet_Class.planet;
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
        venus.planet_class = Planetoid.Planet_Class.planet;
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
        earth.planet_class = Planetoid.Planet_Class.planet;
        earth.orbit = 1f;
        earth.radius = 1f;
        earth.mass = 1f;
        earth.gravity = 1f;
        earth.sprite_path = "GFX/Space/Planets/Preset/earth";

        earth.surface_temperature_min = 184; // Kelvin
        earth.surface_temperature_mean = 288; // Kelvin
        earth.surface_temperature_max = 330; // Kelvin
        earth.atmosphere_pressure = 101f; // kPa

        Planetoid mars = new Planetoid();
        mars.name = "Mars";
        mars.planet_class = Planetoid.Planet_Class.planet;
        mars.orbit = 1.5f;
        mars.radius = 0.53f;
        mars.mass = 0.1f;
        mars.gravity = 0.38f;
        mars.sprite_path = "GFX/Space/Planets/Preset/mars";

        mars.surface_temperature_min = 130; // Kelvin
        mars.surface_temperature_mean = 210; // Kelvin
        mars.surface_temperature_max = 308; // Kelvin
        mars.atmosphere_pressure = 0.65f; //kPa


        Planetoid asteroid_belt = new Planetoid();
        asteroid_belt.name = "Asteroid\nBelt";
        asteroid_belt.planet_class = Planetoid.Planet_Class.asteroid_belt;
        asteroid_belt.orbit = 3f;

        Planetoid jupiter = new Planetoid();
        jupiter.name = "Jupiter";
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
        neptune.orbit = 30f;
        neptune.radius = 3.89f;
        neptune.mass = 17.1f;
        neptune.gravity = 1.14f;

        neptune.surface_temperature_min = 55; // Kelvin
        neptune.surface_temperature_mean = 70; // Kelvin
        neptune.surface_temperature_max = 80; // Kelvin
        neptune.atmosphere_pressure = 0.65f; //kPa

        Planetoid pluto = new Planetoid();
        pluto.name = "Pluto";
        pluto.planet_class = Planetoid.Planet_Class.planet;
        pluto.orbit = 40f;
        pluto.radius = 0.19f;
        pluto.mass = 0.002f;
        pluto.gravity = 2.53f;

        pluto.surface_temperature_min = 33; // Kelvin
        pluto.surface_temperature_mean = 44; // Kelvin
        pluto.surface_temperature_max = 55; // Kelvin
        pluto.atmosphere_pressure = 0; //kPa


        solar_system.planets.Add(mercury);
        solar_system.planets.Add(venus);
        solar_system.planets.Add(earth);
        solar_system.planets.Add(mars);
        solar_system.planets.Add(asteroid_belt);
        solar_system.planets.Add(jupiter);
        solar_system.planets.Add(saturn);
        solar_system.planets.Add(uranus);
        solar_system.planets.Add(neptune);
        solar_system.planets.Add(pluto);

        return solar_system;
    }
}
