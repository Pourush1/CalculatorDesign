using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class Test_Calculator
    {
        [TestMethod]
        public void Test_AdditionDecimalNumbers()
        {
            double lhs = 9.3;
            double rhs = 1.9;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(11.2, result, 0.00001);

        }

        [TestMethod]
        public void Test_AdditionWholeNumbers()
        {
            double lhs = 17.0;
            double rhs = 2.0;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void Test_AdditionWholeNumbersWithNegativeValues()
        {
            double lhs = -17.0;
            double rhs = -4.0;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(-21, result);
        }

        public void Test_AdditionWholeNumbersWithPositiveNegativeValues()
        {
            double lhs = -17.0;
            double rhs = 4.0;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(-13, result);
        }

        [TestMethod]
        public void Test_SubtractionDecimalNumbers()
        {
            double lhs = 3.1;
            double rhs = 2.9;
            Logic_Interfaces.IBinaryOperation subtraction = new Logic.Subtraction();
            double result = subtraction.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(0.2, result, 0.000001);
        }

        [TestMethod]
        public void Test_SubtractionWholeNumbers()
        {
            double lhs = 3.0;
            double rhs = 2.0;
            Logic_Interfaces.IBinaryOperation subtraction = new Logic.Subtraction();
            double result = subtraction.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_SubtractionNegativeWholeNumbers()
        {
            double lhs = -3.0;
            double rhs = -2.0;
            Logic_Interfaces.IBinaryOperation subtraction = new Logic.Subtraction();
            double result = subtraction.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test_SubtractionPostiveNegativeWholeNumbers()
        {
            double lhs = 5.0;
            double rhs = -2.0;
            Logic_Interfaces.IBinaryOperation subtraction = new Logic.Subtraction();
            double result = subtraction.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Test_MultiplicationDecimalNumbers()
        {
            double lhs = 10.2;
            double rhs = 3.6;
            Logic_Interfaces.IBinaryOperation multiplication = new Logic.Multiplication();
            double result = multiplication.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(36.72, result, 0.00001);
        }

        [TestMethod]
        public void Test_MultiplicationWholeNumbers()
        {
            double lhs = 10.0;
            double rhs = 3.0;
            Logic_Interfaces.IBinaryOperation multiplication = new Logic.Multiplication();
            double result = multiplication.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Test_MultiplicationNegativeNumbers()
        {
            double lhs = -10.0;
            double rhs = -3.0;
            Logic_Interfaces.IBinaryOperation multiplication = new Logic.Multiplication();
            double result = multiplication.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Test_MultiplicationPositiveNegativeNumbers()
        {
            double lhs = 10.0;
            double rhs = -3.0;
            Logic_Interfaces.IBinaryOperation multiplication = new Logic.Multiplication();
            double result = multiplication.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(-30, result);
        }

        [TestMethod]
        public void Test_DivisionDecimalNumbers()
        {
            double lhs = 5.50;
            double rhs = 2.5;
            Logic_Interfaces.IBinaryOperation division = new Logic.Division();
            double result = division.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(2.2, result);
        }

        [TestMethod]
        public void Test_DivisionWholeNumbers()
        {
            double lhs = 4.0;
            double rhs = 2.0;
            Logic_Interfaces.IBinaryOperation division = new Logic.Division();
            double result = division.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_DivisionNegativeNumbers()
        {
            double lhs = -4.0;
            double rhs = -2.0;
            Logic_Interfaces.IBinaryOperation division = new Logic.Division();
            double result = division.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_DivisionPositiveNegativeNumbers()
        {
            double lhs = -4.0;
            double rhs = 2.0;
            Logic_Interfaces.IBinaryOperation division = new Logic.Division();
            double result = division.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Test_ReciprocalPositiveNumber()
        {
            double lhs = 10.0;
            Logic_Interfaces.IUnaryOperation reciprocal = new Logic.Reciprocal();
            double result = reciprocal.Perform_unary_calculation(lhs);
            Assert.AreEqual(0.1, result);
        }

        [TestMethod]
        public void Test_ReciprocalNegativeNumber()
        {
            double lhs = -10.0;
            Logic_Interfaces.IUnaryOperation reciprocal = new Logic.Reciprocal();
            double result = reciprocal.Perform_unary_calculation(lhs);
            Assert.AreEqual(-0.1, result);
        }

        [TestMethod]
        public void Test_SquareRoot()
        {
            double lhs = 9.0;
            Logic_Interfaces.IUnaryOperation squareRoot = new Logic.SquareRoot();
            double result = squareRoot.Perform_unary_calculation(lhs);
            Assert.AreEqual(3.0, result);
        }
    }
}
