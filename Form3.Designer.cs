namespace DNDClone
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.trackTextSpeed = new System.Windows.Forms.TrackBar();
            this.labelInfoTextSpeed = new System.Windows.Forms.Label();
            this.labelTextSpeed = new System.Windows.Forms.Label();
            this.trackDifficulty = new System.Windows.Forms.TrackBar();
            this.labelInfoDifficulty = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackTextSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // trackTextSpeed
            // 
            this.trackTextSpeed.Location = new System.Drawing.Point(109, 12);
            this.trackTextSpeed.Maximum = 5;
            this.trackTextSpeed.Minimum = 1;
            this.trackTextSpeed.Name = "trackTextSpeed";
            this.trackTextSpeed.Size = new System.Drawing.Size(89, 45);
            this.trackTextSpeed.TabIndex = 0;
            this.trackTextSpeed.Value = 3;
            this.trackTextSpeed.Scroll += new System.EventHandler(this.trackTextSpeed_Scroll);
            // 
            // labelInfoTextSpeed
            // 
            this.labelInfoTextSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoTextSpeed.Location = new System.Drawing.Point(12, 12);
            this.labelInfoTextSpeed.Name = "labelInfoTextSpeed";
            this.labelInfoTextSpeed.Size = new System.Drawing.Size(91, 32);
            this.labelInfoTextSpeed.TabIndex = 1;
            this.labelInfoTextSpeed.Text = "Text Scroll Speed";
            this.labelInfoTextSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextSpeed
            // 
            this.labelTextSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSpeed.Location = new System.Drawing.Point(204, 21);
            this.labelTextSpeed.Name = "labelTextSpeed";
            this.labelTextSpeed.Size = new System.Drawing.Size(28, 23);
            this.labelTextSpeed.TabIndex = 2;
            this.labelTextSpeed.Text = "3";
            this.labelTextSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackDifficulty
            // 
            this.trackDifficulty.Location = new System.Drawing.Point(109, 63);
            this.trackDifficulty.Maximum = 3;
            this.trackDifficulty.Minimum = 1;
            this.trackDifficulty.Name = "trackDifficulty";
            this.trackDifficulty.Size = new System.Drawing.Size(89, 45);
            this.trackDifficulty.TabIndex = 3;
            this.trackDifficulty.Value = 2;
            this.trackDifficulty.Scroll += new System.EventHandler(this.trackDifficulty_Scroll);
            // 
            // labelInfoDifficulty
            // 
            this.labelInfoDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoDifficulty.Location = new System.Drawing.Point(12, 63);
            this.labelInfoDifficulty.Name = "labelInfoDifficulty";
            this.labelInfoDifficulty.Size = new System.Drawing.Size(91, 27);
            this.labelInfoDifficulty.TabIndex = 4;
            this.labelInfoDifficulty.Text = "Difficulty";
            this.labelInfoDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(204, 67);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(28, 23);
            this.labelDifficulty.TabIndex = 5;
            this.labelDifficulty.Text = "2";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelInfoDifficulty);
            this.Controls.Add(this.trackDifficulty);
            this.Controls.Add(this.labelTextSpeed);
            this.Controls.Add(this.labelInfoTextSpeed);
            this.Controls.Add(this.trackTextSpeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Game Options";
            ((System.ComponentModel.ISupportInitialize)(this.trackTextSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackTextSpeed;
        private System.Windows.Forms.Label labelInfoTextSpeed;
        private System.Windows.Forms.Label labelTextSpeed;
        private System.Windows.Forms.TrackBar trackDifficulty;
        private System.Windows.Forms.Label labelInfoDifficulty;
        private System.Windows.Forms.Label labelDifficulty;
    }
}