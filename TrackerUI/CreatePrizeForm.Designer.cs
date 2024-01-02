namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            createPrizeLabel = new Label();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageLabel = new Label();
            prizeAmountValue = new TextBox();
            prizePercentageValue = new TextBox();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // placeNumberValue
            // 
            placeNumberValue.BorderStyle = BorderStyle.FixedSingle;
            placeNumberValue.Location = new Point(465, 117);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(149, 27);
            placeNumberValue.TabIndex = 13;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeNumberLabel.Location = new Point(288, 116);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(147, 25);
            placeNumberLabel.TabIndex = 12;
            placeNumberLabel.Text = "Place Number";
            placeNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Microsoft YaHei Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeLabel.ForeColor = SystemColors.InfoText;
            createPrizeLabel.Location = new Point(351, 9);
            createPrizeLabel.Margin = new Padding(0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(208, 45);
            createPrizeLabel.TabIndex = 11;
            createPrizeLabel.Text = "Create Prize";
            createPrizeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            placeNameLabel.Location = new Point(288, 156);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(128, 25);
            placeNameLabel.TabIndex = 12;
            placeNameLabel.Text = "Place Name";
            placeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // placeNameValue
            // 
            placeNameValue.BorderStyle = BorderStyle.FixedSingle;
            placeNameValue.Location = new Point(465, 156);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(149, 27);
            placeNameValue.TabIndex = 13;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizeAmountLabel.Location = new Point(288, 196);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(141, 25);
            prizeAmountLabel.TabIndex = 12;
            prizeAmountLabel.Text = "Prize Amount";
            prizeAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizePercentageLabel.Location = new Point(288, 291);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(177, 25);
            prizePercentageLabel.TabIndex = 12;
            prizePercentageLabel.Text = "Prize Percentage";
            prizePercentageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountValue.Location = new Point(465, 195);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(149, 27);
            prizeAmountValue.TabIndex = 13;
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BorderStyle = BorderStyle.FixedSingle;
            prizePercentageValue.Location = new Point(467, 289);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(147, 27);
            prizePercentageValue.TabIndex = 13;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.Location = new Point(435, 244);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(41, 25);
            orLabel.TabIndex = 12;
            orLabel.Text = "OR";
            orLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = Color.Transparent;
            createPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            createPrizeButton.FlatAppearance.BorderSize = 3;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Black;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            createPrizeButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeButton.Location = new Point(166, 375);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(579, 42);
            createPrizeButton.TabIndex = 19;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(createPrizeButton);
            Controls.Add(prizePercentageValue);
            Controls.Add(placeNameValue);
            Controls.Add(prizeAmountValue);
            Controls.Add(placeNumberValue);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private Label createPrizeLabel;
        private Label placeNameLabel;
        private TextBox placeNameValue;
        private Label prizeAmountLabel;
        private Label prizePercentageLabel;
        private TextBox prizeAmountValue;
        private TextBox prizePercentageValue;
        private Label orLabel;
        private Button createPrizeButton;
    }
}