namespace ExerciseProgramGenerator4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadButton = new Button();
            Save = new Button();
            UpdateButton = new Button();
            RemoveButton = new Button();
            NewButton = new Button();
            AddButton = new Button();
            LevelTextBox = new TextBox();
            DurationTextBox = new TextBox();
            NameTextBox = new TextBox();
            listView1 = new ListView();
            LevelLabel = new Label();
            DurationLabel = new Label();
            NameLabel = new Label();
            GenerateProgram = new Button();
            listView2 = new ListView();
            LevelProgramtextBox = new TextBox();
            label1 = new Label();
            SaveProgram = new Button();
            BlockLabel = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(71, 227);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 25;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // Save
            // 
            Save.Location = new Point(642, 227);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 24;
            Save.Text = "Gem";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(418, 227);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 23;
            UpdateButton.Text = "Opdater";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(546, 227);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 22;
            RemoveButton.Text = "Slet";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(293, 227);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 21;
            NewButton.Text = "Ny øvelse";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(172, 227);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 20;
            AddButton.Text = "Tilføj";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // LevelTextBox
            // 
            LevelTextBox.Location = new Point(212, 143);
            LevelTextBox.Name = "LevelTextBox";
            LevelTextBox.Size = new Size(100, 23);
            LevelTextBox.TabIndex = 19;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(212, 79);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(100, 23);
            DurationTextBox.TabIndex = 18;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(212, 31);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 17;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(354, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(363, 186);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(102, 143);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(44, 15);
            LevelLabel.TabIndex = 15;
            LevelLabel.Text = "Niveau";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(102, 82);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(53, 15);
            DurationLabel.TabIndex = 14;
            DurationLabel.Text = "Varighed";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(102, 31);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(35, 15);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Navn";
            // 
            // GenerateProgram
            // 
            GenerateProgram.Location = new Point(293, 284);
            GenerateProgram.Name = "GenerateProgram";
            GenerateProgram.Size = new Size(126, 23);
            GenerateProgram.TabIndex = 26;
            GenerateProgram.Text = "Generer program";
            GenerateProgram.UseVisualStyleBackColor = true;
            GenerateProgram.Click += GenerateProgram_Click;
            // 
            // listView2
            // 
            listView2.GridLines = true;
            listView2.Location = new Point(438, 284);
            listView2.Name = "listView2";
            listView2.Size = new Size(300, 154);
            listView2.TabIndex = 27;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // LevelProgramtextBox
            // 
            LevelProgramtextBox.Location = new Point(293, 326);
            LevelProgramtextBox.Name = "LevelProgramtextBox";
            LevelProgramtextBox.Size = new Size(100, 23);
            LevelProgramtextBox.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 329);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 29;
            label1.Text = "Niveau";
            // 
            // SaveProgram
            // 
            SaveProgram.Location = new Point(307, 404);
            SaveProgram.Name = "SaveProgram";
            SaveProgram.Size = new Size(75, 23);
            SaveProgram.TabIndex = 30;
            SaveProgram.Text = "Gem";
            SaveProgram.UseVisualStyleBackColor = true;
            SaveProgram.Click += SaveProgram_Click;
            // 
            // BlockLabel
            // 
            BlockLabel.AutoSize = true;
            BlockLabel.Location = new Point(229, 358);
            BlockLabel.Name = "BlockLabel";
            BlockLabel.Size = new Size(30, 15);
            BlockLabel.TabIndex = 32;
            BlockLabel.Text = "Blok";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 355);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BlockLabel);
            Controls.Add(textBox1);
            Controls.Add(SaveProgram);
            Controls.Add(label1);
            Controls.Add(LevelProgramtextBox);
            Controls.Add(listView2);
            Controls.Add(GenerateProgram);
            Controls.Add(LoadButton);
            Controls.Add(Save);
            Controls.Add(UpdateButton);
            Controls.Add(RemoveButton);
            Controls.Add(NewButton);
            Controls.Add(AddButton);
            Controls.Add(LevelTextBox);
            Controls.Add(DurationTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(listView1);
            Controls.Add(LevelLabel);
            Controls.Add(DurationLabel);
            Controls.Add(NameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoadButton;
        private Button Save;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button NewButton;
        private Button AddButton;
        private TextBox LevelTextBox;
        private TextBox DurationTextBox;
        private TextBox NameTextBox;
        private ListView listView1;
        private Label LevelLabel;
        private Label DurationLabel;
        private Label NameLabel;
        private Button GenerateProgram;
        private ListView listView2;
        private TextBox LevelProgramtextBox;
        private Label label1;
        private Button SaveProgram;
        private Label BlockLabel;
        private TextBox textBox1;
    }
}