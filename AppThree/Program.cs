using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;

namespace AppThree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User1> data = new List<User1>();
            Validation validObj = new Validation(args);

            if (args[0].Equals("en_US"))
            {
                for (int i = 0; i < validObj.rowCount; i++)
                {
                    var fU = new Faker<User1>("en")
                            .RuleFor(u => u.Name, f => f.Name.FullName())
                            .RuleFor(u => u.PostAddress, f => f.Address.ZipCode())
                            .RuleFor(u => u.Country, "USA")
                            .RuleFor(u => u.City, f => f.Address.City())
                            .RuleFor(u => u.Street, f => f.Address.StreetAddress())
                            .RuleFor(u => u.Flat, f => f.Address.SecondaryAddress())
                            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber());
                    data.Add(fU);
                }
                for (int i = 0; i < data.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{data[i].Name}; {data[i].PostAddress}; {data[i].Country}; {data[i].City} {data[i].Street}; {data[i].Flat}; {data[i].PhoneNumber}");
                }
            }
            else
            {
                if (args[0].Equals("ru_RU"))
                {
                    for (int i = 0; i < validObj.rowCount; i++)
                    {
                        var fU = new Faker<User1>("ru")
                                .RuleFor(u => u.Name, f => f.Name.FullName())
                                .RuleFor(u => u.PostAddress, f => f.Address.ZipCode())
                                .RuleFor(u => u.Country, "Россия")
                                .RuleFor(u => u.City, f => f.Address.City())
                                .RuleFor(u => u.Street, f => f.Address.StreetAddress())
                                .RuleFor(u => u.Flat, f => f.Address.SecondaryAddress())
                                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber());
                        data.Add(fU);
                    }
                    for (int i = 0; i < data.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{data[i].Name}; {data[i].PostAddress}; {data[i].Country}; {data[i].City} {data[i].Street}; {data[i].Flat}; {data[i].PhoneNumber}");
                    }
                } 
            }
        }
    }
}