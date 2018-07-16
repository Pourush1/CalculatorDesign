using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Interfaces;
using System.Text.RegularExpressions;

namespace Logic
{

    public class Calculator
    {
        public IBinaryOperation pending_operation = null;
        private IUnaryOperation unary_operation = null;
        double firstEnteredValue = 0.0;
        double lastEnteredValue = 0.0;
        string result_Of_Operation = "";
        bool isOperationPerformed = false;
        string current_operation = "";

        public string Equals()
        {


            double lhs = firstEnteredValue;
            double rhs = lastEnteredValue;

            if (pending_operation != null)
                firstEnteredValue = pending_operation.Perform_binary_calculation(lhs, rhs);

            return firstEnteredValue.ToString();
        }

        public string UnaryEquals()
        {

            if (firstEnteredValue == 0)
            {
                return "cannot divide by zero";
            }

            if (unary_operation != null)
                firstEnteredValue = unary_operation.Perform_unary_calculation(firstEnteredValue);

            return firstEnteredValue.ToString();

        }



        public string Number_entered(double value)
        {


            if (pending_operation == null || isOperationPerformed)
            {
                firstEnteredValue = value;
            }
            else
            {
                lastEnteredValue= value;
            }
            return value.ToString();




        }

        public string Addition_entered()
        {
            current_operation = "+";
            if (pending_operation == null || isOperationPerformed ) {
                pending_operation = new Addition();
                result_Of_Operation = firstEnteredValue.ToString();
                current_operation = "";
                isOperationPerformed = false;
            }
            else
            {
                result_Of_Operation = Equals();
                isOperationPerformed = true;
            }
            return result_Of_Operation;

        }

         public string Subtraction_entered()
        {
            current_operation = "-";
                
                if (pending_operation == null || isOperationPerformed)
                {
                    pending_operation = new Subtraction();
                    result_Of_Operation = firstEnteredValue.ToString();
                    isOperationPerformed = false;
                }

                else
                {
                    result_Of_Operation = Equals();
                    isOperationPerformed = true;
                }
         
            return result_Of_Operation;
        }

        public string Multiplication_entered()
        {
            current_operation = "*";

            if (pending_operation == null || isOperationPerformed)
            {
                pending_operation = new Multiplication();
                result_Of_Operation = firstEnteredValue.ToString();
                isOperationPerformed = false;
            }

            else
            {
                result_Of_Operation = Equals();
                isOperationPerformed = true;
            }

            return result_Of_Operation;
        
    }

        public string Division_entered()
        {
            current_operation = "*";

            if (pending_operation == null || isOperationPerformed)
            {
                pending_operation = new Division();
                result_Of_Operation = firstEnteredValue.ToString();
                isOperationPerformed = false;
            }

            else
            {
                result_Of_Operation = Equals();
                isOperationPerformed = true;
            }

            return result_Of_Operation;

        }

        public string Reciprocal_entered()
        {

            unary_operation = new Reciprocal();
            string firstEnteredValue = UnaryEquals();
            return firstEnteredValue;
        }

        public string Square_root_entered()
        {

            unary_operation = new SquareRoot();
            UnaryEquals();
            return firstEnteredValue.ToString();

        }

        public string Clear_entered()
        {
            pending_operation = null;
            unary_operation = null;
            firstEnteredValue = 0.0;
            lastEnteredValue = 0.0;
            return "0";
        }

    }

    public class SquareRoot : IUnaryOperation
    {
        public double Perform_unary_calculation(double lhs)
        {

            return Math.Sqrt(lhs);
        }
    }

    public class Reciprocal : IUnaryOperation
    {
        public double Perform_unary_calculation(double lhs)
        {
            return 1 / lhs;
        }
    }

    public class Addition : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs + rhs;
        }
    }
    public class Subtraction : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs - rhs;
        }
    }

    public class Multiplication : Logic_Interfaces.IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs * rhs;
        }
    }

    public class Division : IBinaryOperation
    {
        public double Perform_binary_calculation(double lhs, double rhs)
        {
            return lhs / rhs;
        }
    }


}

