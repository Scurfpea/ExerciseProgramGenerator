using System;

namespace ExerciseProgramGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise("Downward Dog", 3, 1, "Leg");
            Exercise exercise2 = new Exercise("Upward Dog", 3, 1, "Leg");

            

            DataHandler handler = new DataHandler("Data.txt");
            handler.SaveExercise(exercise);
            handler.SaveExercise(exercise2);
            handler.LoadExercise();

            Console.Write("Writing Exercise: ");
            Console.WriteLine(exercise.MakeTitle());

            Console.ReadLine();
        }
    }
}