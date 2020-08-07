using System;
using System.Collections.Generic;
using System.Text;

namespace AppThree
{
    class Validation
    {
        public int rowCount = 0;
        public double errRate = 0;
        public Validation(string[] args)
        {
            if (args.Length < 4 && args.Length > 1)
            {
                if (!args[0].Equals("en_US") && !args[0].Equals("ru_RU") && !args[0].Equals("be_BY"))
                {
                    Console.WriteLine("Bad location");
                    Environment.Exit(0);
                }
                else
                {
                    if (!uint.TryParse(args[1], out uint parsedValue))
                    {
                        Console.WriteLine("Bad input");
                        Environment.Exit(0);
                    }
                    else
                    {
                        rowCount = Convert.ToInt32(args[1]);
                        if (args.Length == 3)
                        {
                            if (!Double.TryParse(args[2], out Double parsedValue1) || (parsedValue1 < 0))
                            {
                                Console.WriteLine("Bad input");
                                Environment.Exit(0);
                            }
                            else
                            {
                                errRate = Convert.ToDouble(args[2]);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect args count");
                Environment.Exit(0);
            }
        }
    }
}
