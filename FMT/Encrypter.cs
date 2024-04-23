using System;
using System.Text;

namespace FMT_Logic;

public class Encrypter
{

    private List<char> _digits;
    private List<char> GetDigits()
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

    public string Encrypt(string cypher, string text, bool isEncrypt)
    {
        var digitHash = new HashSet<char>(GetDigits());
        var digitList = new List<char>(digitHash);
        var num = cypher.Aggregate(1, (a, b) => a + b);
        var random = new Random(num);
        var result = new StringBuilder();
        foreach (var digit in text)
        {
            if (!digitHash.Contains(digit))
            {
                result.Append(digit);
            } 
            else
            {
                var next = random.Next(0, digitHash.Count);
                var index = digitList.IndexOf(digit);
                if (isEncrypt)
                {
                    index += next;
                }
                else
                {
                    index -= next;
                }
                while (index < 0)
                    index += digitList.Count;
                index %= digitList.Count;
                result.Append(digitList[index]);
            }
        }
        return result.ToString();
    }
}
