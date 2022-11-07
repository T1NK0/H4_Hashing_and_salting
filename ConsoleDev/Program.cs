using Hashing;
using System.Security.Cryptography;
using System.Text;

IHashing SHA1 = new SHA1Hashing();

Console.WriteLine("Write a text to hash:");
string userInput = Console.ReadLine();

Console.WriteLine("Choose encryption \n" +
    "1. SHA1\n" +
    "2. SHA1 with key\n"
);

string userEncryptionType = Console.ReadLine().ToLower();

string convertedTextHashedValue = null;
string convertedKeyHashedValue = null;

switch (userEncryptionType)
{
    case "1":
        convertedTextHashedValue = SHA1.HashValue(userInput);
        break;
    case "2":
        Console.WriteLine("\nMake a key:");
        string userKey = Console.ReadLine();
        convertedTextHashedValue = SHA1.HashValue(userInput);
        convertedKeyHashedValue = SHA1.HashSalt(userInput, userKey);
        break;
    default:
        break;
}


Console.WriteLine("Is this validation Y/N");

if (Console.ReadLine() == "y")
{
    Console.WriteLine("Write the hashed text");

    string UserInputHashedValue = Console.ReadLine();


    if(UserInputHashedValue == SHA1.HashValue(userInput))
    {
        Console.WriteLine("It's a match!");
    } else
    {
        Console.WriteLine("That ain't right!");
    }
}
else
{
    Console.WriteLine("Your text hashed is:\n" + convertedTextHashedValue);
    if (convertedKeyHashedValue != null)
    {
        Console.WriteLine("Your hashed key is: \n" + convertedKeyHashedValue);
    }
}