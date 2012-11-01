namespace StringCompare
{
    partial class frmStringCompare
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
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtStringOne = new System.Windows.Forms.RichTextBox();
            this.rtxtStringTwo = new System.Windows.Forms.RichTextBox();
            this.lblOneCount = new System.Windows.Forms.Label();
            this.lblTwoCount = new System.Windows.Forms.Label();
            this.lblShouldBe = new System.Windows.Forms.Label();
            this.lblShouldBeDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "String Uno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "String Dos";
            // 
            // rtxtStringOne
            // 
            this.rtxtStringOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtStringOne.Location = new System.Drawing.Point(69, 6);
            this.rtxtStringOne.Multiline = false;
            this.rtxtStringOne.Name = "rtxtStringOne";
            this.rtxtStringOne.Size = new System.Drawing.Size(185, 20);
            this.rtxtStringOne.TabIndex = 4;
            this.rtxtStringOne.Text = "";
            this.rtxtStringOne.SelectionChanged += new System.EventHandler(this.rtxtString_SelectionChanged);
            this.rtxtStringOne.TextChanged += new System.EventHandler(this.rtxtString_Changed);
            this.rtxtStringOne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_KeyDown);
            // 
            // rtxtStringTwo
            // 
            this.rtxtStringTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtStringTwo.Location = new System.Drawing.Point(69, 32);
            this.rtxtStringTwo.Multiline = false;
            this.rtxtStringTwo.Name = "rtxtStringTwo";
            this.rtxtStringTwo.Size = new System.Drawing.Size(185, 20);
            this.rtxtStringTwo.TabIndex = 5;
            this.rtxtStringTwo.Text = "";
            this.rtxtStringTwo.TextChanged += new System.EventHandler(this.rtxtString_Changed);
            this.rtxtStringTwo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_KeyDown);
            // 
            // lblOneCount
            // 
            this.lblOneCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOneCount.AutoSize = true;
            this.lblOneCount.Location = new System.Drawing.Point(258, 6);
            this.lblOneCount.Name = "lblOneCount";
            this.lblOneCount.Size = new System.Drawing.Size(13, 13);
            this.lblOneCount.TabIndex = 6;
            this.lblOneCount.Text = "--";
            // 
            // lblTwoCount
            // 
            this.lblTwoCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTwoCount.AutoSize = true;
            this.lblTwoCount.Location = new System.Drawing.Point(258, 35);
            this.lblTwoCount.Name = "lblTwoCount";
            this.lblTwoCount.Size = new System.Drawing.Size(13, 13);
            this.lblTwoCount.TabIndex = 7;
            this.lblTwoCount.Text = "--";
            // 
            // lblShouldBe
            // 
            this.lblShouldBe.AutoSize = true;
            this.lblShouldBe.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShouldBe.Location = new System.Drawing.Point(161, 60);
            this.lblShouldBe.Name = "lblShouldBe";
            this.lblShouldBe.Size = new System.Drawing.Size(24, 17);
            this.lblShouldBe.TabIndex = 8;
            this.lblShouldBe.Text = "--";
            // 
            // lblShouldBeDesc
            // 
            this.lblShouldBeDesc.AutoSize = true;
            this.lblShouldBeDesc.Location = new System.Drawing.Point(88, 61);
            this.lblShouldBeDesc.Name = "lblShouldBeDesc";
            this.lblShouldBeDesc.Size = new System.Drawing.Size(59, 13);
            this.lblShouldBeDesc.TabIndex = 9;
            this.lblShouldBeDesc.Text = "Should Be:";
            // 
            // frmStringCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 85);
            this.Controls.Add(this.lblShouldBeDesc);
            this.Controls.Add(this.lblShouldBe);
            this.Controls.Add(this.lblTwoCount);
            this.Controls.Add(this.lblOneCount);
            this.Controls.Add(this.rtxtStringTwo);
            this.Controls.Add(this.rtxtStringOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 144);
            this.MinimumSize = new System.Drawing.Size(300, 20);
            this.Name = "frmStringCompare";
            this.Text = "String Compare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtStringOne;
        private System.Windows.Forms.RichTextBox rtxtStringTwo;
        private System.Windows.Forms.Label lblOneCount;
        private System.Windows.Forms.Label lblTwoCount;
        private System.Windows.Forms.Label lblShouldBe;
        private System.Windows.Forms.Label lblShouldBeDesc;
    }
}

