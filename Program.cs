using System;
using System.Text;

Console.Clear();
Console.WriteLine("GERADOR DE SENHAS");
Console.WriteLine("Quantos caracteres?");
var chars = int.Parse(Console.ReadLine());

Console.WriteLine("Incluir caracteres especiais? (true|false)");
var includeSpecialChars = bool.Parse(Console.ReadLine());

Console.WriteLine("Gerar tudo em maiúsculo? (true|false)");
var onlyUppercase = bool.Parse(Console.ReadLine());

Console.WriteLine(Generate(chars, includeSpecialChars, onlyUppercase));

string Generate(int length = 12, bool includeSpecialChars = true, bool onlyUpperCase = false)
{
    const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
    const string special = "!@#$%ˆ&*(){}[];";
    var chars = includeSpecialChars ? (valid + special) : valid;
    var res = new StringBuilder();
    var rnd = new Random();
    while (0 < length--)
        res.Append(chars[rnd.Next(chars.Length)]);
    return onlyUpperCase ? res.ToString().ToUpper() : res.ToString();
}