using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PerfectPet.Tests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [SetUp]
        public void Init()
        {
            
        }

        [Test]
        public void fizz_buzz_1()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }            
        }

        [Test]
        public void can_do_fizz_buzz()
        {
            Enumerable.Range(1,100).ToList().ForEach(
                n => Console.WriteLine(
                    (n%3==0) ? (n%5==0) ? "FizzBuzz" : "Fizz" : (n%5==0) ? "Buzz" : n.ToString()
                      ));        }

        [TearDown]
        public void CleanUp()
        {
            
        }
    }
}
