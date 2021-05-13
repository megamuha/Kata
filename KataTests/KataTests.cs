using NUnit.Framework;
using System;

namespace Kata
{
    public class Tests
    {

        [Test]
        public void Case1_CalculeteNull()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add(), 0);
        }

        [Test]
        public void Case2_CalculeteOneNumber()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add("1"), 1);
        }

        [Test]
        public void Case3_CalculeteTwoNumber()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add("1,2"), 3);
        }

        [Test]
        public void Case4_CalculeteManyNumber()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add("41,1,10,5"), 57);
        }

        [Test]
        public void Case5_CalculeteNumbersWithSymbols()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add("//,hb.12f,fs4"), 16);
        }

        [Test]
        public void Case6_CalculeteNumbersWithAnotherSymbols()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add(";hb.1;2f,fs4"), 7);
        }

        [Test]
         public void Case7_CalculeteNegativeNumber()
         {
             try
             {
                 Calculator calc = new Calculator();

                 calc.Add("2,23,-5");

                Assert.Fail();
             }
             catch(NegativeNumberException e) 
             {
                Assert.AreEqual(e.Numbers, "-5");
             }
            catch (Exception)
            {
                Assert.Fail();
            }
         }
      
        [Test]
        public void Case8_CalculeteManyNegativeNumber()
        {
            try
            {
                Calculator calc = new Calculator();

                calc.Add("2,23,-10,-3,23,-1");

                Assert.Fail();
            }
            catch (NegativeNumberException e)
            {
                Assert.AreEqual(e.Numbers, "-10,-3,-1");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Case9_NumebrBigger1000()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add("10,5,1001"), 15);
        }

        [Test]
        public void Casee10_AnyLengthOfDelimeters()
        {
            Calculator calc = new Calculator();

            Assert.AreEqual(calc.Add("10,,1;;;3"), 14);
        }
    }
}