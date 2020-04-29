namespace Exercise
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    public class SaveableDictionary
    {
        private Dictionary<string, string> directory;
        private string file;
        public SaveableDictionary()
        {
            this.directory = new Dictionary<string, string>();
        }

        public SaveableDictionary(string file) : this()
        {
            this.file = file;
        }

        public void Add(string word, string translation)
        {
            if (!this.directory.ContainsKey(word))
            {
                this.directory.Add(word, translation);
                this.directory.Add(translation, word);
            }
        }

        public bool Load()
        {
            try
            {
                string[] lines = File.ReadAllLines(this.file);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    string word = parts[0];
                    string translation = parts[1];
                    Add(word, translation);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool Save()
        {
            List<string> alreadySaved = new List<string>();
            try
            {
              StreamWriter sw = new StreamWriter(this.file);
              foreach (string word in this.directory.Keys)
              {
                string composition = word + ":" + this.directory[word];
                string backwards = this.directory[word] + ":" + word;
                if (!alreadySaved.Contains(composition) && !alreadySaved.Contains(backwards))
                {
                  alreadySaved.Add(composition);
                  sw.WriteLine(composition);
                }
              }
              sw.Close();
              return true;
            }
            catch (Exception e)
            {
              Console.WriteLine(e.Message);
              return false;
            }
        }

        public string Translate(string word)
        {
            if (this.directory.ContainsKey(word))
            {
                return this.directory[word];
            }
            else
            {
                return null;
            }
        }

        public void Delete(string word)
        {
            if (this.directory.ContainsKey(word))
            {
                string translation = this.directory[word];
                this.directory.Remove(word);
                this.directory.Remove(translation);
            }
        }
    }
}