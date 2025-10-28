using System.Text;

namespace BasicTranslator;

public abstract class TranslatorBase
{
    protected abstract Dictionary<string, string> Dictionary { get; }

    public void Translate(string rawText)
    {
        char[ ] punctuation = { ',', '.', '?', '!' };
        StringBuilder sb = new();

        List<string> splitText = rawText.Split(' ').ToList();

        foreach (var key in splitText)
        {
            if (key.Any(c => punctuation.Contains(c)))
            {
                if (Dictionary.TryGetValue(key.Trim(punctuation), out string value))
                {
                    sb.Append(AppendPunctuation(value, key.Last()));
                }
                else
                {
                    sb.Append(AppendPunctuation(key, '('));
                }
            }
            else if (Dictionary.TryGetValue(key, out string value))
            {
                sb.Append(' ').Append(value);
            }
            else
            {
                sb.Append(AppendPunctuation(key, '('));
            }
        }

        Console.WriteLine(sb.ToString().TrimStart(' '));
    }

    protected string AppendPunctuation(string word, char punctuation) =>
        punctuation.Equals('(')
                    ? $" ({word})"
                    : $" {word}{punctuation}";
}
