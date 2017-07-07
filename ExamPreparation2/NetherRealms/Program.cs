using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class Program
    {
        static void Main()
        {
            string[] dragonNames = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).OrderBy(s => s).ToArray();

            foreach (var dragon in dragonNames)
            {
                var dragonHealth = Regex.Matches(dragon, @"[^\d\+\-=*\/\.]").Cast<Match>().Select(m => (int)char.Parse(m.Value)).Sum(m => m);
                double dragonRawDamage = Regex.Matches(dragon, "[-]?[0-9]+(?:[.][0-9]+)?").Cast<Match>().Select(m => double.Parse(m.Value)).Sum();
                string[] extraDamage = Regex.Matches(dragon, "[*\\/]").Cast<Match>().Select(m => m.Value).ToArray();
                double dragonDamage = ModifyDamage(extraDamage, dragonRawDamage);
                Console.WriteLine($"{dragon} - {dragonHealth} health, {dragonDamage:f2} damage");
            }
        }

        public static double ModifyDamage(string[] extraDamage, double dragonRawDamage)
        {
            foreach (var modifier in extraDamage)
            {
                dragonRawDamage = modifier == "*" ? dragonRawDamage * 2 : dragonRawDamage / 2;
            }
            return dragonRawDamage;
        }
    }
}
