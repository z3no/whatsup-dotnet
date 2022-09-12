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
Console.WriteLine('Hello World!'); //expects single char - error - too many characters in character literal

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

