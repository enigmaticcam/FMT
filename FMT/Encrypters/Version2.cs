using System.Text;

namespace FMT_Logic.Encrypters;

public class Version2 : Encrypter
{
    public override string Encrypt(string cypher, string text, bool isEncrypt)
    {
        var digitHash = new HashSet<char>(GetDigits());
        var digitList = new List<char>(digitHash);
        int num = 0;
        int cypherIndex = 0;
        var result = new StringBuilder();
        foreach (var digit in text)
        {
            if (!digitHash.Contains(digit))
            {
                result.Append(digit);
            } else
            {
                num += (int)cypher[cypherIndex];
                cypherIndex = (cypherIndex + 1) % cypher.Length;
                var index = digitList.IndexOf(digit);
                if (isEncrypt)
                {
                    index += num;
                } else
                {
                    index -= num;
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
