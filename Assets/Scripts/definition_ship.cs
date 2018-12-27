using System.Collections;
using System.Collections.Generic;

public class Ship
{
    public List<Hull_Section> hull_sections;

    public enum Hull { scout, courier, fighter, explorer }
    public string name;

    public Ship (Hull hull)
    {
        switch (hull)
        {
            case Hull.scout:
                name = "Scout";
                Hull_Section scout_hull_section1 = new Hull_Section();
                scout_hull_section1.subsystems[0] = Hull_Section.Subsystem.bridge;
                scout_hull_section1.subsystems[1] = Hull_Section.Subsystem.life_support;
                scout_hull_section1.subsystems[2] = Hull_Section.Subsystem.living_space;
                scout_hull_section1.subsystems[3] = Hull_Section.Subsystem.reactor;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(scout_hull_section1);
                break;

            case Hull.courier:
                name = "Courier";
                Hull_Section courier_hull_section1 = new Hull_Section();
                Hull_Section courier_hull_section2 = new Hull_Section();
                courier_hull_section1.subsystems[0] = Hull_Section.Subsystem.bridge;
                courier_hull_section1.subsystems[1] = Hull_Section.Subsystem.life_support;
                courier_hull_section1.subsystems[2] = Hull_Section.Subsystem.living_space;
                courier_hull_section1.subsystems[3] = Hull_Section.Subsystem.reactor;
                courier_hull_section2.subsystems[0] = Hull_Section.Subsystem.storage;
                courier_hull_section2.subsystems[1] = Hull_Section.Subsystem.storage;
                courier_hull_section2.subsystems[2] = Hull_Section.Subsystem.storage;
                courier_hull_section2.subsystems[3] = Hull_Section.Subsystem.storage;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(courier_hull_section1);
                hull_sections.Add(courier_hull_section2);
                break;

            case Hull.fighter:
                name = "Fighter";
                Hull_Section fighter_hull_section1 = new Hull_Section();
                fighter_hull_section1.subsystems[0] = Hull_Section.Subsystem.bridge;
                fighter_hull_section1.subsystems[1] = Hull_Section.Subsystem.life_support;
                fighter_hull_section1.subsystems[2] = Hull_Section.Subsystem.living_space;
                fighter_hull_section1.subsystems[3] = Hull_Section.Subsystem.reactor;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(fighter_hull_section1);
                break;

            case Hull.explorer:
                name = "Explorer";
                Hull_Section explorer_hull_section1 = new Hull_Section();
                Hull_Section explorer_hull_section2 = new Hull_Section();
                explorer_hull_section1.subsystems[0] = Hull_Section.Subsystem.bridge;
                explorer_hull_section1.subsystems[1] = Hull_Section.Subsystem.life_support;
                explorer_hull_section1.subsystems[2] = Hull_Section.Subsystem.living_space;
                explorer_hull_section1.subsystems[3] = Hull_Section.Subsystem.living_space;
                explorer_hull_section2.subsystems[0] = Hull_Section.Subsystem.reactor;
                explorer_hull_section2.subsystems[1] = Hull_Section.Subsystem.lab;
                explorer_hull_section2.subsystems[2] = Hull_Section.Subsystem.storage;
                explorer_hull_section2.subsystems[3] = Hull_Section.Subsystem.storage;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(explorer_hull_section1);
                hull_sections.Add(explorer_hull_section2);
                break;

            default:
                break;

        }
    }
}


public class Hull_Section
{
    public enum Subsystem { bridge, lab, life_support, living_space, reactor, storage }
    public Subsystem[] subsystems = new Subsystem[4];
}