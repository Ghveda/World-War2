namespace WorldWar2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Jet = new System.Windows.Forms.PictureBox();
            this.ball1 = new System.Windows.Forms.PictureBox();
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.ball3 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bulletLevel1 = new System.Windows.Forms.PictureBox();
            this.giftBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Jet
            // 
            this.Jet.Image = ((System.Drawing.Image)(resources.GetObject("Jet.Image")));
            this.Jet.Location = new System.Drawing.Point(331, 413);
            this.Jet.Name = "Jet";
            this.Jet.Size = new System.Drawing.Size(73, 66);
            this.Jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jet.TabIndex = 0;
            this.Jet.TabStop = false;
            // 
            // ball1
            // 
            this.ball1.Image = ((System.Drawing.Image)(resources.GetObject("ball1.Image")));
            this.ball1.Location = new System.Drawing.Point(117, 27);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(40, 40);
            this.ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball1.TabIndex = 1;
            this.ball1.TabStop = false;
            this.ball1.Tag = "ball";
            // 
            // ball2
            // 
            this.ball2.Image = ((System.Drawing.Image)(resources.GetObject("ball2.Image")));
            this.ball2.Location = new System.Drawing.Point(368, 27);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(40, 40);
            this.ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball2.TabIndex = 1;
            this.ball2.TabStop = false;
            this.ball2.Tag = "ball";
            // 
            // ball3
            // 
            this.ball3.Image = ((System.Drawing.Image)(resources.GetObject("ball3.Image")));
            this.ball3.Location = new System.Drawing.Point(485, 27);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(40, 40);
            this.ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball3.TabIndex = 1;
            this.ball3.TabStop = false;
            this.ball3.Tag = "ball";
            // 
            // bullet1
            // 
            this.bullet1.Image = ((System.Drawing.Image)(resources.GetObject("bullet1.Image")));
            this.bullet1.Location = new System.Drawing.Point(331, 389);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(18, 18);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 2;
            this.bullet1.TabStop = false;
            this.bullet1.Tag = "bullet";
            // 
            // bullet2
            // 
            this.bullet2.Image = ((System.Drawing.Image)(resources.GetObject("bullet2.Image")));
            this.bullet2.Location = new System.Drawing.Point(386, 389);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(18, 18);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 2;
            this.bullet2.TabStop = false;
            this.bullet2.Tag = "bullet";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.MainTimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coin: 0";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.SecondTimer);
            // 
            // bulletLevel1
            // 
            this.bulletLevel1.Image = ((System.Drawing.Image)(resources.GetObject("bulletLevel1.Image")));
            this.bulletLevel1.Location = new System.Drawing.Point(356, 352);
            this.bulletLevel1.Name = "bulletLevel1";
            this.bulletLevel1.Size = new System.Drawing.Size(18, 18);
            this.bulletLevel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletLevel1.TabIndex = 2;
            this.bulletLevel1.TabStop = false;
            this.bulletLevel1.Tag = "bullet";
            // 
            // giftBox
            // 
            this.giftBox.Image = ((System.Drawing.Image)(resources.GetObject("giftBox.Image")));
            this.giftBox.Location = new System.Drawing.Point(216, 91);
            this.giftBox.Name = "giftBox";
            this.giftBox.Size = new System.Drawing.Size(40, 40);
            this.giftBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.giftBox.TabIndex = 4;
            this.giftBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game is over!!";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.giftBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bulletLevel1);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.ball3);
            this.Controls.Add(this.ball2);
            this.Controls.Add(this.ball1);
            this.Controls.Add(this.Jet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Jet;
        private System.Windows.Forms.PictureBox ball1;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.PictureBox ball3;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox bulletLevel1;
        private System.Windows.Forms.PictureBox giftBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

