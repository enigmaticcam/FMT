using Tesseract;

namespace FMT_Logic;

public interface IImageToText
{
    string GetText(string file);
}

public class ImageToText : IImageToText
{
    public string GetText(string file)
    {
        var text = string.Empty;
        using var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
        using var pix = Pix.LoadFromFile(file);
        using var page = engine.Process(pix);
        text = page.GetText();
        return text;
    }
}
