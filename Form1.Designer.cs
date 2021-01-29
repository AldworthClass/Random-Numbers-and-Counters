namespace Random_Numbers_and_Counters
{
    partial class FormRandomCounter
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
            this.btnRandomize = new System.Windows.Forms.Button();
            this.lblRandomCounter = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomize
            // 
            this.btnRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(17, 12);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(313, 43);
            this.btnRandomize.TabIndex = 0;
            this.btnRandomize.Text = "Make Random Number";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // lblRandomCounter
            // 
            this.lblRandomCounter.AutoSize = true;
            this.lblRandomCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomCounter.Location = new System.Drawing.Point(12, 119);
            this.lblRandomCounter.Name = "lblRandomCounter";
            this.lblRandomCounter.Size = new System.Drawing.Size(256, 25);
            this.lblRandomCounter.TabIndex = 1;
            this.lblRandomCounter.Text = "0 random numbers made.";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(353, 21);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(24, 25);
            this.lblRandomNumber.TabIndex = 2;
            this.lblRandomNumber.Text = "0";
            // 
            // nudMin
            // 
            this.nudMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMin.Location = new System.Drawing.Point(116, 71);
            this.nudMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(45, 29);
            this.nudMin.TabIndex = 3;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(12, 72);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(98, 25);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minimum";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximum.Location = new System.Drawing.Point(181, 72);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(104, 25);
            this.lblMaximum.TabIndex = 6;
            this.lblMaximum.Text = "Maximum";
            // 
            // nudMax
            // 
            this.nudMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMax.Location = new System.Drawing.Point(285, 71);
            this.nudMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(45, 29);
            this.nudMax.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(347, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 43);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormRandomCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 167);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.lblRandomCounter);
            this.Controls.Add(this.btnRandomize);
            this.Name = "FormRandomCounter";
            this.Text = "Random Numbers and Counters";
            this.Load += new System.EventHandler(this.FormRandomCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Label lblRandomCounter;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Button btnReset;
    }
}

