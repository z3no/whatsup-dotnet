// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
// Console.WriteLine() prints an entire message to the output console. At the end of the line, it adds a line feed similar to creating a new line of text by pressing 'Enter' or 'Return'.

// Console.Write() prints to the output console, but without adding a line feed at the end. So the next call to Console.Write() prints an additional message to the same line.
Console.Write("Congratz Zeno!");
Console.Write(" ");
Console.Write("You wrote your first lines of code and created a code comment!");

Console.WriteLine("This is the first line.");
Console.Write("This is the");
Console.Write(" second ");
Console.Write("line.");

// DIFFERENT LITERAL DATA TYPES

// Char literal
Console.WriteLine('z'); //single quotes are used for a single char
//Console.WriteLine('Hello World!'); //expects single char - error - too many characters in character literal

// Int literal
Console.WriteLine(33);

// Decimal literal
// To create a decimal literal, append the letter m after the number. In this context, the m is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of type decimal.
Console.WriteLine(12.30m);

// Bool literal
// The bool literals represent the idea of truth and falsehood.
Console.WriteLine(true);
Console.WriteLine(false);

// Setting and getting values from variables
string firstName;
firstName = "Zeno";
Console.WriteLine(firstName);

// Reassign the value of a variable
string firstName;
firstName = "Zeno";
Console.WriteLine(firstName);
firstName = "Pablo";
Console.WriteLine(firstName);
firstName = "Lucas";
Console.WriteLine(firstName);
firstName = "Alex";
Console.WriteLine(firstName);

// Initializing the variable
string firstName = "Zeno";
Console.WriteLine(firstName);

// Challenge
string firstName = "Zeno";
int amount = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(firstName);
Console.Write("! You have ");
Console.Write(amount);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

//Character Escape Sequences and Verbatim Strings

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
//display a file path
Console.WriteLine("c:\\source\\repos\n");

Console.WriteLine("Generating invoices for costumer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

//To generate Japanese invoices:
//Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

//Verbatim String literal
//use the @ directive before the literal string
Console.Write("\n\n");
Console.WriteLine(@"    c:\source\repos
        (""this is where your code goes"")");

//Unicode escape characters
//Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

//String concatenation
string firstName = "Zeno";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

//String interpolation
string firstName = "Zeno";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName}!");

//Combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\\Output\{projectName}\Data");

//add numeric values
int firstNumber = 12;
int secondNumber = 9;
Console.WriteLine(firstNumber + secondNumber);

//Perform basic operations on numbers in C#

//mix data types to force implicit type conversions
//string firstName = "Zeno";
//int chocolateBarsSold = 25;
//Console.WriteLine(firstName + " you already sold " + chocolateBarsSold + " chocolate bars!");

//a more advanced case of adding numbers and concatenating strings
//string firstName = "Zeno";
//int chocolateBarsSold = 25;
//Console.WriteLine(firstName + " you already sold " + chocolateBarsSold + 6 + " chocolate bars!");
// instead of adding the int variable chocolateBarsSold to the literal int 6, the compiler treats everything as a string and concatenates it all together.

//add parentheses to make our intention clear to the compiler
string firstName = "Zeno";
int chocolateBarsSold = 25;
Console.WriteLine(firstName + " you already sold " + (chocolateBarsSold + 6) + " chocolate bars!");

//BASIC MATH OPERATIONS
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
//int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
//Console.WriteLine("Quotient: " + quotient);

//The resulting quotient of our division example may not be what you expected. The values after the decimal are truncated from quotient since it is defined as an int, and int cannot contain values after the decimal.

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

//Two examples that work equally well:
// decimal decimalQuotient = 7 / 5.0m;
// decimal decimalQuotient = 7.0m / 5.0m;

//The following lines won't work (or will give inaccurate results):
// int decimalQuotient = 7 / 5.0m;
// int decimalQuotient = 7.0m / 5;
// int decimalQuotient = 7.0m / 5.0m;
// decimal decimalQuotient = 7 / 5;

// Add code to perform division using literal decimal data
// Perform a data type cast - Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type.
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

//Write code to determine the remainder after int division
//The remainder operator % tells you the remainder of int division.
//What you really learn from this operator is whether one number is divisible by another.
Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));
//When the modulus is 0, that means the dividend is divisible by the divisor.

// PEMDAS an acronym to remember the order in which multiple operations are performed.
// 1) Parentheses (whatever is inside the parentheses is performed first)
// 2) Exponents
// 3) Multiplication and Division (from left to right)
// 4) Addition and Subtraction (from left to right)

//C# follows the same order as PEMDAS except for exponents. There is no exponent operator in C#, you can use System.Math.Pow() method.

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//Increment and decrement values
// += operator adds and assigns the value on the right of the operator to the value on the left of the operator
//int value = 0;
//value = value + 5;
//value += 5;

//the ++ operator increments the value of the variable by 1
//int value = 0;
//value = value + 1;
//value++;

//Increment and decrement a value

//int value = 1;

//value = value + 1;
//Console.WriteLine("First increment: " + value);

//value += 1;
//Console.WriteLine("Second increment: " + value);

//value++;
//Console.WriteLine("Third increment: " + value);

//value = value - 1;
//Console.WriteLine("First decrement: " + value);

//value -= 1;
//Console.WriteLine("Second decrement: " + value);

//value--;
//Console.WriteLine("Third decrement: " + value);

//Positioning the increment and decrement operators
//Both the increment and decrement operators have an interesting quality: depending on their position, they perform their operation before or after they retrieve their value.
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

//Console.WriteLine("Second: " + value++);
// 1. Retrieve the current value of the variable value and use that in the string concatenation operation.
// 2. Increment the value.
// The next line of code confirms that the values was, in fact, incremented:
// Console.WriteLine("Third: " + value);

// Consider the last line of code:
// Console.WriteLine("Fourth: " + (++value));
// The order of operations is switched, because the ++ operator is placed before the operand value.
// 1. Increment the value.
// 2. Retrieve the new incremented value of the variable value and use that in the string concatenation operation.

//CHALLENGE
//Convert a temperature from degrees Fahrenheit to Celsius.
//To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);

Console.WriteLine($"The temperature is {celsius} Celsius");

