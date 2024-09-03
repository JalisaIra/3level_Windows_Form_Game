namespace Eraa_s_Fairy_Land
{
    partial class EndBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalCollection = new System.Windows.Forms.Label();
            this.ReactionImage = new System.Windows.Forms.Panel();
            this.Impression = new System.Windows.Forms.Label();
            this.moodImage = new System.Windows.Forms.ImageList(this.components);
            this.StartPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Eraa_s_Fairy_Land.Properties.Resources.fairy3;
            this.pictureBox1.Location = new System.Drawing.Point(550, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 248);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "You\'ve Collected";
            // 
            // TotalCollection
            // 
            this.TotalCollection.AutoSize = true;
            this.TotalCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCollection.Location = new System.Drawing.Point(518, 193);
            this.TotalCollection.Name = "TotalCollection";
            this.TotalCollection.Size = new System.Drawing.Size(0, 29);
            this.TotalCollection.TabIndex = 2;
            // 
            // ReactionImage
            // 
            this.ReactionImage.Location = new System.Drawing.Point(601, 296);
            this.ReactionImage.Name = "ReactionImage";
            this.ReactionImage.Size = new System.Drawing.Size(336, 197);
            this.ReactionImage.TabIndex = 3;
            // 
            // Impression
            // 
            this.Impression.AutoSize = true;
            this.Impression.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impression.Location = new System.Drawing.Point(348, 254);
            this.Impression.Name = "Impression";
            this.Impression.Size = new System.Drawing.Size(0, 29);
            this.Impression.TabIndex = 4;
            // 
            // moodImage
            // 
            this.moodImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moodImage.ImageStream")));
            this.moodImage.TransparentColor = System.Drawing.Color.Transparent;
            this.moodImage.Images.SetKeyName(0, "sad.jpeg");
            this.moodImage.Images.SetKeyName(1, "Fairy1.jpg");
            this.moodImage.Images.SetKeyName(2, "Fairy2.jpg");
            this.moodImage.Images.SetKeyName(3, "Fairy3.jpg");
            this.moodImage.Images.SetKeyName(4, "Happy.jpeg");
            this.moodImage.Images.SetKeyName(5, "tinerbell.gif");
            // 
            // StartPage
            // 
            this.StartPage.BackColor = System.Drawing.Color.Transparent;
            this.StartPage.BackgroundImage = global::Eraa_s_Fairy_Land.Properties.Resources.background_1;
            this.StartPage.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPage.Location = new System.Drawing.Point(21, 42);
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(118, 68);
            this.StartPage.TabIndex = 5;
            this.StartPage.Text = "Home";
            this.StartPage.UseVisualStyleBackColor = false;
            this.StartPage.Click += new System.EventHandler(this.StartPage_Click);
            // 
            // EndBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Eraa_s_Fairy_Land.Properties.Resources.background_2;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.StartPage);
            this.Controls.Add(this.Impression);
            this.Controls.Add(this.ReactionImage);
            this.Controls.Add(this.TotalCollection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EndBox";
            this.Text = "EndBox";
            this.Load += new System.EventHandler(this.EndBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalCollection;
        private System.Windows.Forms.Panel ReactionImage;
        private System.Windows.Forms.Label Impression;
        private System.Windows.Forms.ImageList moodImage;
        private System.Windows.Forms.Button StartPage;
    }
}