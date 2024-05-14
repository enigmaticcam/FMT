using System;
using System.Text;

namespace FMT_Logic;

public abstract class Encrypter
{

    private List<char> _digits;
    protected List<char> GetDigits()
    {
        if (_digits == null)
        {
            var digits = Enumerable.Range(48, 9).ToList(); // 0-9
            digits.AddRange(Enumerable.Range(65, 25)); // A-Z
            digits.AddRange(Enumerable.Range(97, 25)); // a-z
            _digits = digits
                .Select(x => (char)x)
                .ToList();
        }
        return _digits;
    }

    public string RandomCypher()
    {
        var random = new Random();
        var result = new StringBuilder();
        var digits = GetDigits();

        for (int count = 1; count <= 5; count++)
        {
            var next = random.Next(0, digits.Count);
            result.Append((char)digits[next]);
        }
        return result.ToString();
    }

    public abstract string Encrypt(string cypher, string text, bool isEncrypt);
}
