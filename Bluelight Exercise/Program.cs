// ================================================================
// See FactorChecker.cs for method logic
// ================================================================

using Bluelight_Exercise;

// Declarations
int start = 0;
int end = 0;
int divisor = 0;

int input;

// Header text
Console.WriteLine("Simple factor checker");
Console.WriteLine("Written by Angelo Loveranes for Bluelight CRM interview");
Console.WriteLine("================================================================");

// Get start
Console.WriteLine("Please enter a starting integer (inclusive):");
start = Convert.ToInt32(Console.ReadLine());

// Get end
Console.WriteLine("Please enter an ending integer (inclusive):");
end = Convert.ToInt32(Console.ReadLine());
// Validate end
while (end <= start)
{
    Console.WriteLine("End value must be greater than start, please enter a different end value:");
    end = Convert.ToInt32(Console.ReadLine());
}

// Get divisor
Console.WriteLine("Please enter a divisor:");
divisor = Convert.ToInt32(Console.ReadLine());
// Validate divisor
while (divisor <= 0)
{
    Console.WriteLine("Divisor cannot be zero or negative; please enter a different divisor:");
    divisor = Convert.ToInt32(Console.ReadLine());
}

// Print methods
Console.WriteLine("");
Console.WriteLine("================================================================");
Console.WriteLine("Method 1 - via modulus division:");
Console.WriteLine("Method 2 - via non-modulus division:");
Console.WriteLine("Method 3 - without division:");

// Prompt method selection
Console.WriteLine("\nSelect a method:");
input = Convert.ToInt32(Console.ReadLine());

// Initialize class then execute selected method
Console.WriteLine("================================================================");
FactorChecker factorChecker = new FactorChecker(start, end, divisor);
//Console.WriteLine($"\nFound range: {string.Join(", ", factorChecker.Range.ToArray())}");
switch(input)
{
    case 1:
        factorChecker.Method1();
        break;
    case 2:
        factorChecker.Method2();
        break;
    case 3:
        factorChecker.Method3();
        break;
    default:
        Console.WriteLine("Input not recognized; press any key to exit...");
        Console.ReadKey();
        break;
}
Console.ReadKey();