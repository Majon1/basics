using System.Collections.Generic;

namespace Exercise
{
  public class DictionaryOfManyTranslations
  {
    private Dictionary<string, List<string>> register; 
   public DictionaryOfManyTranslations()
   {
     this.register = new Dictionary<string, List<string>>();
   }
    public void Add(string word, string translation)
    {
      if (!this.register.ContainsKey(word))
      {
        this.register.Add(word, new List<string>());
      }
      this.register[word].Add(translation);
    }

    public List<string> Translate(string word)
    {
      if (this.register.ContainsKey(word))
      {
        return this.register[word];
      }
      else
      {
      return new List<string>();
      }
    }
    public void Remove(string word)
    {
    this.register.Remove(word);
    }
  }
}
