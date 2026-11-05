namespace Lab2App
{
    partial class BicycleRentalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEndNote = new System.Windows.Forms.Label();
            this.numEndTime = new System.Windows.Forms.NumericUpDown();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartNote = new System.Windows.Forms.Label();
            this.numStartTime = new System.Windows.Forms.NumericUpDown();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblInputHeader = new System.Windows.Forms.Label();
            this.pnlRatesCard = new System.Windows.Forms.Panel();
            this.lblRate3 = new System.Windows.Forms.Label();
            this.lblRate2 = new System.Windows.Forms.Label();
            this.lblRate1 = new System.Windows.Forms.Label();
            this.lblRatesTitle = new System.Windows.Forms.Label();
            this.pnlResultsCard = new System.Windows.Forms.Panel();
            this.pnlTotalBox = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblBreakdownPeak = new System.Windows.Forms.Label();
            this.lblBreakdownStandard = new System.Windows.Forms.Label();
            this.lblBreakdownNight = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblRentalTimeSpan = new System.Windows.Forms.Label();
            this.lblResultsHeader = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartTime)).BeginInit();
            this.pnlRatesCard.SuspendLayout();
            this.pnlResultsCard.SuspendLayout();
            this.pnlTotalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(695, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 36);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "← Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 43);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(359, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Calculate dynamic hourly rental costs based on time of day";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(384, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Problem 1: Bicycle Rental Calculator";
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInputCard.Controls.Add(this.btnReset);
            this.pnlInputCard.Controls.Add(this.btnCalculate);
            this.pnlInputCard.Controls.Add(this.lblEndNote);
            this.pnlInputCard.Controls.Add(this.numEndTime);
            this.pnlInputCard.Controls.Add(this.lblEndTime);
            this.pnlInputCard.Controls.Add(this.lblStartNote);
            this.pnlInputCard.Controls.Add(this.numStartTime);
            this.pnlInputCard.Controls.Add(this.lblStartTime);
            this.pnlInputCard.Controls.Add(this.lblInputHeader);
            this.pnlInputCard.Location = new System.Drawing.Point(27, 95);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Size = new System.Drawing.Size(385, 290);
            this.pnlInputCard.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnReset.Location = new System.Drawing.Point(260, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 42);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(25, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(225, 42);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Total Cost";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblEndNote
            // 
            this.lblEndNote.AutoSize = true;
            this.lblEndNote.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblEndNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEndNote.Location = new System.Drawing.Point(22, 195);
            this.lblEndNote.Name = "lblEndNote";
            this.lblEndNote.Size = new System.Drawing.Size(306, 13);
            this.lblEndNote.TabIndex = 6;
            this.lblEndNote.Text = "Valid range: 1 to 24 (must be strictly greater than start time)";
            // 
            // numEndTime
            // 
            this.numEndTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numEndTime.Location = new System.Drawing.Point(25, 165);
            this.numEndTime.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numEndTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndTime.Name = "numEndTime";
            this.numEndTime.Size = new System.Drawing.Size(330, 27);
            this.numEndTime.TabIndex = 5;
            this.numEndTime.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblEndTime.Location = new System.Drawing.Point(22, 142);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(184, 17);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "Ending Time (hour, 1 to 24):";
            // 
            // lblStartNote
            // 
            this.lblStartNote.AutoSize = true;
            this.lblStartNote.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblStartNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStartNote.Location = new System.Drawing.Point(22, 114);
            this.lblStartNote.Name = "lblStartNote";
            this.lblStartNote.Size = new System.Drawing.Size(188, 13);
            this.lblStartNote.TabIndex = 3;
            this.lblStartNote.Text = "Valid range: 0 to 23 (24-hour clock)";
            // 
            // numStartTime
            // 
            this.numStartTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numStartTime.Location = new System.Drawing.Point(25, 84);
            this.numStartTime.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numStartTime.Name = "numStartTime";
            this.numStartTime.Size = new System.Drawing.Size(330, 27);
            this.numStartTime.TabIndex = 2;
            this.numStartTime.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStartTime.Location = new System.Drawing.Point(22, 61);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(189, 17);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Starting Time (hour, 0 to 23):";
            // 
            // lblInputHeader
            // 
            this.lblInputHeader.AutoSize = true;
            this.lblInputHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInputHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInputHeader.Location = new System.Drawing.Point(21, 18);
            this.lblInputHeader.Name = "lblInputHeader";
            this.lblInputHeader.Size = new System.Drawing.Size(197, 21);
            this.lblInputHeader.TabIndex = 0;
            this.lblInputHeader.Text = "Rental Time Parameters";
            // 
            // pnlRatesCard
            // 
            this.pnlRatesCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pnlRatesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRatesCard.Controls.Add(this.lblRate3);
            this.pnlRatesCard.Controls.Add(this.lblRate2);
            this.pnlRatesCard.Controls.Add(this.lblRate1);
            this.pnlRatesCard.Controls.Add(this.lblRatesTitle);
            this.pnlRatesCard.Location = new System.Drawing.Point(27, 400);
            this.pnlRatesCard.Name = "pnlRatesCard";
            this.pnlRatesCard.Size = new System.Drawing.Size(385, 175);
            this.pnlRatesCard.TabIndex = 2;
            // 
            // lblRate3
            // 
            this.lblRate3.AutoSize = true;
            this.lblRate3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRate3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblRate3.Location = new System.Drawing.Point(18, 128);
            this.lblRate3.Name = "lblRate3";
            this.lblRate3.Size = new System.Drawing.Size(268, 15);
            this.lblRate3.TabIndex = 3;
            this.lblRate3.Text = "• 14:00 – 19:00 :  1,500 RWF / hr (Peak afternoon)";
            // 
            // lblRate2
            // 
            this.lblRate2.AutoSize = true;
            this.lblRate2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblRate2.Location = new System.Drawing.Point(18, 93);
            this.lblRate2.Name = "lblRate2";
            this.lblRate2.Size = new System.Drawing.Size(315, 15);
            this.lblRate2.TabIndex = 2;
            this.lblRate2.Text = "• 07:00 – 14:00 && 19:00 – 21:00 :  1,000 RWF / hr (Standard)";
            // 
            // lblRate1
            // 
            this.lblRate1.AutoSize = true;
            this.lblRate1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblRate1.Location = new System.Drawing.Point(18, 58);
            this.lblRate1.Name = "lblRate1";
            this.lblRate1.Size = new System.Drawing.Size(310, 15);
            this.lblRate1.TabIndex = 1;
            this.lblRate1.Text = "• 00:00 – 07:00 && 21:00 – 24:00 :  500 RWF / hr (Night rate)";
            // 
            // lblRatesTitle
            // 
            this.lblRatesTitle.AutoSize = true;
            this.lblRatesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRatesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblRatesTitle.Location = new System.Drawing.Point(17, 18);
            this.lblRatesTitle.Name = "lblRatesTitle";
            this.lblRatesTitle.Size = new System.Drawing.Size(185, 19);
            this.lblRatesTitle.TabIndex = 0;
            this.lblRatesTitle.Text = "Official Hourly Pricing Rates";
            // 
            // pnlResultsCard
            // 
            this.pnlResultsCard.BackColor = System.Drawing.Color.White;
            this.pnlResultsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultsCard.Controls.Add(this.pnlTotalBox);
            this.pnlResultsCard.Controls.Add(this.lblBreakdownPeak);
            this.pnlResultsCard.Controls.Add(this.lblBreakdownStandard);
            this.pnlResultsCard.Controls.Add(this.lblBreakdownNight);
            this.pnlResultsCard.Controls.Add(this.lblDuration);
            this.pnlResultsCard.Controls.Add(this.lblRentalTimeSpan);
            this.pnlResultsCard.Controls.Add(this.lblResultsHeader);
            this.pnlResultsCard.Location = new System.Drawing.Point(435, 95);
            this.pnlResultsCard.Name = "pnlResultsCard";
            this.pnlResultsCard.Size = new System.Drawing.Size(398, 480);
            this.pnlResultsCard.TabIndex = 3;
            // 
            // pnlTotalBox
            // 
            this.pnlTotalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnlTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalBox.Controls.Add(this.lblTotalCost);
            this.pnlTotalBox.Controls.Add(this.lblTotalCaption);
            this.pnlTotalBox.Location = new System.Drawing.Point(22, 335);
            this.pnlTotalBox.Name = "pnlTotalBox";
            this.pnlTotalBox.Size = new System.Drawing.Size(350, 115);
            this.pnlTotalBox.TabIndex = 6;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lblTotalCost.Location = new System.Drawing.Point(12, 50);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(325, 45);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "10,500 RWF";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(12, 18);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(325, 22);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "TOTAL AMOUNT TO PAY";
            this.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreakdownPeak
            // 
            this.lblBreakdownPeak.AutoSize = true;
            this.lblBreakdownPeak.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBreakdownPeak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblBreakdownPeak.Location = new System.Drawing.Point(25, 260);
            this.lblBreakdownPeak.Name = "lblBreakdownPeak";
            this.lblBreakdownPeak.Size = new System.Drawing.Size(267, 17);
            this.lblBreakdownPeak.TabIndex = 5;
            this.lblBreakdownPeak.Text = "• Peak Hours (14-19 @ 1500 RWF): 3 hrs";
            // 
            // lblBreakdownStandard
            // 
            this.lblBreakdownStandard.AutoSize = true;
            this.lblBreakdownStandard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBreakdownStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblBreakdownStandard.Location = new System.Drawing.Point(25, 215);
            this.lblBreakdownStandard.Name = "lblBreakdownStandard";
            this.lblBreakdownStandard.Size = new System.Drawing.Size(298, 17);
            this.lblBreakdownStandard.TabIndex = 4;
            this.lblBreakdownStandard.Text = "• Standard Hours (7-14, 19-21 @ 1000 RWF): 6 hrs";
            // 
            // lblBreakdownNight
            // 
            this.lblBreakdownNight.AutoSize = true;
            this.lblBreakdownNight.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBreakdownNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblBreakdownNight.Location = new System.Drawing.Point(25, 170);
            this.lblBreakdownNight.Name = "lblBreakdownNight";
            this.lblBreakdownNight.Size = new System.Drawing.Size(277, 17);
            this.lblBreakdownNight.TabIndex = 3;
            this.lblBreakdownNight.Text = "• Night Hours (0-7, 21-24 @ 500 RWF): 0 hrs";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblDuration.Location = new System.Drawing.Point(24, 115);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(161, 19);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Total Duration: 9 hour(s)";
            // 
            // lblRentalTimeSpan
            // 
            this.lblRentalTimeSpan.AutoSize = true;
            this.lblRentalTimeSpan.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblRentalTimeSpan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblRentalTimeSpan.Location = new System.Drawing.Point(24, 70);
            this.lblRentalTimeSpan.Name = "lblRentalTimeSpan";
            this.lblRentalTimeSpan.Size = new System.Drawing.Size(271, 19);
            this.lblRentalTimeSpan.TabIndex = 1;
            this.lblRentalTimeSpan.Text = "Start Time: 8:00   |   End Time: 17:00";
            // 
            // lblResultsHeader
            // 
            this.lblResultsHeader.AutoSize = true;
            this.lblResultsHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblResultsHeader.Location = new System.Drawing.Point(21, 18);
            this.lblResultsHeader.Name = "lblResultsHeader";
            this.lblResultsHeader.Size = new System.Drawing.Size(130, 21);
            this.lblResultsHeader.TabIndex = 0;
            this.lblResultsHeader.Text = "Rental Summary";
            // 
            // BicycleRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.pnlResultsCard);
            this.Controls.Add(this.pnlRatesCard);
            this.Controls.Add(this.pnlInputCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BicycleRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bicycle Rental Pricing Calculator";
            this.Load += new System.EventHandler(this.BicycleRentalForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartTime)).EndInit();
            this.pnlRatesCard.ResumeLayout(false);
            this.pnlRatesCard.PerformLayout();
            this.pnlResultsCard.ResumeLayout(false);
            this.pnlResultsCard.PerformLayout();
            this.pnlTotalBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblInputHeader;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.NumericUpDown numStartTime;
        private System.Windows.Forms.Label lblStartNote;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.NumericUpDown numEndTime;
        private System.Windows.Forms.Label lblEndNote;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlRatesCard;
        private System.Windows.Forms.Label lblRatesTitle;
        private System.Windows.Forms.Label lblRate1;
        private System.Windows.Forms.Label lblRate2;
        private System.Windows.Forms.Label lblRate3;
        private System.Windows.Forms.Panel pnlResultsCard;
        private System.Windows.Forms.Label lblResultsHeader;
        private System.Windows.Forms.Label lblRentalTimeSpan;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblBreakdownNight;
        private System.Windows.Forms.Label lblBreakdownStandard;
        private System.Windows.Forms.Label lblBreakdownPeak;
        private System.Windows.Forms.Panel pnlTotalBox;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalCost;
    }
}
