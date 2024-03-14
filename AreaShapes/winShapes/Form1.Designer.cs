namespace winShapes
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
            this.lblOpOne = new System.Windows.Forms.Label();
            this.txbOptions = new System.Windows.Forms.TextBox();
            this.grbACO = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOpFour = new System.Windows.Forms.Label();
            this.lblOpThree = new System.Windows.Forms.Label();
            this.lnlOpTwo = new System.Windows.Forms.Label();
            this.grbRectangle = new System.Windows.Forms.GroupBox();
            this.btnReturnRec = new System.Windows.Forms.Button();
            this.btnCalcRec = new System.Windows.Forms.Button();
            this.txbWidthRec = new System.Windows.Forms.TextBox();
            this.txbLengthRec = new System.Windows.Forms.TextBox();
            this.lblWidthRec = new System.Windows.Forms.Label();
            this.lblLengthRec = new System.Windows.Forms.Label();
            this.grbCircle = new System.Windows.Forms.GroupBox();
            this.btnReturnCir = new System.Windows.Forms.Button();
            this.btnCalcCir = new System.Windows.Forms.Button();
            this.txbRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.grbTriangle = new System.Windows.Forms.GroupBox();
            this.btnReturnTri = new System.Windows.Forms.Button();
            this.btnCalcTri = new System.Windows.Forms.Button();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.txbBaseLength = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBaseLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbACO.SuspendLayout();
            this.grbRectangle.SuspendLayout();
            this.grbCircle.SuspendLayout();
            this.grbTriangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOpOne
            // 
            this.lblOpOne.AutoSize = true;
            this.lblOpOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpOne.Location = new System.Drawing.Point(36, 30);
            this.lblOpOne.Name = "lblOpOne";
            this.lblOpOne.Size = new System.Drawing.Size(111, 18);
            this.lblOpOne.TabIndex = 0;
            this.lblOpOne.Text = "[ 1 ] - Rectangle";
            // 
            // txbOptions
            // 
            this.txbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOptions.Location = new System.Drawing.Point(155, 163);
            this.txbOptions.Name = "txbOptions";
            this.txbOptions.Size = new System.Drawing.Size(100, 24);
            this.txbOptions.TabIndex = 1;
            // 
            // grbACO
            // 
            this.grbACO.Controls.Add(this.btnEnter);
            this.grbACO.Controls.Add(this.label5);
            this.grbACO.Controls.Add(this.txbOptions);
            this.grbACO.Controls.Add(this.lblOpFour);
            this.grbACO.Controls.Add(this.lblOpThree);
            this.grbACO.Controls.Add(this.lnlOpTwo);
            this.grbACO.Controls.Add(this.lblOpOne);
            this.grbACO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbACO.Location = new System.Drawing.Point(33, 79);
            this.grbACO.Name = "grbACO";
            this.grbACO.Size = new System.Drawing.Size(283, 242);
            this.grbACO.TabIndex = 2;
            this.grbACO.TabStop = false;
            this.grbACO.Text = "Area Calculator Options:";
            this.grbACO.Enter += new System.EventHandler(this.grbACO_Enter);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(164, 193);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 26);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Option:";
            // 
            // lblOpFour
            // 
            this.lblOpFour.AutoSize = true;
            this.lblOpFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpFour.Location = new System.Drawing.Point(36, 129);
            this.lblOpFour.Name = "lblOpFour";
            this.lblOpFour.Size = new System.Drawing.Size(69, 18);
            this.lblOpFour.TabIndex = 3;
            this.lblOpFour.Text = "[ 4 ] - Exit";
            // 
            // lblOpThree
            // 
            this.lblOpThree.AutoSize = true;
            this.lblOpThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpThree.Location = new System.Drawing.Point(36, 97);
            this.lblOpThree.Name = "lblOpThree";
            this.lblOpThree.Size = new System.Drawing.Size(97, 18);
            this.lblOpThree.TabIndex = 2;
            this.lblOpThree.Text = "[ 3 ] - Triangle";
            // 
            // lnlOpTwo
            // 
            this.lnlOpTwo.AutoSize = true;
            this.lnlOpTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlOpTwo.Location = new System.Drawing.Point(36, 64);
            this.lnlOpTwo.Name = "lnlOpTwo";
            this.lnlOpTwo.Size = new System.Drawing.Size(83, 18);
            this.lnlOpTwo.TabIndex = 1;
            this.lnlOpTwo.Text = "[ 2 ] - Circle";
            // 
            // grbRectangle
            // 
            this.grbRectangle.Controls.Add(this.btnReturnRec);
            this.grbRectangle.Controls.Add(this.btnCalcRec);
            this.grbRectangle.Controls.Add(this.txbWidthRec);
            this.grbRectangle.Controls.Add(this.txbLengthRec);
            this.grbRectangle.Controls.Add(this.lblWidthRec);
            this.grbRectangle.Controls.Add(this.lblLengthRec);
            this.grbRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRectangle.Location = new System.Drawing.Point(38, 109);
            this.grbRectangle.Name = "grbRectangle";
            this.grbRectangle.Size = new System.Drawing.Size(283, 136);
            this.grbRectangle.TabIndex = 5;
            this.grbRectangle.TabStop = false;
            this.grbRectangle.Text = "Rectangle Area Calculator:";
            this.grbRectangle.Visible = false;
            this.grbRectangle.Enter += new System.EventHandler(this.grbRectangle_Enter);
            // 
            // btnReturnRec
            // 
            this.btnReturnRec.Location = new System.Drawing.Point(39, 99);
            this.btnReturnRec.Name = "btnReturnRec";
            this.btnReturnRec.Size = new System.Drawing.Size(75, 25);
            this.btnReturnRec.TabIndex = 7;
            this.btnReturnRec.Text = "Return";
            this.btnReturnRec.UseVisualStyleBackColor = true;
            this.btnReturnRec.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCalcRec
            // 
            this.btnCalcRec.Location = new System.Drawing.Point(186, 97);
            this.btnCalcRec.Name = "btnCalcRec";
            this.btnCalcRec.Size = new System.Drawing.Size(86, 28);
            this.btnCalcRec.TabIndex = 6;
            this.btnCalcRec.Text = "Calculate";
            this.btnCalcRec.UseVisualStyleBackColor = true;
            this.btnCalcRec.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbWidthRec
            // 
            this.txbWidthRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWidthRec.Location = new System.Drawing.Point(118, 64);
            this.txbWidthRec.Name = "txbWidthRec";
            this.txbWidthRec.Size = new System.Drawing.Size(100, 24);
            this.txbWidthRec.TabIndex = 2;
            // 
            // txbLengthRec
            // 
            this.txbLengthRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLengthRec.Location = new System.Drawing.Point(118, 30);
            this.txbLengthRec.Name = "txbLengthRec";
            this.txbLengthRec.Size = new System.Drawing.Size(100, 24);
            this.txbLengthRec.TabIndex = 1;
            // 
            // lblWidthRec
            // 
            this.lblWidthRec.AutoSize = true;
            this.lblWidthRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthRec.Location = new System.Drawing.Point(36, 64);
            this.lblWidthRec.Name = "lblWidthRec";
            this.lblWidthRec.Size = new System.Drawing.Size(50, 18);
            this.lblWidthRec.TabIndex = 1;
            this.lblWidthRec.Text = "Width:";
            // 
            // lblLengthRec
            // 
            this.lblLengthRec.AutoSize = true;
            this.lblLengthRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthRec.Location = new System.Drawing.Point(36, 30);
            this.lblLengthRec.Name = "lblLengthRec";
            this.lblLengthRec.Size = new System.Drawing.Size(56, 18);
            this.lblLengthRec.TabIndex = 0;
            this.lblLengthRec.Text = "Length:";
            // 
            // grbCircle
            // 
            this.grbCircle.Controls.Add(this.btnReturnCir);
            this.grbCircle.Controls.Add(this.btnCalcCir);
            this.grbCircle.Controls.Add(this.txbRadius);
            this.grbCircle.Controls.Add(this.lblRadius);
            this.grbCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCircle.Location = new System.Drawing.Point(38, 125);
            this.grbCircle.Name = "grbCircle";
            this.grbCircle.Size = new System.Drawing.Size(283, 111);
            this.grbCircle.TabIndex = 8;
            this.grbCircle.TabStop = false;
            this.grbCircle.Text = "Circle Area Calculator:";
            this.grbCircle.Visible = false;
            // 
            // btnReturnCir
            // 
            this.btnReturnCir.Location = new System.Drawing.Point(39, 67);
            this.btnReturnCir.Name = "btnReturnCir";
            this.btnReturnCir.Size = new System.Drawing.Size(75, 26);
            this.btnReturnCir.TabIndex = 7;
            this.btnReturnCir.Text = "Return";
            this.btnReturnCir.UseVisualStyleBackColor = true;
            this.btnReturnCir.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCalcCir
            // 
            this.btnCalcCir.Location = new System.Drawing.Point(186, 68);
            this.btnCalcCir.Name = "btnCalcCir";
            this.btnCalcCir.Size = new System.Drawing.Size(86, 25);
            this.btnCalcCir.TabIndex = 6;
            this.btnCalcCir.Text = "Calculate";
            this.btnCalcCir.UseVisualStyleBackColor = true;
            this.btnCalcCir.Click += new System.EventHandler(this.button5_Click);
            // 
            // txbRadius
            // 
            this.txbRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRadius.Location = new System.Drawing.Point(118, 30);
            this.txbRadius.Name = "txbRadius";
            this.txbRadius.Size = new System.Drawing.Size(100, 24);
            this.txbRadius.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(36, 30);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(58, 18);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius:";
            // 
            // grbTriangle
            // 
            this.grbTriangle.Controls.Add(this.btnReturnTri);
            this.grbTriangle.Controls.Add(this.btnCalcTri);
            this.grbTriangle.Controls.Add(this.txbHeight);
            this.grbTriangle.Controls.Add(this.txbBaseLength);
            this.grbTriangle.Controls.Add(this.lblHeight);
            this.grbTriangle.Controls.Add(this.lblBaseLength);
            this.grbTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTriangle.Location = new System.Drawing.Point(38, 105);
            this.grbTriangle.Name = "grbTriangle";
            this.grbTriangle.Size = new System.Drawing.Size(283, 140);
            this.grbTriangle.TabIndex = 8;
            this.grbTriangle.TabStop = false;
            this.grbTriangle.Text = "Triangle Area Calculator:";
            this.grbTriangle.Visible = false;
            // 
            // btnReturnTri
            // 
            this.btnReturnTri.Location = new System.Drawing.Point(39, 105);
            this.btnReturnTri.Name = "btnReturnTri";
            this.btnReturnTri.Size = new System.Drawing.Size(75, 26);
            this.btnReturnTri.TabIndex = 7;
            this.btnReturnTri.Text = "Return";
            this.btnReturnTri.UseVisualStyleBackColor = true;
            this.btnReturnTri.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCalcTri
            // 
            this.btnCalcTri.Location = new System.Drawing.Point(186, 105);
            this.btnCalcTri.Name = "btnCalcTri";
            this.btnCalcTri.Size = new System.Drawing.Size(86, 26);
            this.btnCalcTri.TabIndex = 6;
            this.btnCalcTri.Text = "Calculate";
            this.btnCalcTri.UseVisualStyleBackColor = true;
            this.btnCalcTri.Click += new System.EventHandler(this.button7_Click);
            // 
            // txbHeight
            // 
            this.txbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHeight.Location = new System.Drawing.Point(134, 64);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(100, 24);
            this.txbHeight.TabIndex = 2;
            // 
            // txbBaseLength
            // 
            this.txbBaseLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBaseLength.Location = new System.Drawing.Point(134, 30);
            this.txbBaseLength.Name = "txbBaseLength";
            this.txbBaseLength.Size = new System.Drawing.Size(100, 24);
            this.txbBaseLength.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(36, 64);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(54, 18);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height:";
            // 
            // lblBaseLength
            // 
            this.lblBaseLength.AutoSize = true;
            this.lblBaseLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseLength.Location = new System.Drawing.Point(36, 30);
            this.lblBaseLength.Name = "lblBaseLength";
            this.lblBaseLength.Size = new System.Drawing.Size(94, 18);
            this.lblBaseLength.TabIndex = 0;
            this.lblBaseLength.Text = "Base Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "SHAPE AREA CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTriangle);
            this.Controls.Add(this.grbCircle);
            this.Controls.Add(this.grbACO);
            this.Controls.Add(this.grbRectangle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shapes Area Calculator";
            this.grbACO.ResumeLayout(false);
            this.grbACO.PerformLayout();
            this.grbRectangle.ResumeLayout(false);
            this.grbRectangle.PerformLayout();
            this.grbCircle.ResumeLayout(false);
            this.grbCircle.PerformLayout();
            this.grbTriangle.ResumeLayout(false);
            this.grbTriangle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpOne;
        private System.Windows.Forms.TextBox txbOptions;
        private System.Windows.Forms.GroupBox grbACO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOpFour;
        private System.Windows.Forms.Label lblOpThree;
        private System.Windows.Forms.Label lnlOpTwo;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox grbRectangle;
        private System.Windows.Forms.TextBox txbLengthRec;
        private System.Windows.Forms.Label lblWidthRec;
        private System.Windows.Forms.Label lblLengthRec;
        private System.Windows.Forms.Button btnReturnRec;
        private System.Windows.Forms.Button btnCalcRec;
        private System.Windows.Forms.TextBox txbWidthRec;
        private System.Windows.Forms.GroupBox grbCircle;
        private System.Windows.Forms.Button btnReturnCir;
        private System.Windows.Forms.Button btnCalcCir;
        private System.Windows.Forms.TextBox txbRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.GroupBox grbTriangle;
        private System.Windows.Forms.Button btnReturnTri;
        private System.Windows.Forms.Button btnCalcTri;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.TextBox txbBaseLength;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBaseLength;
        private System.Windows.Forms.Label label1;
    }
}

