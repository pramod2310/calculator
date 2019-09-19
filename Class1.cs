using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace AwesomeCalculatorTest
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input7point0and8point0_Returns15point0()
            {//Arrange
                double number1 = 7.0;
                double number2 = 8.0;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input6point0and6point0_Returns12point0()
            
                {//Arrange
                    double number1 = 6.0;
                    double number2 = 6.0;
                    double expectedResult = number1 + number2;
                    Calc testCalc = new Calc(number1, number2);
                    //Act 
                    double actualResult = testCalc.GetAddition();
                    //Assert 
                    Assert.AreEqual(expectedResult, actualResult);
                }
            [Test]
            public void GetAddition_Input12and6_Returns18()

            {//Arrange
                double number1 = 12;
                double number2 = 6;
                double expectedResult = number1 + number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getsubtraction_Input15point0and6point0_Returns9point0()

            {//Arrange
                double number1 = 15.0;
                double number2 = 6.0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getsubtraction_Input10point0and8point0_Returns2point0()

            {//Arrange
                double number1 = 10.0;
                double number2 = 8.0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getsubtraction_Input20point0and10point0_Returns10point0()

            {//Arrange
                double number1 = 20.0;
                double number2 = 10.0;
                double expectedResult = number1 - number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getmultiplication_Input3point0and9point0_Returns27point0()

            {//Arrange
                double number1 = 3.0;
                double number2 = 9.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getmultiplication_Input3point0and8point0Returns24point0()

            {//Arrange
                double number1 = 3.0;
                double number2 = 8.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getmultiplication_Input12point0and4point0_Returns48point0()

            {//Arrange
                double number1 = 12.0;
                double number2 = 4.0;
                double expectedResult = number1 * number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getdivision_Input36and6_Returns6()

            {//Arrange
                double number1 = 36;
                double number2 = 6;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getdivision_Input12andReturns2()

            {//Arrange
                double number1 = 12.0;
                double number2 = 6.0;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void Getdivision_Input50and10Returns5()

            {//Arrange
                double number1 = 50;
                double number2 = 10;
                double expectedResult = number1 / number2;
                Calc testCalc = new Calc(number1, number2);
                //Act 
                double actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
        }
    }
