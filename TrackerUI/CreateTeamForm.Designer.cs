namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addTeamMemeberButton = new Button();
            addNewMemberGroupBox = new GroupBox();
            cellphoneNumberValue = new TextBox();
            createMemberButton = new Button();
            cellphoneNumberLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.Location = new Point(42, 91);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(218, 27);
            teamNameValue.TabIndex = 10;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.Location = new Point(42, 63);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(129, 25);
            teamNameLabel.TabIndex = 9;
            teamNameLabel.Text = "Team Name";
            teamNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Microsoft YaHei Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = SystemColors.InfoText;
            createTeamLabel.Location = new Point(285, 9);
            createTeamLabel.Margin = new Padding(0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(218, 45);
            createTeamLabel.TabIndex = 8;
            createTeamLabel.Text = "Create Team\r\n";
            createTeamLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.BackColor = SystemColors.Menu;
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(42, 149);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(218, 28);
            selectTeamMemberDropDown.TabIndex = 13;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.Location = new Point(42, 121);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(225, 25);
            selectTeamMemberLabel.TabIndex = 11;
            selectTeamMemberLabel.Text = "Select Team Member:";
            selectTeamMemberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addTeamMemeberButton
            // 
            addTeamMemeberButton.BackColor = Color.Transparent;
            addTeamMemeberButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            addTeamMemeberButton.FlatAppearance.BorderSize = 3;
            addTeamMemeberButton.FlatAppearance.MouseDownBackColor = Color.Black;
            addTeamMemeberButton.FlatAppearance.MouseOverBackColor = Color.Black;
            addTeamMemeberButton.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTeamMemeberButton.Location = new Point(42, 183);
            addTeamMemeberButton.Name = "addTeamMemeberButton";
            addTeamMemeberButton.Size = new Size(180, 35);
            addTeamMemeberButton.TabIndex = 14;
            addTeamMemeberButton.Text = "Add Team Member";
            addTeamMemeberButton.UseVisualStyleBackColor = false;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(cellphoneNumberValue);
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneNumberLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Location = new Point(24, 224);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(250, 214);
            addNewMemberGroupBox.TabIndex = 15;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // cellphoneNumberValue
            // 
            cellphoneNumberValue.BorderStyle = BorderStyle.FixedSingle;
            cellphoneNumberValue.Location = new Point(83, 131);
            cellphoneNumberValue.Name = "cellphoneNumberValue";
            cellphoneNumberValue.Size = new Size(161, 27);
            cellphoneNumberValue.TabIndex = 7;
            cellphoneNumberValue.TextAlign = HorizontalAlignment.Center;
            // 
            // createMemberButton
            // 
            createMemberButton.BackColor = Color.Transparent;
            createMemberButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            createMemberButton.FlatAppearance.BorderSize = 3;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.Black;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.Black;
            createMemberButton.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMemberButton.Location = new Point(38, 173);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(180, 28);
            createMemberButton.TabIndex = 14;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = false;
            // 
            // cellphoneNumberLabel
            // 
            cellphoneNumberLabel.AutoSize = true;
            cellphoneNumberLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneNumberLabel.Location = new Point(4, 137);
            cellphoneNumberLabel.Name = "cellphoneNumberLabel";
            cellphoneNumberLabel.Size = new Size(81, 16);
            cellphoneNumberLabel.TabIndex = 6;
            cellphoneNumberLabel.Text = "Cellphone #:";
            cellphoneNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailValue
            // 
            emailValue.BorderStyle = BorderStyle.FixedSingle;
            emailValue.Location = new Point(83, 95);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(161, 27);
            emailValue.TabIndex = 7;
            emailValue.TextAlign = HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(6, 99);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(44, 16);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lastNameValue
            // 
            lastNameValue.BorderStyle = BorderStyle.FixedSingle;
            lastNameValue.Location = new Point(83, 59);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(161, 27);
            lastNameValue.TabIndex = 7;
            lastNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(6, 63);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(75, 16);
            lastNameLabel.TabIndex = 6;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // firstNameValue
            // 
            firstNameValue.BorderStyle = BorderStyle.FixedSingle;
            firstNameValue.Location = new Point(83, 23);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(161, 27);
            firstNameValue.TabIndex = 7;
            firstNameValue.TextAlign = HorizontalAlignment.Center;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(6, 28);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(75, 16);
            firstNameLabel.TabIndex = 6;
            firstNameLabel.Text = "First Name:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Font = new Font("Microsoft YaHei Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.Location = new Point(401, 91);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(333, 344);
            teamMembersListBox.TabIndex = 16;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.BackColor = Color.Transparent;
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            deleteSelectedMemberButton.FlatAppearance.BorderSize = 3;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.Black;
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.Black;
            deleteSelectedMemberButton.Font = new Font("Microsoft YaHei", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSelectedMemberButton.Location = new Point(749, 224);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(85, 67);
            deleteSelectedMemberButton.TabIndex = 17;
            deleteSelectedMemberButton.Text = "Delete Selected\r\n";
            deleteSelectedMemberButton.UseVisualStyleBackColor = false;
            // 
            // createTeamButton
            // 
            createTeamButton.BackColor = Color.Transparent;
            createTeamButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            createTeamButton.FlatAppearance.BorderSize = 3;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.Black;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.Black;
            createTeamButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamButton.Location = new Point(117, 461);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(579, 42);
            createTeamButton.TabIndex = 18;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 515);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemeberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private Button addTeamMemeberButton;
        private GroupBox addNewMemberGroupBox;
        private TextBox cellphoneNumberValue;
        private Label cellphoneNumberLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}