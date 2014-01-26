using System;
using System.Text;
//7. Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

class EncodingWithCipher
{
    private static string EncodePassword(string password, string key)
    {
        StringBuilder encryptedPassword = new StringBuilder(password.Length);
        int k = 0;
        for (int i = 0; i < password.Length; i++)
        {
            if (k == key.Length)
            {
                k = 0;
            }
            encryptedPassword.Append(Convert.ToChar(password[i] ^ key[k]));
            k++;
        }
        return encryptedPassword.ToString();
    }
    private static string DecodePassword(string encodedPassword, string key)
    {
        StringBuilder decodedPassword = new StringBuilder(encodedPassword.Length);
        int k = 0;
        for (int i = 0; i < encodedPassword.Length; i++)
        {
            if (k == key.Length)
            {
                k = 0;
            }
            decodedPassword.Append(Convert.ToChar(encodedPassword[i] ^ key[k]));
            k++;
        }
        return decodedPassword.ToString();
    }
    static void Main()
    {
        string password = Console.ReadLine();
        string key = Console.ReadLine();
        string encodedPassword = EncodePassword(password, key);
        string decodedPassword = DecodePassword(encodedPassword, key);
        Console.WriteLine("The encoded password is: {0}", encodedPassword);
        Console.WriteLine("The dencoded password is: {0}", decodedPassword);
    }
}
