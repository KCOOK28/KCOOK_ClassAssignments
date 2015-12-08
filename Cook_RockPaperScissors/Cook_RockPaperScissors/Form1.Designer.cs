namespace Cook_RockPaperScissors
{
    partial class frmMain
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.lblComChoice = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblComHealth = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblPlayerRoll = new System.Windows.Forms.Label();
            this.lblCompRoll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(18, 164);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(154, 63);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(205, 164);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(159, 63);
            this.btnPaper.TabIndex = 0;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(397, 164);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(154, 63);
            this.btnScissors.TabIndex = 0;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(415, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoice.Location = new System.Drawing.Point(45, 62);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(100, 63);
            this.lblPlayerChoice.TabIndex = 1;
            this.lblPlayerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComChoice
            // 
            this.lblComChoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblComChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComChoice.Location = new System.Drawing.Point(415, 62);
            this.lblComChoice.Name = "lblComChoice";
            this.lblComChoice.Size = new System.Drawing.Size(100, 63);
            this.lblComChoice.TabIndex = 1;
            this.lblComChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerHealth.Location = new System.Drawing.Point(62, 129);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(62, 32);
            this.lblPlayerHealth.TabIndex = 2;
            this.lblPlayerHealth.Text = "10";
            this.lblPlayerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComHealth
            // 
            this.lblComHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComHealth.ForeColor = System.Drawing.Color.Red;
            this.lblComHealth.Location = new System.Drawing.Point(437, 129);
            this.lblComHealth.Name = "lblComHealth";
            this.lblComHealth.Size = new System.Drawing.Size(62, 32);
            this.lblComHealth.TabIndex = 2;
            this.lblComHealth.Text = "10";
            this.lblComHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(151, 36);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(258, 89);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wins:";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(277, 5);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(37, 29);
            this.lblPlayerWins.TabIndex = 5;
            this.lblPlayerWins.Text = "0";
            this.lblPlayerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerRoll
            // 
            this.lblPlayerRoll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerRoll.Location = new System.Drawing.Point(4, 66);
            this.lblPlayerRoll.Name = "lblPlayerRoll";
            this.lblPlayerRoll.Size = new System.Drawing.Size(35, 59);
            this.lblPlayerRoll.TabIndex = 7;
            this.lblPlayerRoll.Text = "0\r\n";
            this.lblPlayerRoll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCompRoll
            // 
            this.lblCompRoll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCompRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompRoll.Location = new System.Drawing.Point(521, 66);
            this.lblCompRoll.Name = "lblCompRoll";
            this.lblCompRoll.Size = new System.Drawing.Size(35, 59);
            this.lblCompRoll.TabIndex = 7;
            this.lblCompRoll.Text = "0\r\n";
            this.lblCompRoll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(561, 243);
            this.Controls.Add(this.lblCompRoll);
            this.Controls.Add(this.lblPlayerRoll);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblComHealth);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblComChoice);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "frmMain";
            this.Text = "Rock, Paper, Scissors!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.Label lblComChoice;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblComHealth;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblPlayerRoll;
        private System.Windows.Forms.Label lblCompRoll;
    }
}

