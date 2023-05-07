using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProgramGenerator4
{
    public class Controller
    {
        public List<Exercise> ExcerciseList = new List<Exercise>();

        public List<Exercise> ExcerciseProgramList = new List<Exercise>();

        public List<Exercise> GeneratedProgramList = new List<Exercise>();

        public List<Exercise> ExcerciseListMiddle = new List<Exercise>(); //1 = middle

        public List<Exercise> ExcerciseListCoolDown = new List<Exercise>(); //2 = cooldown
        List<Exercise> exerciseAll = new List<Exercise>(); //2 = cooldown

        public int timeLeft = 30; //
        int currentExerciseDuration = 0;
        Exercise[] exercise;
        int numOfLvl1Exercises = 0;
        int numOfLvl2Exercises = 0;
        int numOfLvl3Exercises = 0;
        public string lvl;

        public void GenerateProgram()
        {
            StreamWriter sw = new StreamWriter("Data2.txt");
            //________________________________
            //take data from file
            // var lineCount = File.ReadLines(@"Data.txt").Count();
            //Exercise[] exercise = new Exercise[lineCount]; //saves the exercises in a array. length of arr is number of lines in txt file.
            //________________________________
            //take data from list
            //exercise = new Exercise[listView1.Items.Count]; //saves the exercises in a array. length of arr is number of lines in txt file.
            bool hasSaved = false;
            //foreach (ListViewItem listItem in listView1.Items)
            {
                var lineCount = File.ReadLines(@"Data.txt").Count();
                foreach (string line in File.ReadAllLines("Data.txt"))
                {

                    //Exercise[] exercise = new Exercise[lineCount];
                    string[] parts = line.Split(';');
                    foreach (string part in parts)
                    {

                        if (!hasSaved)
                        { //solves issue of it running 3 times
                            
                            exerciseAll.Add(new Exercise($"{parts[0]}", $"{parts[1]}", $"{parts[2]}")); //Name, duration, level, category

                            ////delete this later, just for debug
                            //sw.WriteLine(exerciseAll); //level
                            //sw.WriteLine(exerciseAll[].Duration); //duration
                            //sw.WriteLine(exercise[i].Level); //level

                            //ExcerciseList.Add(exercise[i]);
                                hasSaved = true;
                                break;

                        }
                        if (hasSaved)
                        {
                            hasSaved = false;
                        }
                    }

                }





                for (int i = 0; i < exerciseAll.Count; i++)
                {


                    currentExerciseDuration = int.Parse(exerciseAll[i].Duration);
                    if (exerciseAll[i].Level == lvl) //
                    {

                        //if((ExcerciseList[i]. == blok))
                        //if (timeLeft > 0)//if (timeLeft > timeLeft - currentExerciseDuration)
                        //{ //checks if there enough time left in yogaprogram

                        ExcerciseProgramList.Add(exerciseAll[i]); //adds this exercise to the list
                                                                    //timeLeft -= currentExerciseDuration; //Removing the time the exercise takes from the total time.
                                                                    // }
                                                                    //else 

                        //timeLeft = 0;

                    }
                }
                CountNumOfEachExercisesLvl();
                FindRandomExercise();
                //Below is Debug
                //sw.WriteLine("Number of Level1 exercises: {0} \n" +
                //    "Number of Level2 exercises: {1} \n" +
                //    "Number of Level3 exercises: {2}", numOfLvl1Exercises, numOfLvl2Exercises, numOfLvl3Exercises);
                //sw.WriteLine(timeLeft);
                //make program


                //for (int i = 0; i < ExcerciseProgramList.Count(); i++)
                //{

                //    sw.WriteLine(ExcerciseProgramList[i].Name); //level
                //    sw.WriteLine(ExcerciseProgramList[i].Duration); //duration
                //    sw.WriteLine(ExcerciseProgramList[i].Level); //level
                //}
                for (int i = 0; i < GeneratedProgramList.Count(); i++)
                {

                    sw.WriteLine($"{GeneratedProgramList[i].Name};{GeneratedProgramList[i].Duration};{GeneratedProgramList[i].Level}"); //level
                    
                }

                sw.Close();
            }
        }

        private void FindRandomExercise()
        {
            for (int i = 0; i < ExcerciseProgramList.Count; i++) //run though list of all possible exercises.
            {
                //GeneratedProgramList
                int rand = new Random().Next(0, ExcerciseProgramList.Count() - 1); //to find a random exercise
                                                                                   //if((ExcerciseList[i]. == blok))
                if (timeLeft > 0)//if (timeLeft > timeLeft - currentExerciseDuration)
                { //checks if there enough time left in yogaprogram
                    if (GeneratedProgramList.Contains(ExcerciseProgramList[rand]) != true) //new checks if its already there
                    {
                        GeneratedProgramList.Add(ExcerciseProgramList[rand]); //adds this exercise to the list
                        currentExerciseDuration = int.Parse(ExcerciseProgramList[rand].Duration);
                        timeLeft -= currentExerciseDuration; //Removing the time the exercise takes from the total time.
                    }
                }
                else

                    timeLeft = 0;
            }
        }
        private void CountNumOfEachExercisesLvl()
        {

            for (int i = 0; i < exerciseAll.Count; i++)
            {
                switch (exerciseAll[i].Level) //should be the level given by the user.
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
        }
    }
}
