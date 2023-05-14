using System;
using System.Collections.Generic;
using System.IO;
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

        private void SaveAllExercises()
        {
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
            }
        }
        public void ClearProgram()
        {
            
            GeneratedProgramList.Clear();
            ExcerciseProgramList.Clear();
            
            //File.WriteAllText("Data2.txt", String.Empty); Another solution to clear file
            File.Create("Data2.txt").Close(); //clear file
        }
        public void GenerateProgram()
        {
            
            SaveAllExercises();
            StreamWriter sw = new StreamWriter("Data2.txt");                       

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
                //CountNumOfEachExercisesLvl();
                FindRandomExercise();
                
                
                for (int i = 0; i < GeneratedProgramList.Count(); i++)
                {

                    sw.WriteLine($"{GeneratedProgramList[i].Name};{GeneratedProgramList[i].Duration};{GeneratedProgramList[i].Level}"); //level
                    
                }

                sw.Close();
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
            if (timeLeft >= currentExerciseDuration +3)
            {
                GeneratedProgramList.RemoveAt(0);
            }
        }
        
    }
}
