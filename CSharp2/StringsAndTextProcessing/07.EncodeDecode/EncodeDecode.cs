// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
// the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
class EncodeDecode
{
    static void Main()
    {
        
        const string key = "dragon";
        const string value = "password";
        string encrypted = Encrypt("password",key);
        string decrypted = Decrypt(encrypted, key);

        Console.WriteLine("Encrypted value {0} by key {1} is {2} ",value, key, encrypted);
        Console.WriteLine("Decrypted value {0} by key {1} is {2}", encrypted, key, decrypted);
    }

    private static string Encrypt(string value, string key)
    {
        if (string.IsNullOrEmpty(value.Trim()))
        {
            throw new ArgumentException("Invalid argument content.", "valie");

        }
        if (string.IsNullOrEmpty(key.Trim()))
        {
            throw new ArgumentException("Invalid argument content.", "key");
        }
        if (key.Length < value.Length)
        {
            key = GetFullKey(key, value.Length);
        }
        var encryptedChars = new char[value.Length];
        for (int i = 0; i < value.Length; i++)
        {
            encryptedChars[i] = (char)(value[i] ^ key[i]);
        }
        return new string(encryptedChars);
    }
    public static string Decrypt(string value, string key)
    {
        return Encrypt(value, key);
    }
    private static string GetFullKey(string key, int size)
    {
        if (key.Length >= size)
        {
            return key;
        }
        char[] keyArray = key.ToCharArray();
        Array.Resize(ref keyArray, size);
        for (int i = key.Length; i < size; i++)
        {
            keyArray[i] = keyArray[i - key.Length];
        }
        key = new string(keyArray);
        return key;
    }
}

