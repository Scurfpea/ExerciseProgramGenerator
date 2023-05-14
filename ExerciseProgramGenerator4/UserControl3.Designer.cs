namespace ExerciseProgramGenerator4
{
    partial class UserControl3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titel = new Label();
            listView2 = new ListView();
            GenerateProgram = new Button();
            DurationProgramLabel = new Label();
            LevelProgramLabel = new Label();
            DurationProgramTextBox = new TextBox();
            LevelProgramtextBox = new TextBox();
            NewProgram = new Button();
            SuspendLayout();
            // 
            // Titel
            // 
            Titel.AutoSize = true;
            Titel.Location = new Point(302, 60);
            Titel.Name = "Titel";
            Titel.Size = new Size(82, 15);
            Titel.TabIndex = 0;
            Titel.Text = "Yoga Program";
            // 
            // listView2
            // 
            listView2.GridLines = true;
            listView2.Location = new Point(302, 93);
            listView2.Name = "listView2";
            listView2.Size = new Size(346, 148);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // GenerateProgram
            // 
            GenerateProgram.Location = new Point(166, 218);
            GenerateProgram.Name = "GenerateProgram";
            GenerateProgram.Size = new Size(115, 23);
            GenerateProgram.TabIndex = 2;
            GenerateProgram.Text = "Generer program";
            GenerateProgram.UseVisualStyleBackColor = true;
            GenerateProgram.Click += GenerateProgram_Click;
            // 
            // DurationProgramLabel
            // 
            DurationProgramLabel.AutoSize = true;
            DurationProgramLabel.Location = new Point(115, 130);
            DurationProgramLabel.Name = "DurationProgramLabel";
            DurationProgramLabel.Size = new Size(53, 15);
            DurationProgramLabel.TabIndex = 3;
            DurationProgramLabel.Text = "Varighed";
            // 
            // LevelProgramLabel
            // 
            LevelProgramLabel.AutoSize = true;
            LevelProgramLabel.Location = new Point(115, 175);
            LevelProgramLabel.Name = "LevelProgramLabel";
            LevelProgramLabel.Size = new Size(44, 15);
            LevelProgramLabel.TabIndex = 4;
            LevelProgramLabel.Text = "Niveau";
            // 
            // DurationProgramTextBox
            // 
            DurationProgramTextBox.Location = new Point(181, 124);
            DurationProgramTextBox.Name = "DurationProgramTextBox";
            DurationProgramTextBox.Size = new Size(100, 23);
            DurationProgramTextBox.TabIndex = 5;
            // 
            // LevelProgramtextBox
            // 
            LevelProgramtextBox.Location = new Point(181, 172);
            LevelProgramtextBox.Name = "LevelProgramtextBox";
            LevelProgramtextBox.Size = new Size(100, 23);
            LevelProgramtextBox.TabIndex = 6;
            // 
            // NewProgram
            // 
            NewProgram.Location = new Point(48, 218);
            NewProgram.Name = "NewProgram";
            NewProgram.Size = new Size(111, 23);
            NewProgram.TabIndex = 7;
            NewProgram.Text = "Nyt Program";
            NewProgram.UseVisualStyleBackColor = true;
            NewProgram.Click += NewProgram_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NewProgram);
            Controls.Add(LevelProgramtextBox);
            Controls.Add(DurationProgramTextBox);
            Controls.Add(LevelProgramLabel);
            Controls.Add(DurationProgramLabel);
            Controls.Add(GenerateProgram);
            Controls.Add(listView2);
            Controls.Add(Titel);
            Name = "UserControl3";
            Size = new Size(716, 459);
            Load += UserControl3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titel;
        private ListView listView2;
        private Button GenerateProgram;
        private Label DurationProgramLabel;
        private Label LevelProgramLabel;
        private TextBox DurationProgramTextBox;
        private TextBox LevelProgramtextBox;
        private Button NewProgram;
    }
}
