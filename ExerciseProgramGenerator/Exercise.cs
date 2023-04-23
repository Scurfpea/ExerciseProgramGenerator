using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExerciseProgramGenerator
{
    public class Exercise
    {
        public string Name
        {
            get; set;             
        }
        public int Duration
        {
            get; set;
        }

        public int Level
        {
            get; set;
        }
        public string Category
        {
            get; set;
        }

        public Exercise(string name, int duration, int level, string category)
        {
            Name = name;
            Duration = duration;
            Level = level;
            Category = category;
        }
        public string MakeTitle()
        {
            string title = String.Format("{0};{1};{2};{3};{4}", Name, Duration, Level, Category); //String.Format converts to string

            return title;
        }

    }
}
