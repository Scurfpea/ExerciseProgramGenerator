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
    public partial class UserControl3 : UserControl
    {
        Controller controller = new Controller();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void GenerateProgram_Click(object sender, EventArgs e)
        {
            controller.lvl = LevelProgramtextBox.Text;
            controller.timeLeft = int.Parse(DurationProgramTextBox.Text);
            controller.GenerateProgram();


            StreamReader rd = new StreamReader("Data2.txt");

            foreach (string line in File.ReadAllLines("Data2.txt"))
            {
                string[] parts = line.Split(';');

                ListViewItem listItem = new ListViewItem(parts[0]);
                listItem.SubItems.Add(parts[1]);
                listItem.SubItems.Add(parts[2]);
                listView2.Items.Add(listItem);
            }

            rd.Close();

            this.Controls.Add(listView2);
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            listView2.Columns.Add("Navn", 120);
            listView2.Columns.Add("Varighed", 80);
            listView2.Columns.Add("Sværhedsgrad", 120);
            listView2.Columns.Add("Blok", 80);
        }

        private void NewProgram_Click(object sender, EventArgs e)
        {
            //TextBox.Text = ""; //removes the typed in content
            DurationProgramTextBox.Text = "";
            LevelProgramtextBox.Text = "";

            listView2.Items.Clear();
            controller.ClearProgram();
        }
    }
}
