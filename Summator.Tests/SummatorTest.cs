using NUnit.Framework;
using System;
using System.Linq;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
          {
            int actual   = Summator.Sum(new int[] { 5, 7 });

            Assert.That(actual == 12);
        }


        [Test]
        public void Test_Sum_OneNumber()
        {
            int actual = Summator.Sum(new int[] {5});

            Assert.That(actual == 5);
        }


        [Test]
        public void Test_Sum_PossitiveOneNumber()
        {
            int actual = Summator.Sum(new int[] { 5, 7 });
            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_NegativeNumber()
        {
            int actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            int result = Summator.Sum(new int[] {});

            Assert.That(result == 0);
        }

        //[Test]
        public void Test_Sum_BigValues()
        {
            int actual = Summator.Sum(new int[] { 2000000000, 2000000000 , 2000000000, 2000000000 });
           

            Assert.AreEqual(actual, 6000000000);
        }

        [Test]
       
        public void Test_Assertion()
        {
            var values = new int[] { 5, 7 };
            int expected = 12;
            long actual = Summator.Sum(values);

            Assert.That(expected == actual);
            Assert.That(expected,Is.EqualTo(actual));
            Assert.AreEqual(expected, actual);

            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));

            Assert.That("QA are awesome", Does.Contain("awesome"));

            string date = "7/10/2021";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            Assert.That(() => "abv"[10],
            Throws.TypeOf<IndexOutOfRangeException>());

          
            Assert.That (Enumerable.Range(1, 100), Has.Member(15));
        }

        [Test]
        public void Test_Average()
        {

            {
                int actual = Summator.Average(new int[] { 5, 7 });
                int expected = 6;

                Assert.That(expected == actual);
            }
        }

        [Test]
        public void Test_Average_NegativeNumber()
        {
         int actual = Summator.Average(new int[] { -5, -7 });
         int expected = -6;

        Assert.That(actual == -6);
        }

        [Test]
        public void Test2_Average_NegativeNumber()
        {
            int actual = Summator.Average(new int[] { -5, -7 });
            int expected = -6;

            Assert.That(actual == expected);
        }
    }
    

}