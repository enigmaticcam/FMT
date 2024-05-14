using System.Text;

namespace FMT_Logic.Encrypters;

public class Version1 : Encrypter
{
    public override string Encrypt(string cypher, string text, bool isEncrypt)
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
            } else
            {
                var next = random.Next(0, digitHash.Count);
                var index = digitList.IndexOf(digit);
                if (isEncrypt)
                {
                    index += next;
                } else
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
