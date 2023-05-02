namespace ExerciseProgramGenerator4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Navn", 120);
            listView1.Columns.Add("Varighed", 80);
            listView1.Columns.Add("Sværhedsgrad", 120);
            //listView1.Columns.Add("Kategori", 80);
            //listView1.Columns.Add("Blok", 80);
            //listView1.Columns.Add("Billede", 80);
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

        private void LoadButton_Click(object sender, EventArgs e)
        {
            DataHandler datahandler = new DataHandler("");
            datahandler.LoadExercise();

            string[] exerciseList = new string[]{"Downward dog", "Upward",
          "Lotus", "Flower", "Three Legged dog",
          "Cow Pose"};
            string[] duration = new string[]{"4", "5", "9",
          "5", "8", "8"};
            string[] level = new string[]{"1", "2", "1",
          "3", "2", "1"};

            for (int count = 0; count < exerciseList.Length; count++)
            {
                ListViewItem listItem = new ListViewItem(exerciseList[count]);
                listItem.SubItems.Add(duration[count]);
                listItem.SubItems.Add(level[count]);
                listView1.Items.Add(listItem);
            }
            this.Controls.Add(listView1);



            //using (var tw = new StreamWriter("Data.txt"))
            //{
            //    //foreach (ListViewItem item in listView1.Items)
            //    //{
            //    //    tw.WriteLine(item.Text);

            //    //}
            //    foreach (ListViewItem listItem in listView1.Items)
            //    {
            //        string title = $"{listItem.SubItems[0].Text};{listItem.SubItems[1].Text};{listItem.SubItems[2].Text}";
            //        tw.WriteLine(title);
            //        //could also send to exercises.
            //        //tw.WriteLine(listItem.SubItems[0].Text); //name
            //        //tw.WriteLine(listItem.SubItems[1].Text); //duration
            //        //tw.WriteLine(listItem.SubItems[2].Text); //level

            //    }

                //
                //Exercise exercise = new Exercise("", 0, 0, "");
                //StreamReader rd = new StreamReader("Data.txt");

                ////string line = rd.ReadLine(); //this reads intire line
                ////Console.WriteLine(line);

                //foreach (string line in File.ReadAllLines("Data.txt"))
                //{
                //    string[] parts = line.Split(';');
                //    foreach (string part in parts)
                //    {
                //        Console.WriteLine(part);
                //        exercise.Name = parts[0];
                //        //Write a 2nd line of text
                //        exercise.Duration = int.Parse(parts[1]);
                //        //Write a 3rd of text
                //        exercise.Level = int.Parse(parts[2]);
                //        //Write a 4th line of text
                //        exercise.Category = parts[3];

                //    }
                //}
                //rd.Close();
                //}
            }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(NameTextBox.Text);
            newItem.SubItems.Add(DurationTextBox.Text);
            newItem.SubItems.Add(LevelTextBox.Text);
            listView1.Items.Add(newItem);
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
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (var tw = new StreamWriter("Data.txt"))
            {
                //foreach (ListViewItem item in listView1.Items)
                //{
                //    tw.WriteLine(item.Text);

                //}
                foreach (ListViewItem listItem in listView1.Items)
                {
                    string title = $"{listItem.SubItems[0].Text};{listItem.SubItems[1].Text};{listItem.SubItems[2].Text}";
                    tw.WriteLine(title);
                    //could also send to exercises.
                    //tw.WriteLine(listItem.SubItems[0].Text); //name
                    //tw.WriteLine(listItem.SubItems[1].Text); //duration
                    //tw.WriteLine(listItem.SubItems[2].Text); //level
                    
                }

                //foreach (ListViewItem subItem in listView1.Items)
                //{
                //    //tw.WriteLine(listView1.SelectedItems[0].SubItems[0].Text);

                //}
                //Working same same
                //for (int i = 0; i < listView1.Items.Count; i++)
                //{
                //    //tw.WriteLine(listView1.Items[i].Text);

                //    //tw.WriteLine(listView1.SelectedItems[i].SubItems[i].Text);


                //}
            }
        }

        private void GenerateProgram_Click(object sender, EventArgs e)
        {
            //________________________________
            //take data from file
            //var lineCount = File.ReadLines(@"Data.txt").Count();
            //Exercise[] exercise = new Exercise[lineCount]; //saves the exercises in a array. length of arr is number of lines in txt file.
            //________________________________
            //take data from list
            Exercise[] exercise = new Exercise[listView1.Items.Count]; //saves the exercises in a array. length of arr is number of lines in txt file.
            foreach (ListViewItem listItem in listView1.Items)
            {
                for (int i = 0; i < exercise.Count(); i++)
                {
                    exercise[i] = new Exercise("{listItem.SubItems[0].Text}", "{listItem.SubItems[1].Text}", "{ listItem.SubItems[2].Text }"); //Name, duration, level, category
                }
                //could also send to exercises.
                //tw.WriteLine(listItem.SubItems[0].Text); //name
                //tw.WriteLine(listItem.SubItems[1].Text); //duration
                //tw.WriteLine(listItem.SubItems[2].Text); //level

            }
            
                                                           //String[] exercise = new String[numOfExercises];
            
        }
    }
}