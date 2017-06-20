using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingValidation
{
    class Parking
    {
        static void Main()
        {

            int cycles = int.Parse(Console.ReadLine());
            Dictionary<string, string> registerPlates = new Dictionary<string, string>();


            for(int i=0; i<cycles; i++)
            {
                string[] plateInput = Console.ReadLine().Split(' ').ToArray();

                var command = plateInput[0];
                if (command == "register")
                {
                    Console.WriteLine(PrintRegisterResult(plateInput, registerPlates));
                }
                else if (command == "unregister")
                {
                    Console.WriteLine(PrintUnRegisterResult(plateInput, registerPlates));
                }
            }

            Console.Write(string.Join("", registerPlates.Select(s=>s.Key + " => " + s.Value + Environment.NewLine)));
        }

        public static string PrintUnRegisterResult(string[] plateInput, Dictionary<string, string> registerPlates)
        {
            var output = string.Empty;
            var userName = plateInput[1];

            if (!registerPlates.ContainsKey(userName))
            {
                output = $"ERROR: user {userName} not found";
            }
            else
            {
                registerPlates.Remove(userName);
                output = $"user {userName} unregistered successfully";
            }

            return output;
        }

        public static string PrintRegisterResult(string[] plateInput, Dictionary<string, string> registerPlates)
        {
            var output = string.Empty;

            var userName = plateInput[1];
            var licensePlateNumber = plateInput[2];

            if (registerPlates.ContainsKey(userName))
            {
                output = $"ERROR: already registered with plate number {registerPlates[userName]}";
            }
            else if (!isPlateValid(licensePlateNumber))
            {
                output = $"ERROR: invalid license plate {licensePlateNumber}";
            }
            else if (registerPlates.ContainsValue(licensePlateNumber))
            {
                output = $"ERROR: license plate {licensePlateNumber} is busy";
            }
            else
            {
                registerPlates[userName] = licensePlateNumber;
                output = $"{userName} registered {licensePlateNumber} successfully";
            }

            return output;
        }

        public static bool isPlateValid(string plate)
        {
            bool isfirstTwoUpper = plate.Take(2).All(ch => ch >= 'A' && ch <= 'Z');
            bool isMiddleNumber = plate.Skip(2).Take(4).All(ch => char.IsDigit(ch));
            bool isLastTwoUpper = plate.Skip(6).Take(2).All(char.IsUpper);

            if (!isfirstTwoUpper || !isMiddleNumber || !isLastTwoUpper || plate.Length !=8)
            {
               return false;
            }

            return true;
        }
    }
}
