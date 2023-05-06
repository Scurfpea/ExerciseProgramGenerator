namespace ExerciseProgramGenerator4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Exercise> ExcerciseList = new List<Exercise>();

        public List<Exercise> ExcerciseProgramList = new List<Exercise>();

        public List<Exercise> GeneratedProgramList = new List<Exercise>();

        public List<Exercise> ExcerciseListMiddle = new List<Exercise>(); //1 = middle

        public List<Exercise> ExcerciseListCoolDown = new List<Exercise>(); //2 = cooldown

        int timeLeft = 30; //
        int currentExerciseDuration = 0;
        Exercise[] exercise;
        int numOfLvl1Exercises = 0;
        int numOfLvl2Exercises = 0;
        int numOfLvl3Exercises = 0;


        //public List<YogaProgram> YogaProgramList = new List<YogaProgram>();
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Navn", 120);
            listView1.Columns.Add("Varighed", 80);
            listView1.Columns.Add("Sværhedsgrad", 120);
            listView1.Columns.Add("Blok", 80);
            //listView1.Columns.Add("Blok", 80);
            //listView1.Columns.Add("Billede", 80);
            LoadExercises(); //load exercises at startup
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                NameTextBox.Text = listView1.SelectedItems[0].SubItems[0].Text; //Can now select the items on the list view.
                DurationTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                LevelTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;

            }
        }
        private void LoadExercises()
        {
            StreamReader rd = new StreamReader("Data.txt");

            foreach (string line in File.ReadAllLines("Data.txt"))
            {
                string[] parts = line.Split(';');

                ListViewItem listItem = new ListViewItem(parts[0]);
                listItem.SubItems.Add(parts[1]);
                listItem.SubItems.Add(parts[2]);
                listView1.Items.Add(listItem);
            }

            rd.Close();

            this.Controls.Add(listView1);
        }
        private void SaveExercises()
        {
            using (var tw = new StreamWriter("Data.txt"))
            {
                foreach (ListViewItem listItem in listView1.Items)
                {
                    string title = $"{listItem.SubItems[0].Text};{listItem.SubItems[1].Text};{listItem.SubItems[2].Text}";
                    tw.WriteLine(title);
                }
            }
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            //LoadExercises();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(NameTextBox.Text);
            newItem.SubItems.Add(DurationTextBox.Text);
            newItem.SubItems.Add(LevelTextBox.Text);
            listView1.Items.Add(newItem);
            SaveExercises();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = ""; //removes the typed in content
            DurationTextBox.Text = "";
            LevelTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = NameTextBox.Text;
                listView1.SelectedItems[0].SubItems[1].Text = DurationTextBox.Text;
                listView1.SelectedItems[0].SubItems[2].Text = LevelTextBox.Text;
            }
            SaveExercises();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            SaveExercises();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveExercises();

        }

        private void GenerateProgram_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Data2.txt");
            //________________________________
            //take data from file
            //var lineCount = File.ReadLines(@"Data.txt").Count();
            //Exercise[] exercise = new Exercise[lineCount]; //saves the exercises in a array. length of arr is number of lines in txt file.
            //________________________________
            //take data from list
            exercise = new Exercise[listView1.Items.Count]; //saves the exercises in a array. length of arr is number of lines in txt file.
            bool hasSaved = false;
            foreach (ListViewItem listItem in listView1.Items)
            {
                for (int i = 0; i < exercise.Count(); i++)
                {

                    if (!hasSaved)
                    { //solves issue of it running 3 times
                        exercise[i] = new Exercise($"{listItem.SubItems[0].Text}", $"{listItem.SubItems[1].Text}", $"{listItem.SubItems[2].Text}"); //Name, duration, level, category

                        //delete this later, just for debug
                        sw.WriteLine(exercise[i].Name); //level
                        sw.WriteLine(exercise[i].Duration); //duration
                        sw.WriteLine(exercise[i].Level); //level

                        ExcerciseList.Add(exercise[i]);
                        hasSaved = true;
                        break;

                    }
                    if (hasSaved)
                    {
                        hasSaved = false;
                    }
                }

            }
          

            for (int i = 0; i < ExcerciseList.Count; i++)
            {
                string lvl = LevelProgramtextBox.Text;

                currentExerciseDuration = int.Parse(ExcerciseList[i].Duration);
                if (ExcerciseList[i].Level == lvl) //
                {
                    
                    //if((ExcerciseList[i]. == blok))
                    //if (timeLeft > 0)//if (timeLeft > timeLeft - currentExerciseDuration)
                    //{ //checks if there enough time left in yogaprogram

                        ExcerciseProgramList.Add(ExcerciseList[i]); //adds this exercise to the list
                        //timeLeft -= currentExerciseDuration; //Removing the time the exercise takes from the total time.
                   // }
                    //else 
                            
                        //timeLeft = 0;
                    
                }               
            }
            CountNumOfEachExercisesLvl();
            FindRandomExercise();
            sw.WriteLine("Number of Level1 exercises: {0} \n" +
                "Number of Level2 exercises: {1} \n" +
                "Number of Level3 exercises: {2}", numOfLvl1Exercises, numOfLvl2Exercises, numOfLvl3Exercises);
            sw.WriteLine(timeLeft);
            //make program
            
            sw.WriteLine("ProgramList");
            //for (int i = 0; i < ExcerciseProgramList.Count(); i++)
            //{

            //    sw.WriteLine(ExcerciseProgramList[i].Name); //level
            //    sw.WriteLine(ExcerciseProgramList[i].Duration); //duration
            //    sw.WriteLine(ExcerciseProgramList[i].Level); //level
            //}
            for (int i = 0; i < GeneratedProgramList.Count(); i++)
            {

                sw.WriteLine(GeneratedProgramList[i].Name); //level
                sw.WriteLine(GeneratedProgramList[i].Duration); //duration
                sw.WriteLine(GeneratedProgramList[i].Level); //level
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

                    GeneratedProgramList.Add(ExcerciseProgramList[rand]); //adds this exercise to the list
                    currentExerciseDuration = int.Parse(ExcerciseProgramList[rand].Duration);
                    timeLeft -= currentExerciseDuration; //Removing the time the exercise takes from the total time.
                }
                else

                    timeLeft = 0;
            }
        }
        private void CountNumOfEachExercisesLvl()
        {
            
            for (int i = 0; i < exercise.Length; i++)
            {
                switch (ExcerciseList[i].Level) //should be the level given by the user.
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
        private void SaveProgram_Click(object sender, EventArgs e)
        {

        }
    }
}