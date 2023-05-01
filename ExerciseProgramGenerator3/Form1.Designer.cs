namespace ExerciseProgramGenerator3
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
            NameLabel = new Label();
            DurationLabel = new Label();
            LevelLabel = new Label();
            listView1 = new ListView();
            NameTextBox = new TextBox();
            DurationTextBox = new TextBox();
            LevelTextBox = new TextBox();
            AddButton = new Button();
            NewButton = new Button();
            RemoveButton = new Button();
            UpdateButton = new Button();
            Save = new Button();
            LoadButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(70, 106);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(35, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Navn";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(70, 157);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(53, 15);
            DurationLabel.TabIndex = 1;
            DurationLabel.Text = "Varighed";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(70, 218);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(44, 15);
            LevelLabel.TabIndex = 2;
            LevelLabel.Text = "Niveau";
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(322, 87);
            listView1.Name = "listView1";
            listView1.Size = new Size(363, 186);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(180, 106);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 4;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(180, 154);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(100, 23);
            DurationTextBox.TabIndex = 5;
            // 
            // LevelTextBox
            // 
            LevelTextBox.Location = new Point(180, 218);
            LevelTextBox.Name = "LevelTextBox";
            LevelTextBox.Size = new Size(100, 23);
            LevelTextBox.TabIndex = 6;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(140, 302);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 7;
            AddButton.Text = "Tilføj";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(261, 302);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 8;
            NewButton.Text = "Ny øvelse";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(514, 302);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 9;
            RemoveButton.Text = "Slet";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(386, 302);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 10;
            UpdateButton.Text = "Opdater";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Save
            // 
            Save.Location = new Point(610, 302);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 11;
            Save.Text = "Gem";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(39, 302);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 12;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private Label NameLabel;
        private Label DurationLabel;
        private Label LevelLabel;
        private ListView listView1;
        private TextBox NameTextBox;
        private TextBox DurationTextBox;
        private TextBox LevelTextBox;
        private Button AddButton;
        private Button NewButton;
        private Button RemoveButton;
        private Button UpdateButton;
        private Button Save;
        private Button LoadButton;
    }
}