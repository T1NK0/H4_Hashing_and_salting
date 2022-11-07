﻿using Hashing;
using System.Security.Cryptography;
using System.Text;

IHashing Hashings = new Hashings();

Console.WriteLine("Write a text to hash:");
string userInput = Console.ReadLine();

Console.WriteLine("\nMake a key (leave blank for no key):");
string userKey = Console.ReadLine();

Console.WriteLine("Choose encryption \n" +
    "1. SHA1\n" +
    "2. SHA256\n" + 
    "3. MD5\n"
);

string userEncryptionType = Console.ReadLine().ToLower();

string convertedTextHashedValue = null;
string convertedKeyHashedValue = null;

switch (userEncryptionType)
{
    case "1":
        convertedKeyHashedValue = String.Concat(userInput, userKey);
        convertedTextHashedValue = Hashings.SHA1HashValue(convertedKeyHashedValue);

        break;
    case "2":
        convertedKeyHashedValue = String.Concat(userInput, userKey);
        convertedTextHashedValue = Hashings.SHA256HashValue(convertedKeyHashedValue);
        break;    
    case "3":
        convertedKeyHashedValue = String.Concat(userInput, userKey);
        convertedTextHashedValue = Hashings.MD5HashValue(convertedKeyHashedValue);
        break;
    default:
        break;
}

Console.WriteLine("Is this validation y/n");

if (Console.ReadLine() == "y")
{
    Console.WriteLine("Write the hashed text");

    string UserInputHashedValue = Console.ReadLine();


    if(UserInputHashedValue == convertedTextHashedValue)
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
}