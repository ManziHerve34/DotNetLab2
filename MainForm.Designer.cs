namespace Lab2App
{
    partial class MainForm
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
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlCardBicycle = new System.Windows.Forms.Panel();
            this.btnOpenBicycle = new System.Windows.Forms.Button();
            this.lblBicycleRates = new System.Windows.Forms.Label();
            this.lblBicycleDesc = new System.Windows.Forms.Label();
            this.lblBicycleTitle = new System.Windows.Forms.Label();
            this.lblBicycleBadge = new System.Windows.Forms.Label();
            this.pnlBicycleAccent = new System.Windows.Forms.Panel();
            this.pnlCardMushroom = new System.Windows.Forms.Panel();
            this.btnOpenMushroom = new System.Windows.Forms.Button();
            this.lblMushroomSpecies = new System.Windows.Forms.Label();
            this.lblMushroomDesc = new System.Windows.Forms.Label();
            this.lblMushroomTitle = new System.Windows.Forms.Label();
            this.lblMushroomBadge = new System.Windows.Forms.Label();
            this.pnlMushroomAccent = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCardBicycle.SuspendLayout();
            this.pnlCardMushroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(820, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(30, 48);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(437, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Bicycle Rental Pricing Calculator  •  Mushroom Identification Expert System";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(28, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(282, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "LAB 2 - MINI PROJECTS";
            // 
            // pnlCardBicycle
            // 
            this.pnlCardBicycle.BackColor = System.Drawing.Color.White;
            this.pnlCardBicycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardBicycle.Controls.Add(this.btnOpenBicycle);
            this.pnlCardBicycle.Controls.Add(this.lblBicycleRates);
            this.pnlCardBicycle.Controls.Add(this.lblBicycleDesc);
            this.pnlCardBicycle.Controls.Add(this.lblBicycleTitle);
            this.pnlCardBicycle.Controls.Add(this.lblBicycleBadge);
            this.pnlCardBicycle.Controls.Add(this.pnlBicycleAccent);
            this.pnlCardBicycle.Location = new System.Drawing.Point(34, 115);
            this.pnlCardBicycle.Name = "pnlCardBicycle";
            this.pnlCardBicycle.Size = new System.Drawing.Size(360, 310);
            this.pnlCardBicycle.TabIndex = 1;
            // 
            // btnOpenBicycle
            // 
            this.btnOpenBicycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnOpenBicycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBicycle.FlatAppearance.BorderSize = 0;
            this.btnOpenBicycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBicycle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenBicycle.ForeColor = System.Drawing.Color.White;
            this.btnOpenBicycle.Location = new System.Drawing.Point(22, 245);
            this.btnOpenBicycle.Name = "btnOpenBicycle";
            this.btnOpenBicycle.Size = new System.Drawing.Size(315, 45);
            this.btnOpenBicycle.TabIndex = 5;
            this.btnOpenBicycle.Text = "Open Bicycle Calculator  →";
            this.btnOpenBicycle.UseVisualStyleBackColor = false;
            this.btnOpenBicycle.Click += new System.EventHandler(this.btnOpenBicycle_Click);
            // 
            // lblBicycleRates
            // 
            this.lblBicycleRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lblBicycleRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBicycleRates.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBicycleRates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblBicycleRates.Location = new System.Drawing.Point(22, 135);
            this.lblBicycleRates.Name = "lblBicycleRates";
            this.lblBicycleRates.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.lblBicycleRates.Size = new System.Drawing.Size(315, 95);
            this.lblBicycleRates.TabIndex = 4;
            this.lblBicycleRates.Text = "• Night Hours (0-7, 21-24): 500 RWF / hr\r\n• Standard Hours (7-14, 19-21): 1,000 " +
    "RWF / hr\r\n• Peak Afternoon (14-19): 1,500 RWF / hr";
            // 
            // lblBicycleDesc
            // 
            this.lblBicycleDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBicycleDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBicycleDesc.Location = new System.Drawing.Point(20, 80);
            this.lblBicycleDesc.Name = "lblBicycleDesc";
            this.lblBicycleDesc.Size = new System.Drawing.Size(320, 48);
            this.lblBicycleDesc.TabIndex = 3;
            this.lblBicycleDesc.Text = "Input start and end hours to compute rental fees with validation and rate breakdo" +
    "wns.";
            // 
            // lblBicycleTitle
            // 
            this.lblBicycleTitle.AutoSize = true;
            this.lblBicycleTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBicycleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblBicycleTitle.Location = new System.Drawing.Point(18, 48);
            this.lblBicycleTitle.Name = "lblBicycleTitle";
            this.lblBicycleTitle.Size = new System.Drawing.Size(227, 25);
            this.lblBicycleTitle.TabIndex = 2;
            this.lblBicycleTitle.Text = "Bicycle Rental Calculator";
            // 
            // lblBicycleBadge
            // 
            this.lblBicycleBadge.AutoSize = true;
            this.lblBicycleBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBicycleBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblBicycleBadge.Location = new System.Drawing.Point(20, 24);
            this.lblBicycleBadge.Name = "lblBicycleBadge";
            this.lblBicycleBadge.Size = new System.Drawing.Size(73, 15);
            this.lblBicycleBadge.TabIndex = 1;
            this.lblBicycleBadge.Text = "PROBLEM 1";
            // 
            // pnlBicycleAccent
            // 
            this.pnlBicycleAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlBicycleAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBicycleAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlBicycleAccent.Name = "pnlBicycleAccent";
            this.pnlBicycleAccent.Size = new System.Drawing.Size(358, 6);
            this.pnlBicycleAccent.TabIndex = 0;
            // 
            // pnlCardMushroom
            // 
            this.pnlCardMushroom.BackColor = System.Drawing.Color.White;
            this.pnlCardMushroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardMushroom.Controls.Add(this.btnOpenMushroom);
            this.pnlCardMushroom.Controls.Add(this.lblMushroomSpecies);
            this.pnlCardMushroom.Controls.Add(this.lblMushroomDesc);
            this.pnlCardMushroom.Controls.Add(this.lblMushroomTitle);
            this.pnlCardMushroom.Controls.Add(this.lblMushroomBadge);
            this.pnlCardMushroom.Controls.Add(this.pnlMushroomAccent);
            this.pnlCardMushroom.Location = new System.Drawing.Point(424, 115);
            this.pnlCardMushroom.Name = "pnlCardMushroom";
            this.pnlCardMushroom.Size = new System.Drawing.Size(360, 310);
            this.pnlCardMushroom.TabIndex = 2;
            // 
            // btnOpenMushroom
            // 
            this.btnOpenMushroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnOpenMushroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenMushroom.FlatAppearance.BorderSize = 0;
            this.btnOpenMushroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMushroom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenMushroom.ForeColor = System.Drawing.Color.White;
            this.btnOpenMushroom.Location = new System.Drawing.Point(22, 245);
            this.btnOpenMushroom.Name = "btnOpenMushroom";
            this.btnOpenMushroom.Size = new System.Drawing.Size(315, 45);
            this.btnOpenMushroom.TabIndex = 5;
            this.btnOpenMushroom.Text = "Play Mushroom Game  →";
            this.btnOpenMushroom.UseVisualStyleBackColor = false;
            this.btnOpenMushroom.Click += new System.EventHandler(this.btnOpenMushroom_Click);
            // 
            // lblMushroomSpecies
            // 
            this.lblMushroomSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.lblMushroomSpecies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMushroomSpecies.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMushroomSpecies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblMushroomSpecies.Location = new System.Drawing.Point(22, 135);
            this.lblMushroomSpecies.Name = "lblMushroomSpecies";
            this.lblMushroomSpecies.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.lblMushroomSpecies.Size = new System.Drawing.Size(315, 95);
            this.lblMushroomSpecies.TabIndex = 4;
            this.lblMushroomSpecies.Text = "Identifies 6 unique species:\r\n• Agaric Jaunissant, Amanite tue-mouche\r\n• Cepe de " +
    "bordeau, Coprin chevelu\r\n• Girolle, Pied bleu";
            // 
            // lblMushroomDesc
            // 
            this.lblMushroomDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMushroomDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMushroomDesc.Location = new System.Drawing.Point(20, 80);
            this.lblMushroomDesc.Name = "lblMushroomDesc";
            this.lblMushroomDesc.Size = new System.Drawing.Size(320, 48);
            this.lblMushroomDesc.TabIndex = 3;
            this.lblMushroomDesc.Text = "Think of a mushroom and answer sequential Yes/No questions based on an expert dec" +
    "ision tree.";
            // 
            // lblMushroomTitle
            // 
            this.lblMushroomTitle.AutoSize = true;
            this.lblMushroomTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMushroomTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblMushroomTitle.Location = new System.Drawing.Point(18, 48);
            this.lblMushroomTitle.Name = "lblMushroomTitle";
            this.lblMushroomTitle.Size = new System.Drawing.Size(262, 25);
            this.lblMushroomTitle.TabIndex = 2;
            this.lblMushroomTitle.Text = "Mushroom Identification Game";
            // 
            // lblMushroomBadge
            // 
            this.lblMushroomBadge.AutoSize = true;
            this.lblMushroomBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMushroomBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lblMushroomBadge.Location = new System.Drawing.Point(20, 24);
            this.lblMushroomBadge.Name = "lblMushroomBadge";
            this.lblMushroomBadge.Size = new System.Drawing.Size(75, 15);
            this.lblMushroomBadge.TabIndex = 1;
            this.lblMushroomBadge.Text = "PROBLEM 2";
            // 
            // pnlMushroomAccent
            // 
            this.pnlMushroomAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.pnlMushroomAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMushroomAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlMushroomAccent.Name = "pnlMushroomAccent";
            this.pnlMushroomAccent.Size = new System.Drawing.Size(358, 6);
            this.pnlMushroomAccent.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnExit.Location = new System.Drawing.Point(644, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFooter.Location = new System.Drawing.Point(34, 462);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(262, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "C# .NET Windows Forms Application • Lab 2 Hub";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlCardMushroom);
            this.Controls.Add(this.pnlCardBicycle);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2: Mini Projects - Bicycle Rental & Mushroom Identification";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCardBicycle.ResumeLayout(false);
            this.pnlCardBicycle.PerformLayout();
            this.pnlCardMushroom.ResumeLayout(false);
            this.pnlCardMushroom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlCardBicycle;
        private System.Windows.Forms.Panel pnlBicycleAccent;
        private System.Windows.Forms.Label lblBicycleBadge;
        private System.Windows.Forms.Label lblBicycleTitle;
        private System.Windows.Forms.Label lblBicycleDesc;
        private System.Windows.Forms.Label lblBicycleRates;
        private System.Windows.Forms.Button btnOpenBicycle;
        private System.Windows.Forms.Panel pnlCardMushroom;
        private System.Windows.Forms.Panel pnlMushroomAccent;
        private System.Windows.Forms.Label lblMushroomBadge;
        private System.Windows.Forms.Label lblMushroomTitle;
        private System.Windows.Forms.Label lblMushroomDesc;
        private System.Windows.Forms.Label lblMushroomSpecies;
        private System.Windows.Forms.Button btnOpenMushroom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFooter;
    }
}
