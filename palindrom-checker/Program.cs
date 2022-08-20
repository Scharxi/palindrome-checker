using System.Text.RegularExpressions;

string ReplaceAllSpecialCharacters(ref string input)
{
    var reg = new Regex("[!+-/*'\",_&#^\\\\@$]");
    return reg.Replace(input, string.Empty);
}

Tuple<string, bool> IsPalindrome(string input)
{
    var str = ReplaceAllSpecialCharacters(ref input);
    return Tuple.Create(str, string.Equals(str, string.Join("", str.Reverse().ToList()), StringComparison.OrdinalIgnoreCase));
}

Console.Write("Input the word you want to check: ");
Console.WriteLine($"Palindrome: {IsPalindrome(Console.ReadLine() ?? throw new InvalidOperationException()).Item2}");