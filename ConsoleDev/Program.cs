using Hashing;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
IHashing SHA1 = new SHA1Hashing();

var testData = SHA1.HashValue("Test");

Console.WriteLine(testData);

var salt = CreateSalt(32);
var saltPassword = CreatePasswordHash("Test", salt);

Console.WriteLine(saltPassword);

Console.ReadKey();


static string CreateSalt(int size)
{
    //Generate a cryptographic random number.
    RandomNumberGenerator rng = RandomNumberGenerator.Create();
    byte[] buff = new byte[size];
    rng.GetBytes(buff);

    // Return a Base64 string representation of the random number.
    return Convert.ToBase64String(buff);
}

string CreatePasswordHash(string pwd, string salt)
{
    string saltAndPwd = String.Concat(pwd, salt);

    var result = SHA1.HashValue(saltAndPwd);

    return result;
}