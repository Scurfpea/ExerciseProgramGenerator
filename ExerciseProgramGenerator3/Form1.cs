using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ExerciseProgramGenerator3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e) //Add the content from the Text boxes to the listView.
        {
            ListViewItem newItem = new ListViewItem(NameTextBox.Text);
            newItem.SubItems.Add(DurationTextBox.Text);
            newItem.SubItems.Add(LevelTextBox.Text);
            listView1.Items.Add(newItem);


        }

        private void NewButton_Click(object sender, EventArgs e) //Clears input fields for new inputs.
        {
            NameTextBox.Text = ""; //removes the typed in content
            DurationTextBox.Text = "";
            LevelTextBox.Text = "";

        }

        private void UpdateButton_Click(object sender, EventArgs e) //Take the content from the input fields and overates the selected listview item.
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

        private void Form1_Load(object sender, EventArgs e) //Creates columns with name and length.
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

        private void Save_Click(object sender, EventArgs e) //Saves all the items in the listview in txt file.
        {
            using (var tw = new StreamWriter("Data.txt"))
            {
                //foreach (ListViewItem item in listView1.Items)
                //{
                //    tw.WriteLine(item.Text);

                //}
                foreach (ListViewItem listItem in listView1.Items)
                {
                    //could also send to exercises.
                    tw.WriteLine(listItem.SubItems[0].Text); //name
                    tw.WriteLine(listItem.SubItems[1].Text); //duration
                    tw.WriteLine(listItem.SubItems[2].Text); //level

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

        private void LoadButton_Click(object sender, EventArgs e) //Loads this data into the listview.
        {
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
        }
    }
}




