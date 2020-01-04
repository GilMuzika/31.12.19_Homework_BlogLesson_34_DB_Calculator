namespace _31._12._19_Homework_BlogLesson_34_DB_Calculator
{
    partial class MainForm
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
            this.lblEquality = new System.Windows.Forms.Label();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEquality
            // 
            this.lblEquality.AutoSize = true;
            this.lblEquality.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEquality.Location = new System.Drawing.Point(186, 17);
            this.lblEquality.Name = "lblEquality";
            this.lblEquality.Size = new System.Drawing.Size(24, 25);
            this.lblEquality.TabIndex = 3;
            this.lblEquality.Text = "=";
            // 
            // cmbOperation
            // 
            this.cmbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(78, 14);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(36, 33);
            this.cmbOperation.TabIndex = 4;
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtX.Location = new System.Drawing.Point(12, 14);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(59, 30);
            this.txtX.TabIndex = 5;
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtY.Location = new System.Drawing.Point(120, 14);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(59, 30);
            this.txtY.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(206, 17);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 25);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "result";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 55);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 90);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.lblEquality);
            this.Name = "MainForm";
            this.Text = "DB calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEquality;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
    }
}

