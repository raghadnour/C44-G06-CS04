using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Evolution of switch in C#
            //object obj = 10.5m; // Boxing

            #region C# 7.0 [pattern matching - Case Guards (When)]

            //#region Example 01 [pattern matching on types]
            //switch (obj)
            //{
            //    case int value: // Unboxing
            //        Console.WriteLine("Integer");
            //        break;
            //    case decimal value:
            //        Console.WriteLine("Decimal");
            //        break;
            //    case double value:
            //        Console.WriteLine("Double");
            //        break;
            //    default:
            //        Console.WriteLine("No Match");
            //        break;
            //}
            #endregion

            #region Example 02 [Case Guards (When)]
            //switch (obj)
            //{
            //    case int value when value < 10:
            //        Console.WriteLine("Integer Is Less Than 10");
            //        break;
            //    case int value when value > 10:
            //        Console.WriteLine("Integer Is Greater Than 10");
            //        break;
            //    case decimal value:
            //        Console.WriteLine("Decimal");
            //        break;
            //    case double value when value > 5.6 && value < 10.7:
            //        Console.WriteLine("Double Between 5.6 & 10.7");
            //        break;
            //}
            #endregion

            #endregion

            #region C# 8.0 [Pattern matching without alias name - Switch Expressions]
            //object number = 5;

            #region Example 01 - Pattern matching without alias name
            //switch (number)
            //{
            //    case int when (int)number < 10:
            //        Console.WriteLine("Integer Is Less Than 10");
            //        break;
            //    case int when (int)number > 10:
            //        Console.WriteLine("Integer Is Greater Than 10");
            //        break;
            //    case decimal:
            //        Console.WriteLine("Decimal");
            //        break;
            //    case double when (double)number > 5.6 && (double)number < 10.7:
            //        Console.WriteLine("Double Between 5.6 & 10.7");
            //        break;
            //}
            #endregion
            #region Switch Case Before Switch Expression
            //string option = Console.ReadLine();
            //string message;

            //switch (option)
            //{
            //    case "1":
            //        message = "Option 01";
            //        break;
            //    case "2":
            //        message = "Option 02";
            //        break;
            //    case "3":
            //        message = "Option 03";
            //        break;
            //    default:
            //        message = "Invalid Option";
            //        break;
            //}

            //Console.WriteLine(message);
            #endregion

            #region Example 02 Switch Expressions [Constant Pattern - Discard Pattern]
            //Console.WriteLine("Please Enter Option Number:");
            //string option = Console.ReadLine();
            //string message;

            //message = option switch
            //{
            //    "1" => "Option 01",
            //    "2" => "Option 02",
            //    "3" => "Option 03",
            //    _ => "Invalid Option",  // Discard pattern for default case
            //};

            Console.WriteLine(message);
            #endregion
            #region Example 04 [Nullable Type - Relational Patterns [Partially]]
            //int? X = 0;
            ////X = null;

            //string message = X switch
            //{
            //    null => "Null Value",
            //    > 0 => "Positive Number",       // Relational pattern (C# 9.0+)
            //    < 0 => "Negative Number",       // Relational pattern (C# 9.0+)
            //    0 => "Zero",
            //};

            //Console.WriteLine(message);
            #endregion


            #endregion

            #region C# 9.0 [Switch Expression With Relational Patterns - Logical Patterns - Enhanced]

            #region Example 01 [Relational Patterns]
            //int number = 50; // Test value (could be user input)

            //string result = number switch
            //{
            //    // Relational patterns (C# 9.0+)
            //    < 10 => "Less than 10",

            //    // Logical pattern combining two relational checks
            //    >= 10 and <= 20 => "Between 10 and 20",

            //    // Simple relational pattern
            //    > 20 => "Greater than 20",

            //    // The compiler knows this is exhaustive for int, so no default needed
            //};

            //Console.WriteLine($"The number {number} is: {result}");
            #endregion

            #region Example 02 [Logical Patterns (and, or)]
            /// Cases:
            /// - Number Between 1 and 9
            /// - Number Between 10 and 20
            /// - Number is Zero
            /// - Number Outside these ranges

            //int number = 50; // Test value

            //string result = number switch
            //{
            //    > 0 and < 10 => "Between 1 and 9",
            //    >= 10 and <= 20 => "Between 10 and 20",
            //    0 => "Zero",
            //    _ => "Outside specified ranges" // Default case
            //};

            //Console.WriteLine($"Number {number}: {result}");
            #endregion


            #endregion
            #region loops
            #region for _ foreach
            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
            //for(int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region while _ do while
            #region do_while
            // Let user enter an even number
            // Reject odd numbers and non-numeric inputs
            //int number;
            //bool isValid;

            //do
            //{
            //    Console.WriteLine("Please Enter An Even Number:");
            //    isValid = int.TryParse(Console.ReadLine(), out number);

            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a numeric value.");
            //    }
            //    else if (number % 2 != 0)
            //    {
            //        Console.WriteLine($"{number} is odd. Please enter an even number.");
            //    }

            //} while (!isValid || number % 2 != 0);

            //Console.WriteLine($"{number} is an even number.");
            #endregion
            #region while
            //int cnt = 10;
            //while (cnt>0)
            //{
            //    Console.WriteLine(cnt);
            //    cnt--;
            //}
            #endregion
            #endregion
            #endregion

            #region string
            #region Example 01
            //string name01;
            // Declare for a reference from type string "name"
            // reference "name" is referring to default value of reference type [null]
            // CLR will allocate 4 bytes at stack for reference "name"
            // 0 bytes allocated at heap

            //name01 = new string("Ali");
            // CLR Will allocate required bytes at heap [6 Bytes]
            //name01 = "Ahmed";
            //Console.WriteLine(name01.GetHashCode());
            //string name02 = "Ahmed";
            //Console.WriteLine(name02.GetHashCode());
            // String Pool

            //Console.WriteLine(name01.GetHashCode());
            //name01 = "Ali";
            //Console.WriteLine(name01.GetHashCode());
            #endregion
            #region Example 02
            //string name01 = "Amr";
            //string name02 = "May";

            //Console.WriteLine($"Name01 => {name01}");
            //Console.WriteLine($"HashCode Of Name01 => {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 => {name02}");
            //Console.WriteLine($"HashCode Of Name02 => {name02.GetHashCode()}");

            //name02 = name01;
            //Console.WriteLine("============ After Assign ===========");
            //Console.WriteLine($"Name01 => {name01}");
            //Console.WriteLine($"HashCode Of Name01 => {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 => {name02}");
            //Console.WriteLine($"HashCode Of Name02 => {name02.GetHashCode()}");

            //name01 = "Omar"; 
            //Console.WriteLine("============ After change val in name01 ===========");
            //Console.WriteLine($"Name01 => {name01}");
            //Console.WriteLine($"HashCode Of Name01 => {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 => {name02}");
            //Console.WriteLine($"HashCode Of Name02 => {name02.GetHashCode()}");

            #endregion
            #region Example 03
            //string message = "Hello";

            //// Original string
            //Console.WriteLine($"Message = {message}");
            //Console.WriteLine($"HashCode => {message.GetHashCode()}");

            //// After concatenation
            //message += " Route Academy";
            //Console.WriteLine("============ After Concat ========");
            //Console.WriteLine($"Message = {message}");
            //Console.WriteLine($"HashCode => {message.GetHashCode()}");
            #endregion
            #region String methods
            //string message = "Hello Route Academy"; // Example string

            //// Common string operations (uncommented and corrected):
            //Console.WriteLine(message.Length);          // Gets string length (18)
            //Console.WriteLine(message.ToUpper());      // "HELLO ROUTE ACADEMY"
            //Console.WriteLine(message.ToLower());      // "hello route academy"
            //Console.WriteLine(message.Trim());         // Removes whitespace from both ends
            //Console.WriteLine(message.TrimEnd());      // Removes trailing whitespace
            //Console.WriteLine(message.TrimStart());    // Removes leading whitespace
            //Console.WriteLine(message.Substring(0, 5)); // "Hello" (first 5 chars)
            //Console.WriteLine(message.Replace('e', 'T')); // "HTllo RoutT AcadTmy"
            //Console.WriteLine(message.Contains('M'));   // False (case-sensitive check)
            #endregion
            #region StringBuilder Methods
            //StringBuilder message = new StringBuilder("Hello Route Academy");

            //// Basic operations
            //message.Append(" Academy");       // Appends to end → "Hello Route Academy Academy"
            //message.AppendLine(" Route");     // Appends with newline
            //message.Replace('o', 'T');        // Replaces all 'o' with 'T' → "HellT ROute Academy Academy Route"

            //// Structural modifications
            //message.Clear();                  // Clears all content
            //message.Append("Hello World");    // Start fresh
            //message.Remove(0, 5);             // Removes 5 chars from start → " World"
            //message.Insert(0, "Hi");          // Inserts at beginning → "Hi World"

            //// Advanced formatting
            //int age = 29;
            //message.AppendFormat(". Your Age: {0}", age); // → "Hi World. Your Age: 29"

            //// Collection joining
            //message.AppendJoin(", ", new[] { " Ahmed", " Ali", " Osama" });
            //// Final result → "Hi World. Your Age: 29 Ahmed, Ali, Osama"

            //Console.WriteLine(message.ToString());
            #endregion

            #endregion
        }
    }
}
