using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseProgramGenerator4
{

    public partial class UserControl2 : UserControl
    {
        Controller controller = new Controller();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void UserControl2_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Navn", 120);
            listView1.Columns.Add("Varighed", 80);
            listView1.Columns.Add("Sværhedsgrad", 120);
            listView1.Columns.Add("Blok", 80);
            //listView1.Columns.Add("Blok", 80);
            //listView1.Columns.Add("Billede", 80);
            LoadExercises(); //load exercises at startup
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

        private void NewButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = ""; //removes the typed in content
            DurationTextBox.Text = "";
            LevelTextBox.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(NameTextBox.Text);
            newItem.SubItems.Add(DurationTextBox.Text);
            newItem.SubItems.Add(LevelTextBox.Text);
            listView1.Items.Add(newItem);
            SaveExercises();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                NameTextBox.Text = listView1.SelectedItems[0].SubItems[0].Text; //Can now select the items on the list view.
                DurationTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
                LevelTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;

            }
        }
    }
}
