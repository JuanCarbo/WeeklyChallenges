using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TimCoreySolutions
{
    public class LinqStringLetters
    {
        public List<char> GetLetters(string input)
        {
            var characters = input.ToUpper().ToCharArray().OrderBy(x => x.ToString()).ToList();
            return characters;
        }
        public List<Tuple<char, int>> GetLettersAndCount(string input)
        {
            var response = new List<Tuple<char, int>>();
            var characters = input.ToUpper()
                .ToCharArray()
                .OrderBy(x => x.ToString())
                .GroupBy(x => x)
                .Select(x => new Tuple<char, int>(x.Key, x.Count())).ToList();

            return characters;
        }
    }
}
