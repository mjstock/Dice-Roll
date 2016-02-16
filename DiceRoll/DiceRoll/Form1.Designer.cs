namespace DiceRoll
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstRoll1 = new System.Windows.Forms.ListBox();
            this.pctDice1List1 = new System.Windows.Forms.PictureBox();
            this.pctDice2List1 = new System.Windows.Forms.PictureBox();
            this.chkDisableList1 = new System.Windows.Forms.CheckBox();
            this.chkDisableList2 = new System.Windows.Forms.CheckBox();
            this.pctDice2List2 = new System.Windows.Forms.PictureBox();
            this.pctDice1List2 = new System.Windows.Forms.PictureBox();
            this.lstRoll2 = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstExcept = new System.Windows.Forms.ListBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtSelectedTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice1List1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice2List1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice2List2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice1List2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll the Dice";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(244, 421);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 741);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstRoll1
            // 
            this.lstRoll1.FormattingEnabled = true;
            this.lstRoll1.Location = new System.Drawing.Point(47, 134);
            this.lstRoll1.Name = "lstRoll1";
            this.lstRoll1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRoll1.Size = new System.Drawing.Size(212, 251);
            this.lstRoll1.TabIndex = 4;
            // 
            // pctDice1List1
            // 
            this.pctDice1List1.Location = new System.Drawing.Point(47, 60);
            this.pctDice1List1.Name = "pctDice1List1";
            this.pctDice1List1.Size = new System.Drawing.Size(75, 65);
            this.pctDice1List1.TabIndex = 5;
            this.pctDice1List1.TabStop = false;
            // 
            // pctDice2List1
            // 
            this.pctDice2List1.Location = new System.Drawing.Point(184, 60);
            this.pctDice2List1.Name = "pctDice2List1";
            this.pctDice2List1.Size = new System.Drawing.Size(75, 65);
            this.pctDice2List1.TabIndex = 6;
            this.pctDice2List1.TabStop = false;
            // 
            // chkDisableList1
            // 
            this.chkDisableList1.AutoSize = true;
            this.chkDisableList1.Location = new System.Drawing.Point(99, 391);
            this.chkDisableList1.Name = "chkDisableList1";
            this.chkDisableList1.Size = new System.Drawing.Size(110, 17);
            this.chkDisableList1.TabIndex = 7;
            this.chkDisableList1.Text = "Disable Animation";
            this.chkDisableList1.UseVisualStyleBackColor = true;
            // 
            // chkDisableList2
            // 
            this.chkDisableList2.AutoSize = true;
            this.chkDisableList2.Location = new System.Drawing.Point(353, 391);
            this.chkDisableList2.Name = "chkDisableList2";
            this.chkDisableList2.Size = new System.Drawing.Size(110, 17);
            this.chkDisableList2.TabIndex = 11;
            this.chkDisableList2.Text = "Disable Animation";
            this.chkDisableList2.UseVisualStyleBackColor = true;
            // 
            // pctDice2List2
            // 
            this.pctDice2List2.Location = new System.Drawing.Point(438, 60);
            this.pctDice2List2.Name = "pctDice2List2";
            this.pctDice2List2.Size = new System.Drawing.Size(75, 65);
            this.pctDice2List2.TabIndex = 10;
            this.pctDice2List2.TabStop = false;
            // 
            // pctDice1List2
            // 
            this.pctDice1List2.Location = new System.Drawing.Point(301, 60);
            this.pctDice1List2.Name = "pctDice1List2";
            this.pctDice1List2.Size = new System.Drawing.Size(75, 65);
            this.pctDice1List2.TabIndex = 9;
            this.pctDice1List2.TabStop = false;
            // 
            // lstRoll2
            // 
            this.lstRoll2.FormattingEnabled = true;
            this.lstRoll2.Location = new System.Drawing.Point(301, 134);
            this.lstRoll2.Name = "lstRoll2";
            this.lstRoll2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstRoll2.Size = new System.Drawing.Size(212, 251);
            this.lstRoll2.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(244, 466);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Selected";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lstExcept
            // 
            this.lstExcept.FormattingEnabled = true;
            this.lstExcept.Location = new System.Drawing.Point(47, 507);
            this.lstExcept.Name = "lstExcept";
            this.lstExcept.Size = new System.Drawing.Size(212, 225);
            this.lstExcept.TabIndex = 13;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(265, 709);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 14;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtSelectedTotal
            // 
            this.txtSelectedTotal.Location = new System.Drawing.Point(339, 466);
            this.txtSelectedTotal.Name = "txtSelectedTotal";
            this.txtSelectedTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSelectedTotal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 776);
            this.Controls.Add(this.txtSelectedTotal);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lstExcept);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.chkDisableList2);
            this.Controls.Add(this.pctDice2List2);
            this.Controls.Add(this.pctDice1List2);
            this.Controls.Add(this.lstRoll2);
            this.Controls.Add(this.chkDisableList1);
            this.Controls.Add(this.pctDice2List1);
            this.Controls.Add(this.pctDice1List1);
            this.Controls.Add(this.lstRoll1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDice1List1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice2List1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice2List2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDice1List2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstRoll1;
        private System.Windows.Forms.PictureBox pctDice1List1;
        private System.Windows.Forms.PictureBox pctDice2List1;
        private System.Windows.Forms.CheckBox chkDisableList1;
        private System.Windows.Forms.CheckBox chkDisableList2;
        private System.Windows.Forms.PictureBox pctDice2List2;
        private System.Windows.Forms.PictureBox pctDice1List2;
        private System.Windows.Forms.ListBox lstRoll2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lstExcept;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtSelectedTotal;
    }
}

