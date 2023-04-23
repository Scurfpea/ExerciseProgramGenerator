using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProgramGenerator
{
    public class DataHandler
    {
        private string dateFileName;
        public string DataFileName
        {
            get => dateFileName;
        }

        public DataHandler(string dataFileName)
        {
            this.dateFileName = dataFileName;
        }

        public void SaveExercise(Exercise exercise)
        {
            StreamWriter sw = new StreamWriter("Data.txt");

            sw.WriteLine(exercise.MakeTitle());
            
            /*
             //Can be split up if you wanted to..
             //Write a line of text
             sw.WriteLine(exercise.Name);
             //Write a 2nd line of text
             sw.WriteLine(exercise.Duration);
             //Write a 3rd of text
             sw.WriteLine(exercise.Level);
             //Write a 4th line of text
             sw.WriteLine(exercise.Category); 
             */
            
            //Close the file
            sw.Close();

        }

        public Exercise LoadExercise()
        {
            Exercise exercise = new Exercise("", 0, 0, "");
            StreamReader rd = new StreamReader("Data.txt");

            //string line = rd.ReadLine(); //this reads intire line
            //Console.WriteLine(line);

            foreach (string line in File.ReadAllLines("Data.txt"))
            {
                string[] parts = line.Split(';');
                foreach (string part in parts)
                {
                    Console.WriteLine(part);
                    exercise.Name = parts[0];
                    //Write a 2nd line of text
                    exercise.Duration = int.Parse(parts[1]);
                    //Write a 3rd of text
                    exercise.Level = int.Parse(parts[2]);
                    //Write a 4th line of text
                    exercise.Category = parts[3];
                    
                }
            }
            rd.Close();
            return exercise;
        }


    }
}
