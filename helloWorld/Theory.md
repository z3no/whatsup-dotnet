# C# training exercises
***

Here I will store some coding exercises I'm doing through the C# training and also theory.
If I ever need to, I can come back here and take a look, or I can check my notepad where I wrote down some stuff.

````
// Console.WriteLine() prints an entire message to the output console. At the end of the line, it adds a line feed similar to creating a new line of text by pressing 'Enter' or 'Return'.

// Console.Write() prints to the output console, but without adding a line feed at the end. So the next call to Console.Write() prints an additional message to the same line.
Console.Write("Congratz Zeno!");
Console.Write(" ");
Console.Write("You wrote your first lines of code and created a code comment!");

Console.WriteLine("This is the first line.");
Console.Write("This is the");
Console.Write(" second ");
Console.Write("line.");
````

***

### DIFFERENT LITERAL DATA TYPES

````
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
````

***

### Store and retrieve data using literal and variable values

````
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
````

***

### Perform basic string formatting in C#

````
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
````

***

### Perform basic operations on numbers

````
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
````

***

### Call methods from the .NET Class Library

#### What is the .NET Class Library?
It is a collection of thousands of classes containing tens of thousands of methods.
These methods are created by Microsoft and are available for use in your applications.

Even data types are part of the .NET Class Library.

##### What is a namespace?
Think of a namespace as the last name, surname, or "family name" for a type.
A class contains the code that implements a type. Classes are organized into namespaces to prevent naming collisions.

#### Calling different kinds of methods in the .NET Class Library
Let's take a look at an example that simulates a dice roll. It will generate a random number and print it to our console.

````
    Random dice = new Random();
    int roll = dice.Next(1,7);
    Console.WriteLine(roll);
````
If we run the code multiple times, numbers from 1 to 6 will be displayed in the console output.

- The first line creates a new instance of the `System.Random` class (in the .NET Class Library) and stores the reference to the new object in a variable named `dice`.
  - This is something that already looks very familiar from working with classes in PHP.
- The second line calls the `dice` object's `Next()`method passing in 2 parameters, which in our case is the minimum and maximum value of the random number. The method (`Next()`) returns the value, which will be saved into a variable named `roll`.
- The third line of code calls the `WriteLine()` method to print the value of `roll`to the console.

In the example we are calling a method of the Random class and the Console class.
The way we are calling them is different. The reason, because some methods are stateful and others are stateless.

#### Stateful vs Stateless
`State` describes the condition of the execution environment at a specific moment in time.
Your code executes line by line and values are stored in variables. At any moment during execution, the current state of the application is the collection of all values stored in memory.

Some methods don't rely on the current state of the app to work properly. These are `Stateless` methods, they can work without referencing or changing any values already stored in memory.
`Stateless` methods are also known as `Static` methods.
The `Console.WriteLine()` method doesn't rely on any values stored in memory. It performs its function and finishes without impacting the state of the app in any way.

However, other methods **must** have access to the state of the app to work properly.
These are `Stateful methods` and are built in such a way that they rely on values stored in memory by previous lines of code that have been executed, or they modify the state of the app by updating values or storing new values in memory.
`Stateful` methods are also known as `Instance methods`.

`Stateful (instance)` methods keep track of their state in **fields**, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state.

A single class can support both `stateful` and `stateless` methods. However, when you need to call **stateful** methods, you must first create an instance of the class so that the method can access state.

#### Creating an instance of a class
As we learned when we started with OOP an instance of a class is called an ***object***. Also in C# we use the `new` operator to create a new instance of a class.
But let's look a little deeper in what is happening in the following line of code:
````csharp
Random dice = new Random();
````
The `new` operator does several important things:
- It first requests an address in the computer's memory large enough to store a new object based on the `Random` class.
- It creates the new object and stores it at the memory address.
- It returns the memory address so that it can be saved in the `dice` variable.

From that point on, when the `dice` variable is referenced, the .NET Runtime performs a lookup behind the scenes to give the illusion that you're working directly with the object itself.

#### Working with return values and input parameters
-`Void methods`: Methods that are designed to complete their function and end "quietly". They don't return values when they finish.

In our previous example the `Random.next()` method returns an `int` value of the randomly generated number. We save the return in a variable for later use.
We could also ignore it like so, `dice.Next(1, 7);`, but this would be pointless. We're calling the method so we can retrieve the next random value.

##### Input parameters
Some methods don't need additional input to complete their task. Others are designed to accept one or more input parameters.
Input parameters might configure how the method performs its work.

