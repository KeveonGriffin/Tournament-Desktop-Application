namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            dashboardLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // dashboardLabel
            // 
            dashboardLabel.AutoSize = true;
            dashboardLabel.Font = new Font("Microsoft YaHei Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardLabel.ForeColor = SystemColors.InfoText;
            dashboardLabel.Location = new Point(205, 9);
            dashboardLabel.Margin = new Padding(0);
            dashboardLabel.Name = "dashboardLabel";
            dashboardLabel.Size = new Size(390, 45);
            dashboardLabel.TabIndex = 12;
            dashboardLabel.Text = "Tournament Dashboard";
            dashboardLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.AccessibleDescription = "Drop down to find any existing tournaments.";
            loadExistingTournamentDropDown.AccessibleRole = AccessibleRole.ButtonDropDown;
            loadExistingTournamentDropDown.BackColor = SystemColors.Menu;
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(205, 149);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(390, 28);
            loadExistingTournamentDropDown.TabIndex = 15;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadExistingTournamentLabel.Location = new Point(268, 105);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(264, 25);
            loadExistingTournamentLabel.TabIndex = 14;
            loadExistingTournamentLabel.Text = "Load Exsiting Tournament\r\n";
            loadExistingTournamentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.AccessibleDescription = "Action used to load existing tournaments";
            loadTournamentButton.BackColor = Color.Transparent;
            loadTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            loadTournamentButton.FlatAppearance.BorderSize = 3;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.Black;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.Black;
            loadTournamentButton.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadTournamentButton.Location = new Point(310, 197);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(180, 35);
            loadTournamentButton.TabIndex = 16;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.AccessibleDescription = "Create Tournament button";
            createTournamentButton.BackColor = Color.Transparent;
            createTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            createTournamentButton.FlatAppearance.BorderSize = 3;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Black;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.Black;
            createTournamentButton.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentButton.Location = new Point(268, 277);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(264, 47);
            createTournamentButton.TabIndex = 16;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(dashboardLabel);
            Font = new Font("Microsoft YaHei UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dashboardLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}