namespace TrackerUI;

partial class TournamentViewerForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
        headerLabel = new Label();
        tournamentName = new Label();
        roundLabel = new Label();
        roundDropDown = new ComboBox();
        unplayedOnlyCheckBox = new CheckBox();
        matchupListBox = new ListBox();
        teamOneName = new Label();
        teamOneScoreLabel = new Label();
        teamOneScoreValue = new TextBox();
        teamTwoName = new Label();
        teamTwoScoreLabel = new Label();
        teamTwoScoreValue = new TextBox();
        versusLabel = new Label();
        scoreButton = new Button();
        SuspendLayout();
        // 
        // headerLabel
        // 
        headerLabel.AutoSize = true;
        headerLabel.Font = new Font("Microsoft YaHei UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        headerLabel.ForeColor = SystemColors.InfoText;
        headerLabel.Location = new Point(251, 9);
        headerLabel.Margin = new Padding(0);
        headerLabel.Name = "headerLabel";
        headerLabel.Size = new Size(218, 45);
        headerLabel.TabIndex = 0;
        headerLabel.Text = "Tournament:";
        // 
        // tournamentName
        // 
        tournamentName.AutoSize = true;
        tournamentName.BackColor = Color.Transparent;
        tournamentName.Font = new Font("Microsoft YaHei UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tournamentName.ForeColor = SystemColors.InfoText;
        tournamentName.Location = new Point(461, 9);
        tournamentName.Margin = new Padding(0);
        tournamentName.Name = "tournamentName";
        tournamentName.Size = new Size(148, 45);
        tournamentName.TabIndex = 0;
        tournamentName.Text = "<none>";
        // 
        // roundLabel
        // 
        roundLabel.AutoSize = true;
        roundLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        roundLabel.Location = new Point(21, 80);
        roundLabel.Name = "roundLabel";
        roundLabel.Size = new Size(81, 25);
        roundLabel.TabIndex = 1;
        roundLabel.Text = "Round:";
        // 
        // roundDropDown
        // 
        roundDropDown.AccessibleDescription = "Drop down for accessing Rounds.";
        roundDropDown.BackColor = SystemColors.Menu;
        roundDropDown.FormattingEnabled = true;
        roundDropDown.Location = new Point(108, 79);
        roundDropDown.Name = "roundDropDown";
        roundDropDown.Size = new Size(117, 26);
        roundDropDown.TabIndex = 2;
        // 
        // unplayedOnlyCheckBox
        // 
        unplayedOnlyCheckBox.AutoSize = true;
        unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
        unplayedOnlyCheckBox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        unplayedOnlyCheckBox.Location = new Point(108, 111);
        unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
        unplayedOnlyCheckBox.Size = new Size(135, 24);
        unplayedOnlyCheckBox.TabIndex = 3;
        unplayedOnlyCheckBox.Text = "Unplayed Only";
        unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
        // 
        // matchupListBox
        // 
        matchupListBox.Font = new Font("Microsoft YaHei Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        matchupListBox.FormattingEnabled = true;
        matchupListBox.Location = new Point(21, 141);
        matchupListBox.Name = "matchupListBox";
        matchupListBox.Size = new Size(310, 244);
        matchupListBox.TabIndex = 4;
        // 
        // teamOneName
        // 
        teamOneName.AutoSize = true;
        teamOneName.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        teamOneName.Location = new Point(425, 142);
        teamOneName.Name = "teamOneName";
        teamOneName.Size = new Size(208, 39);
        teamOneName.TabIndex = 1;
        teamOneName.Text = "<team one>";
        // 
        // teamOneScoreLabel
        // 
        teamOneScoreLabel.AutoSize = true;
        teamOneScoreLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        teamOneScoreLabel.Location = new Point(456, 184);
        teamOneScoreLabel.Name = "teamOneScoreLabel";
        teamOneScoreLabel.Size = new Size(70, 25);
        teamOneScoreLabel.TabIndex = 1;
        teamOneScoreLabel.Text = "Score:";
        teamOneScoreLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // teamOneScoreValue
        // 
        teamOneScoreValue.BorderStyle = BorderStyle.FixedSingle;
        teamOneScoreValue.Location = new Point(538, 184);
        teamOneScoreValue.Name = "teamOneScoreValue";
        teamOneScoreValue.Size = new Size(52, 24);
        teamOneScoreValue.TabIndex = 5;
        teamOneScoreValue.TextAlign = HorizontalAlignment.Center;
        // 
        // teamTwoName
        // 
        teamTwoName.AutoSize = true;
        teamTwoName.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        teamTwoName.Location = new Point(425, 304);
        teamTwoName.Name = "teamTwoName";
        teamTwoName.Size = new Size(204, 39);
        teamTwoName.TabIndex = 1;
        teamTwoName.Text = "<team two>";
        // 
        // teamTwoScoreLabel
        // 
        teamTwoScoreLabel.AutoSize = true;
        teamTwoScoreLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        teamTwoScoreLabel.Location = new Point(456, 352);
        teamTwoScoreLabel.Name = "teamTwoScoreLabel";
        teamTwoScoreLabel.Size = new Size(70, 25);
        teamTwoScoreLabel.TabIndex = 1;
        teamTwoScoreLabel.Text = "Score:";
        teamTwoScoreLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // teamTwoScoreValue
        // 
        teamTwoScoreValue.BorderStyle = BorderStyle.FixedSingle;
        teamTwoScoreValue.Location = new Point(538, 355);
        teamTwoScoreValue.Name = "teamTwoScoreValue";
        teamTwoScoreValue.Size = new Size(52, 24);
        teamTwoScoreValue.TabIndex = 5;
        teamTwoScoreValue.TextAlign = HorizontalAlignment.Center;
        // 
        // versusLabel
        // 
        versusLabel.AutoSize = true;
        versusLabel.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        versusLabel.Location = new Point(476, 231);
        versusLabel.Name = "versusLabel";
        versusLabel.Size = new Size(114, 52);
        versusLabel.TabIndex = 1;
        versusLabel.Text = "-VS-";
        // 
        // scoreButton
        // 
        scoreButton.BackColor = Color.Transparent;
        scoreButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
        scoreButton.FlatAppearance.BorderSize = 3;
        scoreButton.FlatAppearance.MouseDownBackColor = Color.Black;
        scoreButton.FlatAppearance.MouseOverBackColor = Color.Black;
        scoreButton.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        scoreButton.Location = new Point(644, 231);
        scoreButton.Name = "scoreButton";
        scoreButton.Size = new Size(122, 52);
        scoreButton.TabIndex = 6;
        scoreButton.Text = "Score:";
        scoreButton.UseVisualStyleBackColor = false;
        // 
        // TournamentViewerForm
        // 
        AutoScaleDimensions = new SizeF(10F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(886, 475);
        Controls.Add(scoreButton);
        Controls.Add(teamTwoScoreValue);
        Controls.Add(teamOneScoreValue);
        Controls.Add(matchupListBox);
        Controls.Add(unplayedOnlyCheckBox);
        Controls.Add(roundDropDown);
        Controls.Add(teamTwoScoreLabel);
        Controls.Add(teamTwoName);
        Controls.Add(teamOneScoreLabel);
        Controls.Add(versusLabel);
        Controls.Add(teamOneName);
        Controls.Add(roundLabel);
        Controls.Add(tournamentName);
        Controls.Add(headerLabel);
        Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 2, 4, 2);
        Name = "TournamentViewerForm";
        Text = "Tournament Viewer";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label headerLabel;
    private Label tournamentName;
    private Label roundLabel;
    private ComboBox roundDropDown;
    private CheckBox unplayedOnlyCheckBox;
    private ListBox matchupListBox;
    private Label teamOneName;
    private Label teamOneScoreLabel;
    private TextBox teamOneScoreValue;
    private Label teamTwoName;
    private Label teamTwoScoreLabel;
    private TextBox teamTwoScoreValue;
    private Label versusLabel;
    private Button scoreButton;
}
