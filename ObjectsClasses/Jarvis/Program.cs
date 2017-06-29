using System;
using System.Collections.Generic;
using System.Linq;


namespace Jarvis
{
    class Arm
    {
        public long Energy { get; set; }
        public int ArmDistance { get; set; }
        public int FingerCount { get; set; }

        public void PrintProp()
        {
            Console.WriteLine("#Arm:");
            Console.WriteLine($"###Energy consumption: {Energy}");
            Console.WriteLine($"###Reach: {ArmDistance}");
            Console.WriteLine($"###Fingers: {FingerCount}");
        }
    }

    class Leg
    {
        public long Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        public void PrintProp()
        {
            Console.WriteLine("#Leg:");
            Console.WriteLine($"###Energy consumption: {Energy}");
            Console.WriteLine($"###Strength: {Strength}");
            Console.WriteLine($"###Speed: {Speed}");
        }
    }

    class Torso
    {
        public long Energy { get; set; }
        public double CPUSize { get; set; }
        public string BodyMaterial { get; set; }

        public void PrintProp()
        {
            Console.WriteLine("#Torso:");
            Console.WriteLine($"###Energy consumption: {Energy}");
            Console.WriteLine($"###Processor size: {CPUSize:f1}");
            Console.WriteLine($"###Corpus material: {BodyMaterial}");
        }
    }

    class Head
    {
        public long Energy { get; set; }
        public int Iq { get; set; }
        public string SkinMaterial { get; set; }

        public void PrintProp()
        {
            Console.WriteLine("#Head:");
            Console.WriteLine($"###Energy consumption: {Energy}");
            Console.WriteLine($"###IQ: {Iq}");
            Console.WriteLine($"###Skin material: {SkinMaterial}");
        }
    }

    class Robot
    {
        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }
        public List<Torso> Bodys { get; set; }
        public List<Head> Heads { get; set; }
    }

    class Program
    {
        static void Main()
        {
            long maxEnergy = long.Parse(Console.ReadLine());
            Robot robot = new Robot
            {
                Arms = new List<Arm>(),
                Legs = new List<Leg>(),
                Heads = new List<Head>(),
                Bodys = new List<Torso>()
            };
            AddRobotElements(robot);
            PrintRobotCondition(robot , maxEnergy);
        }

        static void PrintRobotCondition(Robot robot, long maxEnergy)
        {
            if (robot.Arms.Count() < 2 || robot.Legs.Count() < 2 || robot.Heads.Count() < 1 || robot.Bodys.Count() < 1)
            {
                Console.WriteLine("We need more parts!");
                return;
            }

            long sumEnergyComponents = SumComponentsEnergy(robot);
            if (sumEnergyComponents > maxEnergy)
            {
                Console.WriteLine("We need more power!");
                return;
            }

            Console.WriteLine("Jarvis:");
            robot.Heads.ForEach(n => n.PrintProp());
            robot.Bodys.ForEach(n => n.PrintProp());
            robot.Arms.OrderBy(i => i.Energy).ToList().ForEach(n => n.PrintProp());
            robot.Legs.OrderBy(i => i.Energy).ToList().ForEach(n => n.PrintProp());
        }

        static long SumComponentsEnergy(Robot robot)
        {
            return robot.Arms.Sum(i => i.Energy) + robot.Legs.Sum(i => i.Energy) + robot.Bodys.Sum(i => i.Energy) + robot.Heads.Sum(i => i.Energy);
        }

        static void AddRobotElements(Robot robot)
        {
            while (true)
            {
                string[] components = Console.ReadLine().Split(' ').ToArray();
                if (components[0] == "Assemble!")
                {
                    break;
                }
                switch (components[0])
                {
                    case "Leg":
                        AddLegOrArmComponent(robot, components);
                        break;
                    case "Torso":
                        AddHeadOrTorsoComponent(robot, components);
                        break;
                    case "Head":
                        AddHeadOrTorsoComponent(robot, components);
                        break;
                    default:
                        AddLegOrArmComponent(robot, components);
                        break;
                }
            }
        }

        static void AddHeadOrTorsoComponent(Robot robot, string[] components)
        {
            long componentEnergy = long.Parse(components[1]);
            string componentType = components[0];

            int countComponents = componentType == "Head" ? robot.Heads.Count() : robot.Bodys.Count();

            if (countComponents == 1)
            {
                long firstElementEnergy = GetEnergy(robot, componentType, 0, 1);
                if (firstElementEnergy > componentEnergy)
                {
                    RemoveComponent(robot, componentType, 0);
                }
                else
                {
                    return;
                }
            }
            AddComponent(robot, components);
        }

        static void AddLegOrArmComponent(Robot robot, string[] components)
        {
            long componentEnergy = long.Parse(components[1]);
            string componentType = components[0];
            int countComponents = componentType == "Arm" ? robot.Arms.Count() : robot.Legs.Count();

            if (countComponents == 2)
            {
                long firstElementEnergy = GetEnergy(robot, componentType, 0, 1);
                long secondElementEnergy = GetEnergy(robot, componentType, 1, 1);
                if (firstElementEnergy > componentEnergy && secondElementEnergy > componentEnergy)
                {
                    RemoveComponent(robot, componentType, 0);
                }
                else if (secondElementEnergy > componentEnergy)
                {
                    RemoveComponent(robot, componentType, 1);
                }
                else
                {
                    return;
                }
            }
            AddComponent(robot, components);
        }

        static void AddComponent(Robot robot, string[] components)
        {
            switch (components[0])
            {
                case "Leg":
                    Leg leg = new Leg
                    {
                        Energy = long.Parse(components[1]),
                        Strength = int.Parse(components[2]),
                        Speed = int.Parse(components[3])
                    };
                    robot.Legs.Add(leg);

                    break;
                case "Head":
                    Head head = new Head
                    {
                        Energy = long.Parse(components[1]),
                        Iq = int.Parse(components[2]),
                        SkinMaterial = components[3]
                    };
                    robot.Heads.Add(head);

                    break;
                case "Torso":
                    Torso body = new Torso
                    {
                        Energy = long.Parse(components[1]),
                        CPUSize = double.Parse(components[2]),
                        BodyMaterial = components[3]
                    };
                    robot.Bodys.Add(body);

                    break;
                default:
                    Arm arm = new Arm
                    {
                        Energy = long.Parse(components[1]),
                        ArmDistance = int.Parse(components[2]),
                        FingerCount = int.Parse(components[3])
                    };
                    robot.Arms.Add(arm);

                    break;
            }
        }

        static void RemoveComponent(Robot robot, string property, int index)
        {
            switch (property)
            {
                case "Leg":
                    robot.Legs.RemoveAt(index);
                    break;
                case "Head":
                    robot.Heads.RemoveAt(index);
                    break;
                case "Torso":
                    robot.Bodys.RemoveAt(index);
                    break;
                default:
                    robot.Arms.RemoveAt(index);
                    break;
            }
        }

        static long GetEnergy(Robot robot, string componentType, int skipCount, int takeCount)
        {
            switch (componentType)
            {
                case "Leg":
                        return robot.Legs.Skip(skipCount).Take(takeCount).Select(i=>i.Energy).ElementAt(0);
                case "Head":
                        return robot.Heads.Skip(skipCount).Take(takeCount).Select(i => i.Energy).ElementAt(0);
                case "Torso":
                        return robot.Bodys.Skip(skipCount).Take(takeCount).Select(i => i.Energy).ElementAt(0);
                default:
                        return robot.Arms.Skip(skipCount).Take(takeCount).Select(i => i.Energy).ElementAt(0);
            }
        }
    }
}
