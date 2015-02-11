namespace Project_1
{

    //all auto generated based on form designer and auto commented

    partial class DotInput
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtbxDots = new System.Windows.Forms.TextBox();
            this.lblInputDots = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(97, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtbxDots
            // 
            this.txtbxDots.Location = new System.Drawing.Point(65, 72);
            this.txtbxDots.Name = "txtbxDots";
            this.txtbxDots.Size = new System.Drawing.Size(142, 20);
            this.txtbxDots.TabIndex = 1;
            this.txtbxDots.TextChanged += new System.EventHandler(this.txtbxDots_TextChanged);
            // 
            // lblInputDots
            // 
            this.lblInputDots.AutoSize = true;
            this.lblInputDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDots.Location = new System.Drawing.Point(34, 30);
            this.lblInputDots.Name = "lblInputDots";
            this.lblInputDots.Size = new System.Drawing.Size(220, 25);
            this.lblInputDots.TabIndex = 2;
            this.lblInputDots.Text = "Input Number of Dots:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warning: Large numbers may take some time to load";
            // 
            // DotInput
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 160);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInputDots);
            this.Controls.Add(this.txtbxDots);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DotInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtbxDots;
        private System.Windows.Forms.Label lblInputDots;
        private System.Windows.Forms.Label label1;
    }
}