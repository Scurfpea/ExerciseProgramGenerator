namespace ExerciseProgramGenerator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfExercises = 12; //Should be the .Count of strings in a txt file.

            //maybe its good to be able to check how many of exercises there are of each level and each category.
            int numOfLvl1Exercises = 0;
            int numOfLvl2Exercises = 0;
            int numOfLvl3Exercises = 0;

            //"Styrke"                           
            //"Smidighed"                           
            //"Integration" 
            //"Skuldre"
            //"Hofter,"
            //"Ryg"
            //"Balance"



            Exercise[] exercise = new Exercise[numOfExercises]; //saves the exercises in a array.
            //String[] exercise = new String[numOfExercises];

            //exercise[0] = new Exercise("Three Legged Downward Facing Dog", "5", "1"); //Name, duration, level, category
            //exercise[1] = new Exercise("Lotus pose", "3", "2");
            //exercise[2] = new Exercise("Downward Facing Dog", "3", "3");
            //exercise[3] = new Exercise("Tree Pose", "3", "1");
            //exercise[4] = new Exercise("Garland Yoga Squat", "5", "2");
            //exercise[5] = new Exercise("Wide Child's Poses", "3", "3");
            //exercise[6] = new Exercise("Upward Dog", "3", "1");
            //exercise[7] = new Exercise("Pigeon Pose", "3", "2");
            //exercise[8] = new Exercise("Cow Pose", "5", "3");
            //exercise[9] = new Exercise("Bound Angle", "3", "1");
            //exercise[10] = new Exercise("Flower Pose", "3", "2");
            //exercise[11] = new Exercise("Seated Meditation Pose", "3", "3");
            SaveContentOfExercise(); //run method
            CheckLevel();

            //test
            Console.WriteLine(exercise[1].Name); //You can now access a specific content of a Exercise like its name.

            void SaveContentOfExercise() //enables the search for the right exercises based on e.g duration,lvl or category when creating a yoga program
            {
                for (int i = 0; i < exercise.Length; i++)
                {
                    //Console.WriteLine(exercise[i].MakeTitle()); //full string //THIS IS A DEBUG
                    string[] parts = exercise[i].MakeTitle().Split(';');
                    foreach (string part in parts)
                    {
                        Console.WriteLine(part); //THIS IS A DEBUG. It writes all the parts in all the exercises in the array.
                        exercise[i].Name = parts[0];
                        
                        exercise[i].Duration = parts[1];
                        
                        exercise[i].Level = parts[2];
                        
                        //exercise[i].Category = parts[3];

                    }
                }
            }

            void CheckLevel(){ //checks the level in each exercise

                for (int i = 0; i < exercise.Length; i++)
                {
                    switch (exercise[i].Level)
                {
                    case "1": //beginner
                            numOfLvl1Exercises += 1;
                        break;

                    case "2": //intermediate
                            numOfLvl2Exercises += 1;
                            break;

                    case "3": //advanced
                            numOfLvl3Exercises += 1;
                            break;

                    default:
                        break;

                }
            }
                Console.WriteLine("Number of Level1 exercises: {0} \n" +
                    "Number of Level2 exercises: {1} \n" +
                    "Number of Level3 exercises: {2}", numOfLvl1Exercises, numOfLvl2Exercises, numOfLvl3Exercises);
            }

            //void CheckCategory() //checks the category in each exercise
            //{ 

            //    for (int i = 0; i < exercise.Length; i++)
            //    {
            //        switch (exercise[i].Category)
            //        {
            //            case "Styrke": 
                            
            //                break;

            //            case "Smidighed": 
                            
            //                break;

            //            case "Integration": 
                            
            //                break;

            //            case "Skuldre": 
                            
            //                break;

            //            case "Hofter,": 
                            
            //                break;

            //            case "Ryg": 
                            
            //                break;
            //            case "Balance": 
                            
            //                break;

            //            default:
            //                break;

            //        }
            //    }
            //}

        }
    }
}