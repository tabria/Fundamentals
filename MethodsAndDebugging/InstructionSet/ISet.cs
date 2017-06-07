using System;

namespace InstructionSet
{
    class ISet
    {
        static void Main()
        {


            string operationType = Console.ReadLine();

            while (operationType != "END")
            {
        
                string[] operationArgs = operationType.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                long result = 0;

                switch (operationArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(operationArgs[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(operationArgs[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(operationArgs[1]);
                            long operandTwo = long.Parse(operationArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(operationArgs[1]);
                            long operandTwo = long.Parse(operationArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                    default: break;
                }
                Console.WriteLine(result);

                operationType = Console.ReadLine();
            }
        }
    }
}
