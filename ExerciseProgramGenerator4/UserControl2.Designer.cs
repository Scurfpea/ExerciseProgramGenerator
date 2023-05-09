namespace ExerciseProgramGenerator4
{
    partial class UserControl2
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
            UpdateButton = new Button();
            RemoveButton = new Button();
            NewButton = new Button();
            AddButton = new Button();
            NameLabel = new Label();
            DurationLabel = new Label();
            LevelLabel = new Label();
            NameTextBox = new TextBox();
            DurationTextBox = new TextBox();
            LevelTextBox = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // Titel
            // 
            Titel.AutoSize = true;
            Titel.Location = new Point(265, 41);
            Titel.Name = "Titel";
            Titel.Size = new Size(46, 15);
            Titel.TabIndex = 0;
            Titel.Text = "Øvelser";
            Titel.Click += label1_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(340, 215);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Opdater";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(421, 215);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Slet";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(151, 215);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(75, 23);
            NewButton.TabIndex = 3;
            NewButton.Text = "Opret ny";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(243, 215);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 4;
            AddButton.Text = "Tilføj";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(138, 65);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(35, 15);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Navn";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(140, 109);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(53, 15);
            DurationLabel.TabIndex = 6;
            DurationLabel.Text = "Varighed";
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(140, 148);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(44, 15);
            LevelLabel.TabIndex = 7;
            LevelLabel.Text = "Niveau";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(211, 65);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 8;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(212, 109);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(100, 23);
            DurationTextBox.TabIndex = 9;
            // 
            // LevelTextBox
            // 
            LevelTextBox.Location = new Point(212, 145);
            LevelTextBox.Name = "LevelTextBox";
            LevelTextBox.Size = new Size(100, 23);
            LevelTextBox.TabIndex = 10;
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.Location = new Point(140, 262);
            listView1.Name = "listView1";
            listView1.Size = new Size(365, 144);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listView1);
            Controls.Add(LevelTextBox);
            Controls.Add(DurationTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(LevelLabel);
            Controls.Add(DurationLabel);
            Controls.Add(NameLabel);
            Controls.Add(AddButton);
            Controls.Add(NewButton);
            Controls.Add(RemoveButton);
            Controls.Add(UpdateButton);
            Controls.Add(Titel);
            Name = "UserControl2";
            Size = new Size(631, 448);
            Load += UserControl2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titel;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button NewButton;
        private Button AddButton;
        private Label NameLabel;
        private Label DurationLabel;
        private Label LevelLabel;
        private TextBox NameTextBox;
        private TextBox DurationTextBox;
        private TextBox LevelTextBox;
        private ListView listView1;
    }
}
