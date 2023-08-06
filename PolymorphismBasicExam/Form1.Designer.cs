namespace PolymorphismBasicExam
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
            this.components = new System.ComponentModel.Container();
            this.labelGermanCar = new System.Windows.Forms.Label();
            this.labelItalianCar = new System.Windows.Forms.Label();
            this.labelTurkishCar = new System.Windows.Forms.Label();
            this.labelFinish = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelGermanCar
            // 
            this.labelGermanCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelGermanCar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGermanCar.Location = new System.Drawing.Point(139, 42);
            this.labelGermanCar.Name = "labelGermanCar";
            this.labelGermanCar.Size = new System.Drawing.Size(126, 73);
            this.labelGermanCar.TabIndex = 0;
            this.labelGermanCar.Text = "German Car";
            this.labelGermanCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelItalianCar
            // 
            this.labelItalianCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelItalianCar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelItalianCar.Location = new System.Drawing.Point(139, 155);
            this.labelItalianCar.Name = "labelItalianCar";
            this.labelItalianCar.Size = new System.Drawing.Size(126, 73);
            this.labelItalianCar.TabIndex = 0;
            this.labelItalianCar.Text = "Italian Car";
            this.labelItalianCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTurkishCar
            // 
            this.labelTurkishCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTurkishCar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTurkishCar.Location = new System.Drawing.Point(139, 274);
            this.labelTurkishCar.Name = "labelTurkishCar";
            this.labelTurkishCar.Size = new System.Drawing.Size(126, 73);
            this.labelTurkishCar.TabIndex = 0;
            this.labelTurkishCar.Text = "Turkish Car";
            this.labelTurkishCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFinish
            // 
            this.labelFinish.BackColor = System.Drawing.Color.Red;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinish.Location = new System.Drawing.Point(678, 9);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(53, 399);
            this.labelFinish.TabIndex = 0;
            this.labelFinish.Text = "FINISH";
            this.labelFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Gray;
            this.buttonStart.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStart.Location = new System.Drawing.Point(138, 367);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(127, 71);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start Race";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTurkishCar);
            this.Controls.Add(this.labelItalianCar);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.labelGermanCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGermanCar;
        private System.Windows.Forms.Label labelItalianCar;
        private System.Windows.Forms.Label labelTurkishCar;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

