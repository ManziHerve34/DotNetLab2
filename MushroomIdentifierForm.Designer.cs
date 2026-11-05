namespace Lab2App
{
    partial class MushroomIdentifierForm
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
            this.pnlCandidatesCard = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.pnlMushroomList = new System.Windows.Forms.Panel();
            this.lblMush6 = new System.Windows.Forms.Label();
            this.lblMush5 = new System.Windows.Forms.Label();
            this.lblMush4 = new System.Windows.Forms.Label();
            this.lblMush3 = new System.Windows.Forms.Label();
            this.lblMush2 = new System.Windows.Forms.Label();
            this.lblMush1 = new System.Windows.Forms.Label();
            this.lblCandidatesDesc = new System.Windows.Forms.Label();
            this.lblCandidatesTitle = new System.Windows.Forms.Label();
            this.pnlQuestionCard = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.pnlHistoryCard = new System.Windows.Forms.Panel();
            this.lblHistoryList = new System.Windows.Forms.Label();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.pnlResultCard = new System.Windows.Forms.Panel();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblResultSummary = new System.Windows.Forms.Label();
            this.lblMushroomName = new System.Windows.Forms.Label();
            this.lblResultSubtitle = new System.Windows.Forms.Label();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCandidatesCard.SuspendLayout();
            this.pnlMushroomList.SuspendLayout();
            this.pnlQuestionCard.SuspendLayout();
            this.pnlHistoryCard.SuspendLayout();
            this.pnlResultCard.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(900, 75);
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
            this.btnBack.Location = new System.Drawing.Point(735, 20);
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
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(374, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Rule-based expert system identification using binary decision logic";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(465, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Problem 2: Mushroom Identification Game";
            // 
            // pnlCandidatesCard
            // 
            this.pnlCandidatesCard.BackColor = System.Drawing.Color.White;
            this.pnlCandidatesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCandidatesCard.Controls.Add(this.lblTip);
            this.pnlCandidatesCard.Controls.Add(this.pnlMushroomList);
            this.pnlCandidatesCard.Controls.Add(this.lblCandidatesDesc);
            this.pnlCandidatesCard.Controls.Add(this.lblCandidatesTitle);
            this.pnlCandidatesCard.Location = new System.Drawing.Point(27, 95);
            this.pnlCandidatesCard.Name = "pnlCandidatesCard";
            this.pnlCandidatesCard.Size = new System.Drawing.Size(280, 500);
            this.pnlCandidatesCard.TabIndex = 1;
            // 
            // lblTip
            // 
            this.lblTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTip.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTip.Location = new System.Drawing.Point(18, 385);
            this.lblTip.Name = "lblTip";
            this.lblTip.Padding = new System.Windows.Forms.Padding(8);
            this.lblTip.Size = new System.Drawing.Size(242, 95);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "How to play:\r\nPick one mushroom from the list above. Answer each question honestl" +
    "y with Yes or No to identify it!";
            // 
            // pnlMushroomList
            // 
            this.pnlMushroomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMushroomList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMushroomList.Controls.Add(this.lblMush6);
            this.pnlMushroomList.Controls.Add(this.lblMush5);
            this.pnlMushroomList.Controls.Add(this.lblMush4);
            this.pnlMushroomList.Controls.Add(this.lblMush3);
            this.pnlMushroomList.Controls.Add(this.lblMush2);
            this.pnlMushroomList.Controls.Add(this.lblMush1);
            this.pnlMushroomList.Location = new System.Drawing.Point(18, 90);
            this.pnlMushroomList.Name = "pnlMushroomList";
            this.pnlMushroomList.Size = new System.Drawing.Size(242, 275);
            this.pnlMushroomList.TabIndex = 2;
            // 
            // lblMush6
            // 
            this.lblMush6.AutoSize = true;
            this.lblMush6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMush6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMush6.Location = new System.Drawing.Point(15, 230);
            this.lblMush6.Name = "lblMush6";
            this.lblMush6.Size = new System.Drawing.Size(83, 17);
            this.lblMush6.TabIndex = 5;
            this.lblMush6.Text = "6. Pied bleu";
            // 
            // lblMush5
            // 
            this.lblMush5.AutoSize = true;
            this.lblMush5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMush5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMush5.Location = new System.Drawing.Point(15, 187);
            this.lblMush5.Name = "lblMush5";
            this.lblMush5.Size = new System.Drawing.Size(65, 17);
            this.lblMush5.TabIndex = 4;
            this.lblMush5.Text = "5. Girolle";
            // 
            // lblMush4
            // 
            this.lblMush4.AutoSize = true;
            this.lblMush4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMush4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMush4.Location = new System.Drawing.Point(15, 144);
            this.lblMush4.Name = "lblMush4";
            this.lblMush4.Size = new System.Drawing.Size(120, 17);
            this.lblMush4.TabIndex = 3;
            this.lblMush4.Text = "4. Coprin chevelu";
            // 
            // lblMush3
            // 
            this.lblMush3.AutoSize = true;
            this.lblMush3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMush3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMush3.Location = new System.Drawing.Point(15, 101);
            this.lblMush3.Name = "lblMush3";
            this.lblMush3.Size = new System.Drawing.Size(130, 17);
            this.lblMush3.TabIndex = 2;
            this.lblMush3.Text = "3. Cepe de bordeau";
            // 
            // lblMush2
            // 
            this.lblMush2.AutoSize = true;
            this.lblMush2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMush2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMush2.Location = new System.Drawing.Point(15, 58);
            this.lblMush2.Name = "lblMush2";
            this.lblMush2.Size = new System.Drawing.Size(155, 17);
            this.lblMush2.TabIndex = 1;
            this.lblMush2.Text = "2. Amanite tue-mouche";
            // 
            // lblMush1
            // 
            this.lblMush1.AutoSize = true;
            this.lblMush1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMush1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMush1.Location = new System.Drawing.Point(15, 15);
            this.lblMush1.Name = "lblMush1";
            this.lblMush1.Size = new System.Drawing.Size(130, 17);
            this.lblMush1.TabIndex = 0;
            this.lblMush1.Text = "1. Agaric Jaunissant";
            // 
            // lblCandidatesDesc
            // 
            this.lblCandidatesDesc.AutoSize = true;
            this.lblCandidatesDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCandidatesDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCandidatesDesc.Location = new System.Drawing.Point(16, 52);
            this.lblCandidatesDesc.Name = "lblCandidatesDesc";
            this.lblCandidatesDesc.Size = new System.Drawing.Size(217, 15);
            this.lblCandidatesDesc.TabIndex = 1;
            this.lblCandidatesDesc.Text = "Think of one species in your mind:";
            // 
            // lblCandidatesTitle
            // 
            this.lblCandidatesTitle.AutoSize = true;
            this.lblCandidatesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCandidatesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCandidatesTitle.Location = new System.Drawing.Point(15, 20);
            this.lblCandidatesTitle.Name = "lblCandidatesTitle";
            this.lblCandidatesTitle.Size = new System.Drawing.Size(183, 21);
            this.lblCandidatesTitle.TabIndex = 0;
            this.lblCandidatesTitle.Text = "Candidate Mushrooms";
            // 
            // pnlQuestionCard
            // 
            this.pnlQuestionCard.BackColor = System.Drawing.Color.White;
            this.pnlQuestionCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionCard.Controls.Add(this.btnRestart);
            this.pnlQuestionCard.Controls.Add(this.btnNo);
            this.pnlQuestionCard.Controls.Add(this.btnYes);
            this.pnlQuestionCard.Controls.Add(this.lblQuestionText);
            this.pnlQuestionCard.Controls.Add(this.lblStep);
            this.pnlQuestionCard.Location = new System.Drawing.Point(330, 95);
            this.pnlQuestionCard.Name = "pnlQuestionCard";
            this.pnlQuestionCard.Size = new System.Drawing.Size(550, 240);
            this.pnlQuestionCard.TabIndex = 2;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnRestart.Location = new System.Drawing.Point(405, 18);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 30);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "↺ Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(285, 150);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(200, 55);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "✖   NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(65, 150);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(200, 55);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "✔   YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblQuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblQuestionText.Location = new System.Drawing.Point(25, 65);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(500, 65);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Does your mushroom have a convex cup?";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblStep.Location = new System.Drawing.Point(25, 25);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(126, 17);
            this.lblStep.TabIndex = 0;
            this.lblStep.Text = "QUESTION 1 OF 3";
            // 
            // pnlHistoryCard
            // 
            this.pnlHistoryCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlHistoryCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistoryCard.Controls.Add(this.lblHistoryList);
            this.pnlHistoryCard.Controls.Add(this.lblHistoryTitle);
            this.pnlHistoryCard.Location = new System.Drawing.Point(330, 350);
            this.pnlHistoryCard.Name = "pnlHistoryCard";
            this.pnlHistoryCard.Size = new System.Drawing.Size(550, 110);
            this.pnlHistoryCard.TabIndex = 3;
            // 
            // lblHistoryList
            // 
            this.lblHistoryList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHistoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblHistoryList.Location = new System.Drawing.Point(20, 38);
            this.lblHistoryList.Name = "lblHistoryList";
            this.lblHistoryList.Size = new System.Drawing.Size(510, 60);
            this.lblHistoryList.TabIndex = 1;
            this.lblHistoryList.Text = "No questions answered yet. Start answering above!";
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblHistoryTitle.Location = new System.Drawing.Point(20, 12);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(130, 17);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Decision Sequence:";
            // 
            // pnlResultCard
            // 
            this.pnlResultCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnlResultCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultCard.Controls.Add(this.btnPlayAgain);
            this.pnlResultCard.Controls.Add(this.lblResultSummary);
            this.pnlResultCard.Controls.Add(this.lblMushroomName);
            this.pnlResultCard.Controls.Add(this.lblResultSubtitle);
            this.pnlResultCard.Controls.Add(this.lblResultTitle);
            this.pnlResultCard.Location = new System.Drawing.Point(330, 475);
            this.pnlResultCard.Name = "pnlResultCard";
            this.pnlResultCard.Size = new System.Drawing.Size(550, 120);
            this.pnlResultCard.TabIndex = 4;
            this.pnlResultCard.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(400, 38);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(130, 45);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblResultSummary
            // 
            this.lblResultSummary.AutoSize = true;
            this.lblResultSummary.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResultSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblResultSummary.Location = new System.Drawing.Point(20, 92);
            this.lblResultSummary.Name = "lblResultSummary";
            this.lblResultSummary.Size = new System.Drawing.Size(126, 15);
            this.lblResultSummary.TabIndex = 3;
            this.lblResultSummary.Text = "Identified in 2 questions";
            // 
            // lblMushroomName
            // 
            this.lblMushroomName.AutoSize = true;
            this.lblMushroomName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMushroomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.lblMushroomName.Location = new System.Drawing.Point(18, 55);
            this.lblMushroomName.Name = "lblMushroomName";
            this.lblMushroomName.Size = new System.Drawing.Size(258, 30);
            this.lblMushroomName.TabIndex = 2;
            this.lblMushroomName.Text = "Amanite tue-mouche";
            // 
            // lblResultSubtitle
            // 
            this.lblResultSubtitle.AutoSize = true;
            this.lblResultSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.lblResultSubtitle.Location = new System.Drawing.Point(20, 35);
            this.lblResultSubtitle.Name = "lblResultSubtitle";
            this.lblResultSubtitle.Size = new System.Drawing.Size(155, 15);
            this.lblResultSubtitle.TabIndex = 1;
            this.lblResultSubtitle.Text = "Your chosen mushroom is:";
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.lblResultTitle.Location = new System.Drawing.Point(19, 12);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(211, 20);
            this.lblResultTitle.TabIndex = 0;
            this.lblResultTitle.Text = "🎉 IDENTIFICATION SUCCESS";
            // 
            // MushroomIdentifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.pnlResultCard);
            this.Controls.Add(this.pnlHistoryCard);
            this.Controls.Add(this.pnlQuestionCard);
            this.Controls.Add(this.pnlCandidatesCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MushroomIdentifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mushroom Identification Game";
            this.Load += new System.EventHandler(this.MushroomIdentifierForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCandidatesCard.ResumeLayout(false);
            this.pnlCandidatesCard.PerformLayout();
            this.pnlMushroomList.ResumeLayout(false);
            this.pnlMushroomList.PerformLayout();
            this.pnlQuestionCard.ResumeLayout(false);
            this.pnlQuestionCard.PerformLayout();
            this.pnlHistoryCard.ResumeLayout(false);
            this.pnlHistoryCard.PerformLayout();
            this.pnlResultCard.ResumeLayout(false);
            this.pnlResultCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCandidatesCard;
        private System.Windows.Forms.Label lblCandidatesTitle;
        private System.Windows.Forms.Label lblCandidatesDesc;
        private System.Windows.Forms.Panel pnlMushroomList;
        private System.Windows.Forms.Label lblMush1;
        private System.Windows.Forms.Label lblMush2;
        private System.Windows.Forms.Label lblMush3;
        private System.Windows.Forms.Label lblMush4;
        private System.Windows.Forms.Label lblMush5;
        private System.Windows.Forms.Label lblMush6;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Panel pnlQuestionCard;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Label lblHistoryList;
        private System.Windows.Forms.Panel pnlResultCard;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResultSubtitle;
        private System.Windows.Forms.Label lblMushroomName;
        private System.Windows.Forms.Label lblResultSummary;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}
