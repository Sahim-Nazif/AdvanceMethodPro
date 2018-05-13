using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* what is a method?
 * A method is a group of statements that together perform a task. Every C# program has 
 * at least one class with a method named Main.
 * To use a method, you need to −
 * 1-  Define the method
 * 2- Call the method
 * Date: 13 May, 2018 
 * Description: Advance Method demo (example).
 * Added reference to MethodTestPro
 */
namespace AdvanceMethodPro
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 50;
            int number2 = 3;
            int result = 0;
            result = MultiplyNumbers(number1, number2);
            Console.WriteLine(result);

        }
        /*
         * Method multiplyin two values.
         * Parameters are two integer types.
         * Advance method type.
         */


        public static int MultiplyNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }
    }
}
