using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveCalculator.Algorithms
{
    public class LoveAlgorithm
    {
        public string Comment(int percentage)
        {
            if(percentage < 25)
            {
                return "Jullie zijn echt niet gemaakt voor elkaar!";
            } else if(percentage < 50)
            {
                return "Met veel werk langs beide kanten zou dit nog iets kunnen worden...";
            } else if(percentage < 75)
            {
                return "Hier zou iets moois kunnen bloeien!";
            } else
            {
                return "Jullie zijn perfect voor elkaar gemaakt!";
            }
        }
        public int Calculate(string a, string b)
        {
            Random rand = new Random();
            int love = rand.Next(0, 101);
            return love;
        }
    }
}