When calling methods, separate each input param with a `,` symbol.

The two input params define the lower and upper boundaries, respectively, for the `Next()` method as it generates a new random number:
````
int roll = dice.Next(1, 7);
````

In the following line of code, the input parameters are what the `WriteLine()` operates on to display to the console:
````
Console.WriteLine(roll);
````

Input params are defined using a data type. We can't pass values of a different data type as input params and expect the method to work.

-`Method signature`: Is the number of input parameters defined for each input parameter and the data type.

##### Overloaded methods
- `Overloaded method`: Is defined with multiple method signatures. Overloaded methods provide different ways to call the method or provide different types of data.

For example, the `Console.WriteLine()` method has 19 different overloaded versions. Most of these allow sending of different types of data to be printed to the console.
````
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);
````

The `Random.Next()` method has three different overloaded versions.
```
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
```
- The first version doesn't set an upper and lower boundary. It will return values ranging from 0 to 2,147,483,647, which is the maximum value an `int` can store.
- The second version specifies the maximum value as an upper boundary, we can expect a random value between 0 and 100.
- The third version specifies both minimum and maximum values. In this case we can expect a random value between 50 and 100.

#### Challenge

Use Intellisense or the documentation at [docs.microsoft.com](https://docs.microsoft.com/en-gb/) to find and call a method that returns the larger of two numbers.

````
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
````

[Math.Max method](https://docs.microsoft.com/en-us/dotnet/api/system.math.max?view=net-6.0)

***

### Add decision logic to your code using `if`, `else`, and `else if` statements in C#
The `if` statement is made up of three parts:
- The `if` keyword.
- A Boolean expression between parentheses `()`.
- A code block defined by curly braces `{ }`.

These exercises are a nice refresher for the if statement. Check them out at the training module.

***

### Store and iterate through sequences of data using Arrays and the foreach statement in C#

#### Declaring arrays in C#
It is a bit different from the languages we have seen at BeCode.
As we know an array is a special type of variable that can hold multiple values of the same data type.
In C# the declaration syntax is slightly different because we have to specify both the data type and the size of the array.

For example:
To declare a new array of strings that will hold three elements, we do it like so
```
string[] fraudulentOrderIDs = new string[3];
````
The new operator creates a new instance of an array in the computer's memory that can hold three string values.
The first set of square brackets `[]` merely tells the compiler that the variable named `fraudulentOrderIDs` will be an array, but the second set of square brackets `[3]` contains the number of elements that the array will hold.

```
string[] fraudulentOrderIDs = new string[3];

// Assign values to elements on an array
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// Using an index that is out of bounds of the array
// fraudulentOrderIDs[3] = "D000"; as we know this will not work we only declared 3 and an array starts counting from 0

// Getting values of elements in an array
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassigning the value of an array
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
```

#### Initializing an Array
Just like initializing a variable at the time you declare it, you can initialize a new array at the time you declare it using a special syntax featuring curly braces.

```
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
```

```
// We use /* */ to comment out multiple lines
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
```
The above code will give the same output.

##### Recap
The most important things to remember when working with arrays.
- An array is a special variable that holds a sequence of related data elements.
- You should memorize the basic format of an array variable declaration.
- Access each element of an array to set or get its values using a zero-based index inside of square brackets.
- If you attempt to access an index outside of the boundary of the array, you'll get a run time exception.
- The `Length` property gives you a programmatic way to determine the number of elements in an array.

#### foreach

```
/* 
string[] names = { "Bob", "Conrad", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
//bin will hold the current iteration of the foreach statement
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    //++ increments the value by 1
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
```
- Use the `foreach` statement to iterate through each element in an array, executing the associated code block once for each element in the array.
- The `foreach` statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
- Use the `++` increment operator to add 1 to the current value of a variable.

##### Challenge
Previously, we set out to write code that would store Order IDs belonging to potentially fraudulent orders.
Our hope is to find fraudulent orders as early as possible and flag them for deeper analysis.

Our team found a pattern. Orders that start with the letter "B" encounter fraud 25 times the normal rate.
We will write new code that will output the Order ID of new orders where the Order ID starts with the letter "B".
This will be used by our fraud team to investigate further.

```
string[] fakeOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string fakeOrder in fakeOrderIDs)
{
    if (fakeOrder.StartsWith("B"))
    {
        Console.WriteLine(fakeOrder);
    }
}
```

***

### Create readable code with conventions, whitespace, and comments in C#
#### Variable names that follow the rules and conventions

**Variable name rules:**
- Variable names can contain alphanumeric characters and the underscore character. Special characters like the pound `#`, the dash `-`, and the dollar sign `$` are not allowed.
- Variable names must begin with an alphabetical letter or an underscore, not a number. Developers use the underscore for a special purpose, so try to not use that for now.
- Variable names must not be a C# keyword. For example, these variable name declarations won't be allowed: `float float;` or `string string;`.
- Variable names are case-sensitive, meaning that `string MyValue;` and `string myValue;` are two different variables.

**Variable name conventions:**
Conventions are suggestions that the software-development community agrees upon.

- Variable names should use **camel case**. Example: `string thisIsCamelCase`
- Variable names should be descriptive and meaningful in your application. It should represent the kind of data it will hold.
- Variable names should be one or more entire words appended together.
- Variable names shouldn't include the data type of the variable. Don't be this guy `string strMyValue` be this guy `string firstName`.

These rules and conventions are for `local variables`.
A `local variable` is a variable that is scoped within the body of a method.

There are other kinds of variables that are used in classes. Classes support **fields**, which are members of a class that act like variables inasmuch that they store values; or rather, state.
Private fields and public fields have their own naming conventions. Classes and methods have their own naming conventions.
It's important to know that the naming conventions we just learned fit into a larger naming framework.
The end goal is that by merely looking at the name of any identifier (local variable, private field, class, method, and so on), you should be able to understand something about how the code functions immediately.

#### Code comments
Useful in three situations:
- When you want to leave a note about the intent of a passage of code. Your future self will thank you!
- When you want to temporarily remove code from your app to try a different approach, but not convinced if it will work.
- Adding a message like `TODO` to remind you to look at a given passage of code later.

***

### Control variable scope and logic using code blocks in C#

#### Code blocks and variable scope
Things to remember about code blocks:
- When you define a variable inside of a code block, its visibility is local to that code block and inaccessible outside of that code block.
- To make a variable visible inside and outside a code block, you must define the variable outside the code block.
- Initialize any variables whose value is set in a code block, such as an `if` statement.

***

### Branch the flow of code using the switch-case construct in C#

#### What is the switch statement?
`switch` is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression.
A switch statement includes one or more switch sections.
Each switch section contains one or more case labels (either a case or default label) followed by one or more statements. It may include at most one default label placed in any switch section.

Switch is best used when:
- You have a single value you want to match against many possible values.
- But for any given match, you need to execute a couple of lines of code at most.

There is a possibility that multiple cases apply. However, C# will select the first matching expression.

The main takeaways you learned about the switch statement:
- Use the `switch` statement when you have one value with many possible matches, witch each match requiring a branch in your code logic.
- A single switch section containing code logic can be matched using one or more labels defined by the `case` keyword.
- Use the potential `default` keyword to create a label and a switch section to be used when no other case labels match.

#### Challenge:
Rewrite the following code to use the switch-case statement instead of the if-elseif-else statement.

```
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
```

Using a switch-case it would like the following:
```
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
```

***

### The for statement

- The `for` iteration statement allows you to iterate through a block of code a specific number of times.
- The `for` iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions inside the parenthesis: the initializer, condition, and iterator.
- It's common to use the `for` statement when you need to control how you want to iterate through each item in an array.
- If you code block has only one line of code, you can eliminate the opening and closing curly braces and white space if you wish.

#### FizzBuzz challenge
FizzBuzz is a popular coding challenge.

```
/*

FizzBuzz rules:

- Output values from 1 to 100, one number per line.
- When the current value is divisible by 3, print the term FIZZ next to the number.
- When the current value is divisible by 5, print the term BUZZ next to the number.
- When the current value is divisible by both 3 and 5, print the term FIZZBUZZ next to the number.

*/

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine(i + " - FizzBuzz");
    } 
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " - Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " - Fizz");
    }
    else Console.WriteLine(i);
}
```
`for` statement allows us to iterate through the code block 100 times.
`if-elseif-else` allows you to check for the divisors of 3 and 5.
`%` the mod operator allows you to determine if 3 or 5 divide into another number without a remainder.
`&&` operator ensures that a number can be divided into both 3 and 5 for the `FizzBuzz` condition.

***

### Add looping logic to your code using the do-while and while statements in C#
- The `do-while` statement iterates through a code block at least once, and may continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
- The `while` statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to `true`.
- Use the `continue` keyword to step immediately to the Boolean expression