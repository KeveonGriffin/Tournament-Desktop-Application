namespace TrackerUI
{
    partial class CreateTournamentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            label1 = new Label();
            createNewTeam = new LinkLabel();
            selectTeamDropDown = new ComboBox();
            addTeamButton = new Button();
            createTournamentButton = new Button();
            tournamentPlayersListBox = new ListBox();
            label2 = new Label();
            deleteSelectedPlayersButton = new Button();
            prizeListLabel = new Label();
            prizeListBox = new ListBox();
            deleteSelectedPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Microsoft YaHei Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = SystemColors.InfoText;
            headerLabel.Location = new Point(264, 9);
            headerLabel.Margin = new Padding(0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(322, 45);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            headerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BorderStyle = BorderStyle.FixedSingle;
            tournamentNameValue.Location = new Point(43, 82);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(322, 27);
            tournamentNameValue.TabIndex = 7;
            tournamentNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tournamentNameLabel.Location = new Point(43, 54);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(190, 25);
            tournamentNameLabel.TabIndex = 6;
            tournamentNameLabel.Text = "Tournament Name";
            tournamentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entryFeeLabel.Location = new Point(43, 181);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(105, 25);
            entryFeeLabel.TabIndex = 6;
            entryFeeLabel.Text = "Entry Fee\r\n";
            entryFeeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // entryFeeValue
            // 
            entryFeeValue.AccessibleDescription = "Value box for Entry Fee value";
            entryFeeValue.BorderStyle = BorderStyle.FixedSingle;
            entryFeeValue.Location = new Point(43, 211);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(322, 27);
            entryFeeValue.TabIndex = 7;
            entryFeeValue.Text = "0";
            entryFeeValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 116);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 6;
            label1.Text = "Select Team:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createNewTeam
            // 
            createNewTeam.AutoSize = true;
            createNewTeam.Location = new Point(264, 121);
            createNewTeam.Name = "createNewTeam";
            createNewTeam.Size = new Size(101, 20);
            createNewTeam.TabIndex = 8;
            createNewTeam.TabStop = true;
            createNewTeam.Text = "Create Team";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.AccessibleDescription = "Drop down for selecting a team";
            selectTeamDropDown.BackColor = SystemColors.Menu;
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(43, 144);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(322, 28);
            selectTeamDropDown.TabIndex = 9;
            // 
            // addTeamButton
            // 
            addTeamButton.AccessibleDescription = "'Add Team' button used for executing command to add team to tournament.";
            addTeamButton.BackColor = Color.Transparent;
            addTeamButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            addTeamButton.FlatAppearance.BorderSize = 3;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.Black;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.Black;
            addTeamButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTeamButton.Location = new Point(117, 259);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(180, 35);
            addTeamButton.TabIndex = 10;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.AccessibleDescription = "Button used to create tournament";
            createTournamentButton.BackColor = Color.Transparent;
            createTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            createTournamentButton.FlatAppearance.BorderSize = 3;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Black;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.Black;
            createTournamentButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentButton.Location = new Point(117, 374);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(579, 42);
            createTournamentButton.TabIndex = 10;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.Font = new Font("Microsoft YaHei Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.Location = new Point(443, 87);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(253, 124);
            tournamentPlayersListBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(443, 59);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 6;
            label2.Text = "Teams / Players";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // deleteSelectedPlayersButton
            // 
            deleteSelectedPlayersButton.BackColor = Color.Transparent;
            deleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            deleteSelectedPlayersButton.FlatAppearance.BorderSize = 3;
            deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.Black;
            deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.Black;
            deleteSelectedPlayersButton.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSelectedPlayersButton.Location = new Point(738, 116);
            deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            deleteSelectedPlayersButton.Size = new Size(85, 67);
            deleteSelectedPlayersButton.TabIndex = 12;
            deleteSelectedPlayersButton.Text = "Delete Selected";
            deleteSelectedPlayersButton.UseVisualStyleBackColor = false;
            // 
            // prizeListLabel
            // 
            prizeListLabel.AutoSize = true;
            prizeListLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizeListLabel.Location = new Point(443, 209);
            prizeListLabel.Name = "prizeListLabel";
            prizeListLabel.Size = new Size(72, 25);
            prizeListLabel.TabIndex = 6;
            prizeListLabel.Text = "Prizes";
            prizeListLabel.TextAlign = ContentAlignment.MiddleLeft;
            prizeListLabel.Click += label2_Click;
            // 
            // prizeListBox
            // 
            prizeListBox.Font = new Font("Microsoft YaHei Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeListBox.FormattingEnabled = true;
            prizeListBox.Location = new Point(443, 237);
            prizeListBox.Name = "prizeListBox";
            prizeListBox.Size = new Size(253, 124);
            prizeListBox.TabIndex = 11;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.BackColor = Color.Transparent;
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            deleteSelectedPrizeButton.FlatAppearance.BorderSize = 3;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.Black;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            deleteSelectedPrizeButton.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSelectedPrizeButton.Location = new Point(738, 266);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(85, 67);
            deleteSelectedPrizeButton.TabIndex = 12;
            deleteSelectedPrizeButton.Text = "Delete Selected\r\n";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(prizeListBox);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createTournamentButton);
            Controls.Add(addTeamButton);
            Controls.Add(selectTeamDropDown);
            Controls.Add(createNewTeam);
            Controls.Add(entryFeeValue);
            Controls.Add(tournamentNameValue);
            Controls.Add(label1);
            Controls.Add(prizeListLabel);
            Controls.Add(entryFeeLabel);
            Controls.Add(label2);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private Label label1;
        private LinkLabel createNewTeam;
        private ComboBox selectTeamDropDown;
        private Button addTeamButton;
        private Button createTournamentButton;
        private ListBox tournamentPlayersListBox;
        private Label label2;
        private Button deleteSelectedPlayersButton;
        private Label prizeListLabel;
        private ListBox prizeListBox;
        private Button deleteSelectedPrizeButton;
    }
}