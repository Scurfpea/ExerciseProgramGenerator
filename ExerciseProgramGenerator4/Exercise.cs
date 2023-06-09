﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProgramGenerator4
{
    public class Exercise
    {
        public string Name
        {
            get; set;
        }
        public string Duration
        {
            get; set;
        }

        public string Level
        {
            get; set;
        }
        //public string Category
        //{
        //    get; set;
        //}

        public Exercise(string name, string duration, string level)
        {
            Name = name;
            Duration = duration;
            Level = level;
            //Category = category;
        }
        public string MakeTitle()
        {
            string title = String.Format("{0};{1};{2}", Name, Duration, Level); //String.Format converts to string

            return title;
        }
    }
}
