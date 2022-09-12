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