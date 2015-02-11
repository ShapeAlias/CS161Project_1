namespace Project_1
{


    // THis was all auto generated for me and it commented itself, this basically generates my form based on what I did in form designer



    partial class Project_1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRandDot = new System.Windows.Forms.Button();
            this.btnGradient = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnGenShape = new System.Windows.Forms.Button();
            this.lblPaintTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalTimeVal = new System.Windows.Forms.Label();
            this.lblDotsPerSecVal = new System.Windows.Forms.Label();
            this.paintPanel = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.nbxPenWidth = new System.Windows.Forms.NumericUpDown();
            this.cbxFilled = new System.Windows.Forms.CheckBox();
            this.pbarLoad = new System.Windows.Forms.ProgressBar();
            this.nbxRed = new System.Windows.Forms.NumericUpDown();
            this.nbxGreen = new System.Windows.Forms.NumericUpDown();
            this.nbxBlue = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Blue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            this.cbxShapes = new System.Windows.Forms.ComboBox();
            this.lblShapes = new System.Windows.Forms.Label();
            this.btnRotatePics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintPanel)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbxPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxBlue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 26);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRandDot
            // 
            this.btnRandDot.Location = new System.Drawing.Point(482, 108);
            this.btnRandDot.Name = "btnRandDot";
            this.btnRandDot.Size = new System.Drawing.Size(88, 26);
            this.btnRandDot.TabIndex = 1;
            this.btnRandDot.Text = "Random Dots";
            this.btnRandDot.UseVisualStyleBackColor = true;
            this.btnRandDot.Click += new System.EventHandler(this.btnRandDot_Click);
            // 
            // btnGradient
            // 
            this.btnGradient.Location = new System.Drawing.Point(482, 76);
            this.btnGradient.Name = "btnGradient";
            this.btnGradient.Size = new System.Drawing.Size(88, 26);
            this.btnGradient.TabIndex = 2;
            this.btnGradient.Text = "Gradient";
            this.btnGradient.UseVisualStyleBackColor = true;
            this.btnGradient.Click += new System.EventHandler(this.btnGradient_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(482, 289);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 26);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(482, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 26);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnGenShape
            // 
            this.btnGenShape.Location = new System.Drawing.Point(482, 12);
            this.btnGenShape.Name = "btnGenShape";
            this.btnGenShape.Size = new System.Drawing.Size(88, 26);
            this.btnGenShape.TabIndex = 5;
            this.btnGenShape.Text = "Gen Shape";
            this.btnGenShape.UseVisualStyleBackColor = true;
            this.btnGenShape.Click += new System.EventHandler(this.btnGenShape_Click);
            // 
            // lblPaintTime
            // 
            this.lblPaintTime.AutoSize = true;
            this.lblPaintTime.Location = new System.Drawing.Point(9, 302);
            this.lblPaintTime.Name = "lblPaintTime";
            this.lblPaintTime.Size = new System.Drawing.Size(110, 13);
            this.lblPaintTime.TabIndex = 8;
            this.lblPaintTime.Text = "Total Execution Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pixels per Second:";
            // 
            // lblTotalTimeVal
            // 
            this.lblTotalTimeVal.AutoSize = true;
            this.lblTotalTimeVal.Location = new System.Drawing.Point(125, 302);
            this.lblTotalTimeVal.Name = "lblTotalTimeVal";
            this.lblTotalTimeVal.Size = new System.Drawing.Size(22, 13);
            this.lblTotalTimeVal.TabIndex = 10;
            this.lblTotalTimeVal.Text = "NA";
            // 
            // lblDotsPerSecVal
            // 
            this.lblDotsPerSecVal.AutoSize = true;
            this.lblDotsPerSecVal.Location = new System.Drawing.Point(110, 325);
            this.lblDotsPerSecVal.Name = "lblDotsPerSecVal";
            this.lblDotsPerSecVal.Size = new System.Drawing.Size(22, 13);
            this.lblDotsPerSecVal.TabIndex = 11;
            this.lblDotsPerSecVal.Text = "NA";
            // 
            // paintPanel
            // 
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Location = new System.Drawing.Point(12, 12);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(464, 278);
            this.paintPanel.TabIndex = 12;
            this.paintPanel.TabStop = false;
            this.paintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPenWidth);
            this.groupBox2.Controls.Add(this.nbxPenWidth);
            this.groupBox2.Controls.Add(this.cbxFilled);
            this.groupBox2.Location = new System.Drawing.Point(358, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DrawOptions";
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.Location = new System.Drawing.Point(59, 16);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(57, 13);
            this.lblPenWidth.TabIndex = 1;
            this.lblPenWidth.Text = "PenWidth:";
            // 
            // nbxPenWidth
            // 
            this.nbxPenWidth.DecimalPlaces = 1;
            this.nbxPenWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nbxPenWidth.Location = new System.Drawing.Point(62, 33);
            this.nbxPenWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbxPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nbxPenWidth.Name = "nbxPenWidth";
            this.nbxPenWidth.Size = new System.Drawing.Size(47, 20);
            this.nbxPenWidth.TabIndex = 1;
            this.nbxPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // cbxFilled
            // 
            this.cbxFilled.AutoSize = true;
            this.cbxFilled.Location = new System.Drawing.Point(6, 28);
            this.cbxFilled.Name = "cbxFilled";
            this.cbxFilled.Size = new System.Drawing.Size(50, 17);
            this.cbxFilled.TabIndex = 0;
            this.cbxFilled.Text = "Filled";
            this.cbxFilled.UseVisualStyleBackColor = true;
            // 
            // pbarLoad
            // 
            this.pbarLoad.Location = new System.Drawing.Point(128, 140);
            this.pbarLoad.Name = "pbarLoad";
            this.pbarLoad.Size = new System.Drawing.Size(210, 23);
            this.pbarLoad.Step = 1;
            this.pbarLoad.TabIndex = 14;
            this.pbarLoad.Visible = false;
            // 
            // nbxRed
            // 
            this.nbxRed.Location = new System.Drawing.Point(6, 33);
            this.nbxRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbxRed.Name = "nbxRed";
            this.nbxRed.Size = new System.Drawing.Size(44, 20);
            this.nbxRed.TabIndex = 15;
            this.nbxRed.ValueChanged += new System.EventHandler(this.nbxRed_ValueChanged);
            // 
            // nbxGreen
            // 
            this.nbxGreen.Location = new System.Drawing.Point(54, 33);
            this.nbxGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbxGreen.Name = "nbxGreen";
            this.nbxGreen.Size = new System.Drawing.Size(44, 20);
            this.nbxGreen.TabIndex = 16;
            this.nbxGreen.ValueChanged += new System.EventHandler(this.nbxGreen_ValueChanged);
            // 
            // nbxBlue
            // 
            this.nbxBlue.Location = new System.Drawing.Point(104, 34);
            this.nbxBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbxBlue.Name = "nbxBlue";
            this.nbxBlue.Size = new System.Drawing.Size(44, 20);
            this.nbxBlue.TabIndex = 17;
            this.nbxBlue.ValueChanged += new System.EventHandler(this.nbxBlue_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Blue);
            this.groupBox3.Controls.Add(this.lblGreen);
            this.groupBox3.Controls.Add(this.lblRed);
            this.groupBox3.Controls.Add(this.nbxRed);
            this.groupBox3.Controls.Add(this.nbxBlue);
            this.groupBox3.Controls.Add(this.nbxGreen);
            this.groupBox3.Location = new System.Drawing.Point(198, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 54);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pen Color";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(113, 18);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(28, 13);
            this.Blue.TabIndex = 20;
            this.Blue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(63, 18);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 19;
            this.lblGreen.Text = "Green";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(15, 18);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 18;
            this.lblRed.Text = "Red";
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(482, 140);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(88, 26);
            this.btnPicture.TabIndex = 19;
            this.btnPicture.Text = "Gen Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // cbxShapes
            // 
            this.cbxShapes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxShapes.DisplayMember = "Rectangle";
            this.cbxShapes.FormattingEnabled = true;
            this.cbxShapes.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle",
            "Football"});
            this.cbxShapes.Location = new System.Drawing.Point(482, 262);
            this.cbxShapes.Name = "cbxShapes";
            this.cbxShapes.Size = new System.Drawing.Size(81, 21);
            this.cbxShapes.TabIndex = 20;
            this.cbxShapes.Text = "Rectangle";
            this.cbxShapes.ValueMember = "Rectangle";
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.Location = new System.Drawing.Point(503, 246);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(43, 13);
            this.lblShapes.TabIndex = 21;
            this.lblShapes.Text = "Shapes";
            // 
            // btnRotatePics
            // 
            this.btnRotatePics.Location = new System.Drawing.Point(482, 172);
            this.btnRotatePics.Name = "btnRotatePics";
            this.btnRotatePics.Size = new System.Drawing.Size(88, 26);
            this.btnRotatePics.TabIndex = 22;
            this.btnRotatePics.Text = "Rotate Picture";
            this.btnRotatePics.UseVisualStyleBackColor = true;
            this.btnRotatePics.Click += new System.EventHandler(this.btnRotatePics_Click);
            // 
            // Project_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 353);
            this.Controls.Add(this.btnRotatePics);
            this.Controls.Add(this.lblShapes);
            this.Controls.Add(this.cbxShapes);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pbarLoad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.lblDotsPerSecVal);
            this.Controls.Add(this.lblTotalTimeVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPaintTime);
            this.Controls.Add(this.btnGenShape);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGradient);
            this.Controls.Add(this.btnRandDot);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Project_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project_1";
            ((System.ComponentModel.ISupportInitialize)(this.paintPanel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbxPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbxBlue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRandDot;
        private System.Windows.Forms.Button btnGradient;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnGenShape;
        private System.Windows.Forms.Label lblPaintTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalTimeVal;
        private System.Windows.Forms.Label lblDotsPerSecVal;
        private System.Windows.Forms.PictureBox paintPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPenWidth;
        private System.Windows.Forms.NumericUpDown nbxPenWidth;
        private System.Windows.Forms.CheckBox cbxFilled;
        private System.Windows.Forms.ProgressBar pbarLoad;
        private System.Windows.Forms.NumericUpDown nbxRed;
        private System.Windows.Forms.NumericUpDown nbxGreen;
        private System.Windows.Forms.NumericUpDown nbxBlue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.ComboBox cbxShapes;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.Button btnRotatePics;
    }
}

