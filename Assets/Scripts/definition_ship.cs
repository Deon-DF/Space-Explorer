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
                scout_hull_section1.subsystems[0] = new Subsystem (Subsystem.Type.bridge);
                scout_hull_section1.subsystems[1] = new Subsystem (Subsystem.Type.life_support);;
                scout_hull_section1.subsystems[2] = new Subsystem (Subsystem.Type.living_space);;
                scout_hull_section1.subsystems[3] = new Subsystem (Subsystem.Type.reactor);;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(scout_hull_section1);
                break;

            case Hull.courier:
                name = "Courier";
                Hull_Section courier_hull_section1 = new Hull_Section();
                Hull_Section courier_hull_section2 = new Hull_Section();
                courier_hull_section1.subsystems[0] = new Subsystem (Subsystem.Type.bridge);;
                courier_hull_section1.subsystems[1] = new Subsystem (Subsystem.Type.life_support);;
                courier_hull_section1.subsystems[2] = new Subsystem (Subsystem.Type.living_space);;
                courier_hull_section1.subsystems[3] = new Subsystem (Subsystem.Type.reactor);;
                courier_hull_section2.subsystems[0] = new Subsystem (Subsystem.Type.storage);;
                courier_hull_section2.subsystems[1] = new Subsystem (Subsystem.Type.storage);;
                courier_hull_section2.subsystems[2] = new Subsystem (Subsystem.Type.storage);;
                courier_hull_section2.subsystems[3] = new Subsystem (Subsystem.Type.storage);;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(courier_hull_section1);
                hull_sections.Add(courier_hull_section2);
                break;

            case Hull.fighter:
                name = "Fighter";
                Hull_Section fighter_hull_section1 = new Hull_Section();
                fighter_hull_section1.subsystems[0] = new Subsystem (Subsystem.Type.bridge);;
                fighter_hull_section1.subsystems[1] = new Subsystem (Subsystem.Type.life_support);;
                fighter_hull_section1.subsystems[2] = new Subsystem (Subsystem.Type.living_space);;
                fighter_hull_section1.subsystems[3] = new Subsystem (Subsystem.Type.reactor);;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(fighter_hull_section1);
                break;

            case Hull.explorer:
                name = "Explorer";
                Hull_Section explorer_hull_section1 = new Hull_Section();
                Hull_Section explorer_hull_section2 = new Hull_Section();
                explorer_hull_section1.subsystems[0] = new Subsystem (Subsystem.Type.bridge);;
                explorer_hull_section1.subsystems[1] = new Subsystem (Subsystem.Type.life_support);;
                explorer_hull_section1.subsystems[2] = new Subsystem (Subsystem.Type.living_space);;
                explorer_hull_section1.subsystems[3] = new Subsystem (Subsystem.Type.living_space);;
                explorer_hull_section2.subsystems[0] = new Subsystem (Subsystem.Type.reactor);;
                explorer_hull_section2.subsystems[1] = new Subsystem(Subsystem.Type.lab);
                explorer_hull_section2.subsystems[2] = new Subsystem (Subsystem.Type.storage);;
                explorer_hull_section2.subsystems[3] = new Subsystem (Subsystem.Type.storage);;

                hull_sections = new List<Hull_Section>();
                hull_sections.Add(explorer_hull_section1);
                hull_sections.Add(explorer_hull_section2);
                break;

            default:
                break;

        }
    }
}


public class Subsystem
{
    public string name = "Empty subsystem";
    public string description = "";
    public enum Type { bridge, lab, life_support, living_space, reactor, storage }
    public Type type = Type.storage;

    public Subsystem (Subsystem.Type type)
    {
        switch (type)
        {
            case Type.bridge:
                name = "Bridge";
                type = Type.bridge;
                break;

            case Type.lab:
                name = "Lab";
                type = Type.lab;
                break;

            case Type.life_support:
                name = "Life support";
                type = Type.life_support;
                break;

            case Type.living_space:
                name = "Living space";
                type = Type.living_space;
                break;

            case Type.reactor:
                name = "Reactor";
                type = Type.reactor;
                break;

            case Type.storage:
                name = "Storage [----]";
                type = Type.storage;
                break;

            default:
                name = "Storage [----]";
                type = Type.storage;
                break;
        }
    }
}

public class Hull_Section
{
    public Subsystem[] subsystems = new Subsystem[4];
}
