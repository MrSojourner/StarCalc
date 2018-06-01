namespace StarCalc
{
    partial class MainFormAstroCalc
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
            this.lbDiametrLens = new System.Windows.Forms.Label();
            this.btnMinMagnetude = new System.Windows.Forms.Button();
            this.tbDiametrLens = new System.Windows.Forms.TextBox();
            this.lbMinMagnitude = new System.Windows.Forms.Label();
            this.tbMinMagnitude = new System.Windows.Forms.TextBox();
            this.lbMagnitude = new System.Windows.Forms.Label();
            this.tbMagnitude = new System.Windows.Forms.TextBox();
            this.lbAmountOfStar = new System.Windows.Forms.Label();
            this.tbAmountOfStar = new System.Windows.Forms.TextBox();
            this.btnAmountOfStar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirsMagnitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSecondMagnitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrightnessDifference = new System.Windows.Forms.Button();
            this.tbBrightnessDifference = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDiametrLens
            // 
            this.lbDiametrLens.AutoSize = true;
            this.lbDiametrLens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDiametrLens.Location = new System.Drawing.Point(12, 19);
            this.lbDiametrLens.Name = "lbDiametrLens";
            this.lbDiametrLens.Size = new System.Drawing.Size(166, 16);
            this.lbDiametrLens.TabIndex = 0;
            this.lbDiametrLens.Text = "Диаметр объектива, мм:";
            // 
            // btnMinMagnetude
            // 
            this.btnMinMagnetude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinMagnetude.Location = new System.Drawing.Point(529, 12);
            this.btnMinMagnetude.Name = "btnMinMagnetude";
            this.btnMinMagnetude.Size = new System.Drawing.Size(90, 34);
            this.btnMinMagnetude.TabIndex = 1;
            this.btnMinMagnetude.Text = "Определить";
            this.btnMinMagnetude.UseVisualStyleBackColor = true;
            this.btnMinMagnetude.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbDiametrLens
            // 
            this.tbDiametrLens.Location = new System.Drawing.Point(184, 19);
            this.tbDiametrLens.Name = "tbDiametrLens";
            this.tbDiametrLens.Size = new System.Drawing.Size(100, 20);
            this.tbDiametrLens.TabIndex = 2;
            // 
            // lbMinMagnitude
            // 
            this.lbMinMagnitude.AutoSize = true;
            this.lbMinMagnitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMinMagnitude.Location = new System.Drawing.Point(304, 9);
            this.lbMinMagnitude.Name = "lbMinMagnitude";
            this.lbMinMagnitude.Size = new System.Drawing.Size(154, 32);
            this.lbMinMagnitude.TabIndex = 3;
            this.lbMinMagnitude.Text = "Предельная звёздная\r\n          величина:";
            // 
            // tbMinMagnitude
            // 
            this.tbMinMagnitude.Location = new System.Drawing.Point(464, 19);
            this.tbMinMagnitude.Name = "tbMinMagnitude";
            this.tbMinMagnitude.ReadOnly = true;
            this.tbMinMagnitude.Size = new System.Drawing.Size(48, 20);
            this.tbMinMagnitude.TabIndex = 4;
            // 
            // lbMagnitude
            // 
            this.lbMagnitude.AutoSize = true;
            this.lbMagnitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMagnitude.Location = new System.Drawing.Point(12, 70);
            this.lbMagnitude.Name = "lbMagnitude";
            this.lbMagnitude.Size = new System.Drawing.Size(142, 16);
            this.lbMagnitude.TabIndex = 5;
            this.lbMagnitude.Text = "Звёздная величина:";
            // 
            // tbMagnitude
            // 
            this.tbMagnitude.Location = new System.Drawing.Point(184, 69);
            this.tbMagnitude.Name = "tbMagnitude";
            this.tbMagnitude.Size = new System.Drawing.Size(48, 20);
            this.tbMagnitude.TabIndex = 6;
            // 
            // lbAmountOfStar
            // 
            this.lbAmountOfStar.AutoSize = true;
            this.lbAmountOfStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAmountOfStar.Location = new System.Drawing.Point(320, 61);
            this.lbAmountOfStar.Name = "lbAmountOfStar";
            this.lbAmountOfStar.Size = new System.Drawing.Size(86, 32);
            this.lbAmountOfStar.TabIndex = 7;
            this.lbAmountOfStar.Text = "Количество\r\nзвезд ярче:";
            // 
            // tbAmountOfStar
            // 
            this.tbAmountOfStar.Location = new System.Drawing.Point(412, 70);
            this.tbAmountOfStar.Name = "tbAmountOfStar";
            this.tbAmountOfStar.ReadOnly = true;
            this.tbAmountOfStar.Size = new System.Drawing.Size(100, 20);
            this.tbAmountOfStar.TabIndex = 8;
            // 
            // btnAmountOfStar
            // 
            this.btnAmountOfStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAmountOfStar.Location = new System.Drawing.Point(529, 61);
            this.btnAmountOfStar.Name = "btnAmountOfStar";
            this.btnAmountOfStar.Size = new System.Drawing.Size(90, 34);
            this.btnAmountOfStar.TabIndex = 9;
            this.btnAmountOfStar.Text = "Определить";
            this.btnAmountOfStar.UseVisualStyleBackColor = true;
            this.btnAmountOfStar.Click += new System.EventHandler(this.btnAmountOfStar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Звёздная \r\nвеличина 1:";
            // 
            // tbFirsMagnitude
            // 
            this.tbFirsMagnitude.Location = new System.Drawing.Point(106, 132);
            this.tbFirsMagnitude.Name = "tbFirsMagnitude";
            this.tbFirsMagnitude.Size = new System.Drawing.Size(48, 20);
            this.tbFirsMagnitude.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(180, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Звёздная\r\nвеличина 2:";
            // 
            // tbSecondMagnitude
            // 
            this.tbSecondMagnitude.Location = new System.Drawing.Point(271, 132);
            this.tbSecondMagnitude.Name = "tbSecondMagnitude";
            this.tbSecondMagnitude.Size = new System.Drawing.Size(48, 20);
            this.tbSecondMagnitude.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(344, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Разница в \r\nсветимости:";
            // 
            // btnBrightnessDifference
            // 
            this.btnBrightnessDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrightnessDifference.Location = new System.Drawing.Point(529, 118);
            this.btnBrightnessDifference.Name = "btnBrightnessDifference";
            this.btnBrightnessDifference.Size = new System.Drawing.Size(90, 34);
            this.btnBrightnessDifference.TabIndex = 16;
            this.btnBrightnessDifference.Text = "Определить";
            this.btnBrightnessDifference.UseVisualStyleBackColor = true;
            this.btnBrightnessDifference.Click += new System.EventHandler(this.btnBrightnessDifference_Click);
            // 
            // tbBrightnessDifference
            // 
            this.tbBrightnessDifference.Location = new System.Drawing.Point(438, 132);
            this.tbBrightnessDifference.Name = "tbBrightnessDifference";
            this.tbBrightnessDifference.ReadOnly = true;
            this.tbBrightnessDifference.Size = new System.Drawing.Size(74, 20);
            this.tbBrightnessDifference.TabIndex = 17;
            // 
            // MainFormAstroCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 261);
            this.Controls.Add(this.tbBrightnessDifference);
            this.Controls.Add(this.btnBrightnessDifference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSecondMagnitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirsMagnitude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAmountOfStar);
            this.Controls.Add(this.tbAmountOfStar);
            this.Controls.Add(this.lbAmountOfStar);
            this.Controls.Add(this.tbMagnitude);
            this.Controls.Add(this.lbMagnitude);
            this.Controls.Add(this.tbMinMagnitude);
            this.Controls.Add(this.lbMinMagnitude);
            this.Controls.Add(this.tbDiametrLens);
            this.Controls.Add(this.btnMinMagnetude);
            this.Controls.Add(this.lbDiametrLens);
            this.Name = "MainFormAstroCalc";
            this.Text = "AstroCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDiametrLens;
        private System.Windows.Forms.Button btnMinMagnetude;
        private System.Windows.Forms.TextBox tbDiametrLens;
        private System.Windows.Forms.Label lbMinMagnitude;
        private System.Windows.Forms.TextBox tbMinMagnitude;
        private System.Windows.Forms.Label lbMagnitude;
        private System.Windows.Forms.TextBox tbMagnitude;
        private System.Windows.Forms.Label lbAmountOfStar;
        private System.Windows.Forms.TextBox tbAmountOfStar;
        private System.Windows.Forms.Button btnAmountOfStar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirsMagnitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSecondMagnitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrightnessDifference;
        private System.Windows.Forms.TextBox tbBrightnessDifference;
    }
}

