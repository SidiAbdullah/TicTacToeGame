namespace Tic_Tac_Toe_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pct1 = new PictureBox();
            pct2 = new PictureBox();
            pct3 = new PictureBox();
            pct9 = new PictureBox();
            pct8 = new PictureBox();
            pct7 = new PictureBox();
            pct6 = new PictureBox();
            pct5 = new PictureBox();
            pct4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct4).BeginInit();
            SuspendLayout();
            // 
            // pct1
            // 
            pct1.Image = Properties.Resources.QuestonMarkPic;
            pct1.Location = new Point(212, 112);
            pct1.Name = "pct1";
            pct1.Size = new Size(69, 64);
            pct1.SizeMode = PictureBoxSizeMode.Zoom;
            pct1.TabIndex = 0;
            pct1.TabStop = false;
            pct1.Click += pictureBox1_Click;
            // 
            // pct2
            // 
            pct2.Image = Properties.Resources.QuestonMarkPic;
            pct2.Location = new Point(317, 112);
            pct2.Name = "pct2";
            pct2.Size = new Size(69, 64);
            pct2.SizeMode = PictureBoxSizeMode.Zoom;
            pct2.TabIndex = 1;
            pct2.TabStop = false;
            pct2.Click += pictureBox2_Click;
            // 
            // pct3
            // 
            pct3.Image = Properties.Resources.QuestonMarkPic;
            pct3.Location = new Point(422, 112);
            pct3.Name = "pct3";
            pct3.Size = new Size(69, 64);
            pct3.SizeMode = PictureBoxSizeMode.Zoom;
            pct3.TabIndex = 2;
            pct3.TabStop = false;
            pct3.Click += pictureBox3_Click;
            // 
            // pct9
            // 
            pct9.Image = Properties.Resources.QuestonMarkPic;
            pct9.Location = new Point(422, 326);
            pct9.Name = "pct9";
            pct9.Size = new Size(69, 64);
            pct9.SizeMode = PictureBoxSizeMode.Zoom;
            pct9.TabIndex = 5;
            pct9.TabStop = false;
            pct9.Click += pictureBox4_Click;
            // 
            // pct8
            // 
            pct8.Image = Properties.Resources.QuestonMarkPic;
            pct8.Location = new Point(317, 326);
            pct8.Name = "pct8";
            pct8.Size = new Size(69, 64);
            pct8.SizeMode = PictureBoxSizeMode.Zoom;
            pct8.TabIndex = 4;
            pct8.TabStop = false;
            pct8.Click += pictureBox5_Click;
            // 
            // pct7
            // 
            pct7.Image = Properties.Resources.QuestonMarkPic;
            pct7.Location = new Point(212, 326);
            pct7.Name = "pct7";
            pct7.Size = new Size(69, 64);
            pct7.SizeMode = PictureBoxSizeMode.Zoom;
            pct7.TabIndex = 3;
            pct7.TabStop = false;
            pct7.Click += pictureBox6_Click;
            // 
            // pct6
            // 
            pct6.Image = Properties.Resources.QuestonMarkPic;
            pct6.Location = new Point(422, 219);
            pct6.Name = "pct6";
            pct6.Size = new Size(69, 64);
            pct6.SizeMode = PictureBoxSizeMode.Zoom;
            pct6.TabIndex = 8;
            pct6.TabStop = false;
            pct6.Click += pictureBox7_Click;
            // 
            // pct5
            // 
            pct5.Image = Properties.Resources.QuestonMarkPic;
            pct5.Location = new Point(317, 218);
            pct5.Name = "pct5";
            pct5.Size = new Size(69, 64);
            pct5.SizeMode = PictureBoxSizeMode.Zoom;
            pct5.TabIndex = 7;
            pct5.TabStop = false;
            pct5.Click += pictureBox8_Click;
            // 
            // pct4
            // 
            pct4.Image = Properties.Resources.QuestonMarkPic;
            pct4.Location = new Point(212, 218);
            pct4.Name = "pct4";
            pct4.Size = new Size(69, 64);
            pct4.SizeMode = PictureBoxSizeMode.Zoom;
            pct4.TabIndex = 6;
            pct4.TabStop = false;
            pct4.Click += pictureBox9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(199, 33);
            label1.Name = "label1";
            label1.Size = new Size(309, 40);
            label1.TabIndex = 9;
            label1.Text = "TIC TAC TOE GAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(588, 177);
            label2.Name = "label2";
            label2.Size = new Size(114, 38);
            label2.TabIndex = 10;
            label2.Text = "Result:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(732, 188);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(135, 24);
            lblResult.TabIndex = 11;
            lblResult.Text = "Who Will Win?";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("Andalus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ImageAlign = ContentAlignment.TopCenter;
            btnReset.Location = new Point(669, 291);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 50);
            btnReset.TabIndex = 12;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 591);
            Controls.Add(btnReset);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pct6);
            Controls.Add(pct5);
            Controls.Add(pct4);
            Controls.Add(pct9);
            Controls.Add(pct8);
            Controls.Add(pct7);
            Controls.Add(pct3);
            Controls.Add(pct2);
            Controls.Add(pct1);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)pct1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct1;
        private PictureBox pct2;
        private PictureBox pct3;
        private PictureBox pct9;
        private PictureBox pct8;
        private PictureBox pct7;
        private PictureBox pct6;
        private PictureBox pct5;
        private PictureBox pct4;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private Button btnReset;
    }
}
