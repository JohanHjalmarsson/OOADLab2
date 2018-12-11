using System;
using System.Collections.Generic;
using OOADLab2.Models;

namespace OOADLab2.Services
{
    public class RandomNiceWordGenerator
    {
        private List<NiceWord> words;
        public RandomNiceWordGenerator()
        {
            words = new List<NiceWord>();
            AddWords();
        }

        private void AddWords()
        {
            words.Add(new NiceWord("fin"));
            words.Add(new NiceWord("snäll"));
            words.Add(new NiceWord("underbar"));
            words.Add(new NiceWord("härlig"));
            words.Add(new NiceWord("superstark"));
            words.Add(new NiceWord("en bra kompis"));
        }

        public string GetRandomNiceWord()
        {
            Random r = new Random();
            int index = r.Next(0, words.Count - 1);
            return words[index].Word;
        }
    }
}
