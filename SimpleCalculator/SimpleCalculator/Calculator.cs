using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    delegate string Operators(string Argument1, string Argument2);
    class Operations
    {
        /// <summary>
        /// Converts Arg1 and Arg2 to integer type (if it's able) and
        /// adds Arg2 to Arg1 or makes concatenation Arg1 and Arg2
        /// </summary>
        /// <param name="Arg1"></param>
        /// <param name="Arg2"></param>
        /// <returns></returns>
        public string Addition(string Arg1, string Arg2)
        {
            ulong Result;
            ulong temp1 = 0, temp2 = 0;
            string ResString = string.Empty;

            if ((ulong.TryParse(Arg1, out temp1)) && (ulong.TryParse(Arg2, out temp2)))              
            {
                try
                {
                    Result = temp1 + temp2;
                    ResString = Result.ToString();
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Error: Too large summary value.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                }
            }
            else
            {
                ResString = string.Concat( Arg1, Arg2);
            }
            return ResString;
        }
        /// <summary>
        /// Converts Arg1 and Arg2 to integer type (if it's able) and
        /// subtracts Arg2 from Arg1 or print message about error.
        /// </summary>
        /// <param name="Arg1"></param>
        /// <param name="Arg2"></param>
        /// <returns></returns>
        public string Subtraction(string Arg1, string Arg2)
        {
            long Result;
            long temp1 = 0, temp2 = 0;
            string ResString = string.Empty;

            if ((long.TryParse(Arg1, out temp1)) && (long.TryParse(Arg2, out temp2)))
            {
                try
                {
                    Result = temp1 - temp2;
                    ResString = Result.ToString();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Too large value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                }
            }
            else
            {
                Console.WriteLine("Error: Illegai format of expression!");
            }
            return ResString;
        }

        /// <summary>
        /// Converts Arg1 and Arg2 to integer type (if it's able) and
        /// Arg1 multiplies by Arg2  or print message about error.
        /// </summary>
        /// <param name="Arg1"></param>
        /// <param name="Arg2"></param>
        /// <returns></returns>
        public string Multiplication(string Arg1, string Arg2)
        {
            ulong Result;
            ulong temp1 = 0, temp2 = 0;
            string ResString = string.Empty;

            if ((ulong.TryParse(Arg1, out temp1)) && (ulong.TryParse(Arg2, out temp2)))
            {
                try
                {
                    Result = temp1 * temp2;
                    ResString = Result.ToString();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Too large summary value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                }
            }
            else
            {
                Console.WriteLine("Error: Illegai format of expression!");
            }
            return ResString;
        }

        /// <summary>
        /// Converts Arg1 and Arg2 to integer type (if it's able) and
        /// Arg1 divides by Arg2  or print message about error.
        /// </summary>
        /// <param name="Arg1"></param>
        /// <param name="Arg2"></param>
        /// <returns></returns>
        public string Division(string Arg1, string Arg2)
        {
            ulong Result;
            ulong temp1 = 0, temp2 = 0;
            string ResString = string.Empty;

            if ((ulong.TryParse(Arg1, out temp1)) && (ulong.TryParse(Arg2, out temp2)))
            {
                try
                {
                    Result = temp1 / temp2;
                    ResString = Result.ToString();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: Too large value.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: You divaded by zero!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                }
            }
            else
            {
                Console.WriteLine("Error: Illegai format of expression!");
            }
            return ResString;
        }
    }

    class Expressions
    {
        /// <summary>
        /// Dictionary of operations
        /// </summary>
        public Dictionary<char, Operators> Operator = new Dictionary<char, Operators>();
        Operations Op = new Operations();
 
        /// <summary>
        /// Fills dictionary of operations
        /// </summary>
        public Expressions()
        {
            Operator.Add('+', Op.Addition);
            Operator.Add('-', Op.Subtraction);
            Operator.Add('*', Op.Multiplication);
            Operator.Add('/', Op.Division);
        }

        /// <summary>
        /// Remove all spaces from InpString
        /// </summary>
        /// <param name="InpString"></param>
        /// <returns></returns>
        public string RemoveSpace(string InpString)
        {
            string ResString = string.Empty;

            for (int count = 0; count < InpString.Length; count++)
            {
                if (InpString[count] != ' ')
                {
                    ResString += InpString[count];
                }
            }
            return ResString;
        }

        /// <summary>
        /// Looks for operation's character in InpString and return its index
        /// </summary>
        /// <param name="InpString"></param>
        /// <returns></returns>
        public int OpIndex(string InpString)
        {
            int Index = 0;

            for (int Count = 0; Count < InpString.Length; Count++)
            {
                if ((InpString[Count] == '+' || InpString[Count] == '-' ||
                    InpString[Count] == '*' || InpString[Count] == '/'))
                {
                    if ( Index != 0 || Count == 0 )
                    {
                        return Index;
                    }
                    else
                    {
                        Index = Count;
                    }
                }
            }

            return Index;
        } 
    }

    class Calculator
    {
        static void Main(string[] args)
        {
            string Expression, Result;
            int OpIndex_ = 0;
            char CurOp;

            Expressions Exp = new Expressions();
            do
            {
                Expression = string.Empty;
                Result = string.Empty;
                OpIndex_ = 0;

                Console.WriteLine("Enter your expression:");
                Expression = Exp.RemoveSpace(Console.ReadLine());
                OpIndex_ = Exp.OpIndex(Expression);
                
                //Look for result of expression
                if (OpIndex_ != 0 && OpIndex_ < Expression.Length - 1)
                {
                    CurOp = Expression[OpIndex_];
                    Result = Exp.Operator[CurOp](Expression.Substring(0, OpIndex_),
                    Expression.Substring(OpIndex_ + 1, Expression.Length - OpIndex_ - 1));
                    if (Result != "")
                    {
                        Console.WriteLine(Expression + "=" + Result);
                    }
                }
                else
                {
                    Console.WriteLine("Error: Illegal format of expression.");
                }

                Console.Write("Want to repeat then press 'y' - ");
                Result = Console.ReadLine();
            } while (Result == "y" || Result == "Y");
            


        }
    }
}
