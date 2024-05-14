using FMT_Logic.Encrypters;

namespace FMT_Logic;

public class Factory
{
    public static Encrypter CreateEncrypter()
    {
        return new Version2();
    }
}
