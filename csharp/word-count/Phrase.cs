using System.Collections.Generic;
using System.Linq;

public class Phrase
{
  private readonly string _text;

  public Phrase(string text)
  {
    _text = text;
  }

  public Dictionary<string, int> WordCount()
  {
    return _text.Split(' ')
      .Where(word => word != string.Empty)
      .ToDictionary(word => word, x => 1);
  }
}
