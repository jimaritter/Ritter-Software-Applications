using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PerfectPet.Model.Common;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class EnumTests
    {
        [SetUp]
        public void Init()
        {
            
        }

        [Test]
        public void DoFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        [Test]
        public void can_iterate_enum_and_get_attribute()
        {
            try
            {
                var e = EnumerationParser.GetEnumDescriptions(typeof(Salutation));
                foreach (var value in e)
                {
                    Console.WriteLine(value); 
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        [TearDown]
        public void Cleanup()
        {
            
        }
    }
}
