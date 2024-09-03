namespace Eraa_s_Fairy_Land
{
    partial class GameWindows
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtCollect = new System.Windows.Forms.Label();
            this.GoodTree1 = new System.Windows.Forms.PictureBox();
            this.GoodTree2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Cloud = new System.Windows.Forms.PictureBox();
            this.HappyTree = new System.Windows.Forms.PictureBox();
            this.butterfly = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GoodTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodTree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappyTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butterfly)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 15;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtCollect
            // 
            this.txtCollect.AutoSize = true;
            this.txtCollect.BackColor = System.Drawing.Color.Firebrick;
            this.txtCollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCollect.Location = new System.Drawing.Point(12, 9);
            this.txtCollect.Name = "txtCollect";
            this.txtCollect.Size = new System.Drawing.Size(116, 29);
            this.txtCollect.TabIndex = 4;
            this.txtCollect.Text = "Collect:0";
            // 
            // GoodTree1
            // 
            this.GoodTree1.Image = global::Eraa_s_Fairy_Land.Properties.Resources.tree1;
            this.GoodTree1.Location = new System.Drawing.Point(3, 392);
            this.GoodTree1.Name = "GoodTree1";
            this.GoodTree1.Size = new System.Drawing.Size(237, 199);
            this.GoodTree1.TabIndex = 6;
            this.GoodTree1.TabStop = false;
            this.GoodTree1.Tag = "GoodTree";
            // 
            // GoodTree2
            // 
            this.GoodTree2.Image = global::Eraa_s_Fairy_Land.Properties.Resources.tree1;
            this.GoodTree2.Location = new System.Drawing.Point(933, 407);
            this.GoodTree2.Name = "GoodTree2";
            this.GoodTree2.Size = new System.Drawing.Size(237, 199);
            this.GoodTree2.TabIndex = 5;
            this.GoodTree2.TabStop = false;
            this.GoodTree2.Tag = "GoodTree";
            this.GoodTree2.Click += new System.EventHandler(this.GoodTree2_Click);
            // 
            // player
            // 
            this.player.Image = global::Eraa_s_Fairy_Land.Properties.Resources.tinerbell3;
            this.player.Location = new System.Drawing.Point(60, 169);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 105);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // Cloud
            // 
            this.Cloud.BackColor = System.Drawing.Color.Transparent;
            this.Cloud.Image = global::Eraa_s_Fairy_Land.Properties.Resources.cloud;
            this.Cloud.Location = new System.Drawing.Point(659, -22);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(227, 163);
            this.Cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud.TabIndex = 2;
            this.Cloud.TabStop = false;
            this.Cloud.Tag = "Boundary";
            // 
            // HappyTree
            // 
            this.HappyTree.BackColor = System.Drawing.Color.Transparent;
            this.HappyTree.Image = global::Eraa_s_Fairy_Land.Properties.Resources.Happy_tree;
            this.HappyTree.Location = new System.Drawing.Point(446, 392);
            this.HappyTree.Name = "HappyTree";
            this.HappyTree.Size = new System.Drawing.Size(223, 214);
            this.HappyTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HappyTree.TabIndex = 1;
            this.HappyTree.TabStop = false;
            this.HappyTree.Tag = "Boundary";
            // 
            // butterfly
            // 
            this.butterfly.BackColor = System.Drawing.Color.Transparent;
            this.butterfly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butterfly.Image = global::Eraa_s_Fairy_Land.Properties.Resources._05;
            this.butterfly.Location = new System.Drawing.Point(760, 255);
            this.butterfly.Name = "butterfly";
            this.butterfly.Size = new System.Drawing.Size(126, 72);
            this.butterfly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.butterfly.TabIndex = 0;
            this.butterfly.TabStop = false;
            this.butterfly.Tag = "butterfly";
            // 
            // GameWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.GoodTree1);
            this.Controls.Add(this.GoodTree2);
            this.Controls.Add(this.txtCollect);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Cloud);
            this.Controls.Add(this.HappyTree);
            this.Controls.Add(this.butterfly);
            this.Name = "GameWindows";
            this.Text = "GameWindows";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.GoodTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodTree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HappyTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butterfly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox butterfly;
        private System.Windows.Forms.PictureBox HappyTree;
        private System.Windows.Forms.PictureBox Cloud;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtCollect;
        private System.Windows.Forms.PictureBox GoodTree2;
        private System.Windows.Forms.PictureBox GoodTree1;
    }
}