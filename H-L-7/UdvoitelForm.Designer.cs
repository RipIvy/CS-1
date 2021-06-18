
namespace H_L_7
{
    partial class UdvoitelForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHowToPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblPurposeNumber = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblCurrentNumber = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblStepsNumber = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMaxSteps = new System.Windows.Forms.Label();
            this.lblMaxStepsNumber = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssilblCommands = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssilblCommandsNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWinLose);
            this.groupBox1.Controls.Add(this.lblMaxStepsNumber);
            this.groupBox1.Controls.Add(this.lblMaxSteps);
            this.groupBox1.Controls.Add(this.lblStepsNumber);
            this.groupBox1.Controls.Add(this.lblCurrent);
            this.groupBox1.Controls.Add(this.lblCurrentNumber);
            this.groupBox1.Controls.Add(this.lblSteps);
            this.groupBox1.Controls.Add(this.lblPurposeNumber);
            this.groupBox1.Controls.Add(this.lblPurpose);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnMulti);
            this.groupBox2.Controls.Add(this.btnPlus);
            this.groupBox2.Location = new System.Drawing.Point(178, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGame,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiGame
            // 
            this.tsmiGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiExit});
            this.tsmiGame.Name = "tsmiGame";
            this.tsmiGame.Size = new System.Drawing.Size(50, 20);
            this.tsmiGame.Text = "Game";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(180, 22);
            this.tsmiNew.Text = "New";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHowToPlay});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiHowToPlay
            // 
            this.tsmiHowToPlay.Name = "tsmiHowToPlay";
            this.tsmiHowToPlay.Size = new System.Drawing.Size(180, 22);
            this.tsmiHowToPlay.Text = "How to play";
            this.tsmiHowToPlay.Click += new System.EventHandler(this.tsmiHowToPlay_Click);
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurpose.Location = new System.Drawing.Point(6, 16);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(72, 20);
            this.lblPurpose.TabIndex = 0;
            this.lblPurpose.Text = "Purpose:";
            // 
            // lblPurposeNumber
            // 
            this.lblPurposeNumber.AutoSize = true;
            this.lblPurposeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPurposeNumber.Location = new System.Drawing.Point(84, 16);
            this.lblPurposeNumber.Name = "lblPurposeNumber";
            this.lblPurposeNumber.Size = new System.Drawing.Size(19, 20);
            this.lblPurposeNumber.TabIndex = 1;
            this.lblPurposeNumber.Text = "0";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSteps.Location = new System.Drawing.Point(6, 155);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(55, 20);
            this.lblSteps.TabIndex = 2;
            this.lblSteps.Text = "Steps:";
            // 
            // lblCurrentNumber
            // 
            this.lblCurrentNumber.AutoSize = true;
            this.lblCurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentNumber.Location = new System.Drawing.Point(78, 48);
            this.lblCurrentNumber.Name = "lblCurrentNumber";
            this.lblCurrentNumber.Size = new System.Drawing.Size(18, 20);
            this.lblCurrentNumber.TabIndex = 3;
            this.lblCurrentNumber.Text = "1";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrent.Location = new System.Drawing.Point(6, 48);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(66, 20);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "Current:";
            // 
            // lblStepsNumber
            // 
            this.lblStepsNumber.AutoSize = true;
            this.lblStepsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStepsNumber.Location = new System.Drawing.Point(67, 155);
            this.lblStepsNumber.Name = "lblStepsNumber";
            this.lblStepsNumber.Size = new System.Drawing.Size(18, 20);
            this.lblStepsNumber.TabIndex = 5;
            this.lblStepsNumber.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(6, 16);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(147, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMulti.Location = new System.Drawing.Point(6, 45);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(147, 23);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "x2";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(6, 155);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(6, 126);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMaxSteps
            // 
            this.lblMaxSteps.AutoSize = true;
            this.lblMaxSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxSteps.Location = new System.Drawing.Point(6, 126);
            this.lblMaxSteps.Name = "lblMaxSteps";
            this.lblMaxSteps.Size = new System.Drawing.Size(84, 20);
            this.lblMaxSteps.TabIndex = 6;
            this.lblMaxSteps.Text = "MaxSteps:";
            // 
            // lblMaxStepsNumber
            // 
            this.lblMaxStepsNumber.AutoSize = true;
            this.lblMaxStepsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxStepsNumber.Location = new System.Drawing.Point(96, 126);
            this.lblMaxStepsNumber.Name = "lblMaxStepsNumber";
            this.lblMaxStepsNumber.Size = new System.Drawing.Size(19, 20);
            this.lblMaxStepsNumber.TabIndex = 7;
            this.lblMaxStepsNumber.Text = "0";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinLose.ForeColor = System.Drawing.Color.Red;
            this.lblWinLose.Location = new System.Drawing.Point(37, 85);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(0, 24);
            this.lblWinLose.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssilblCommands,
            this.tssilblCommandsNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 217);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssilblCommands
            // 
            this.tssilblCommands.Name = "tssilblCommands";
            this.tssilblCommands.Size = new System.Drawing.Size(72, 17);
            this.tssilblCommands.Text = "Commands:";
            // 
            // tssilblCommandsNumber
            // 
            this.tssilblCommandsNumber.Name = "tssilblCommandsNumber";
            this.tssilblCommandsNumber.Size = new System.Drawing.Size(13, 17);
            this.tssilblCommandsNumber.Text = "0";
            // 
            // UdvoitelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 239);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UdvoitelForm";
            this.Text = "Udvoitel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHowToPlay;
        private System.Windows.Forms.Label lblStepsNumber;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblCurrentNumber;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblPurposeNumber;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMaxStepsNumber;
        private System.Windows.Forms.Label lblMaxSteps;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssilblCommands;
        private System.Windows.Forms.ToolStripStatusLabel tssilblCommandsNumber;
    }
}