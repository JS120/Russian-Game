namespace Russian_Roullete
{
    partial class Roullette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roullette));
            this.bullet_load = new System.Windows.Forms.Button();
            this.bullet_spin = new System.Windows.Forms.Button();
            this.bullet_shoot = new System.Windows.Forms.Button();
            this.Retry_again = new System.Windows.Forms.Button();
            this.Exit_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bullet_load
            // 
            this.bullet_load.BackColor = System.Drawing.Color.Black;
            this.bullet_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet_load.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bullet_load.ForeColor = System.Drawing.Color.Red;
            this.bullet_load.Location = new System.Drawing.Point(18, 168);
            this.bullet_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bullet_load.Name = "bullet_load";
            this.bullet_load.Size = new System.Drawing.Size(190, 108);
            this.bullet_load.TabIndex = 1;
            this.bullet_load.Text = "Load";
            this.bullet_load.UseVisualStyleBackColor = false;
            this.bullet_load.Click += new System.EventHandler(this.load_Click);
            // 
            // bullet_spin
            // 
            this.bullet_spin.BackColor = System.Drawing.Color.Black;
            this.bullet_spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet_spin.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bullet_spin.ForeColor = System.Drawing.Color.Red;
            this.bullet_spin.Location = new System.Drawing.Point(18, 541);
            this.bullet_spin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bullet_spin.Name = "bullet_spin";
            this.bullet_spin.Size = new System.Drawing.Size(190, 112);
            this.bullet_spin.TabIndex = 2;
            this.bullet_spin.Text = "Spin";
            this.bullet_spin.UseVisualStyleBackColor = false;
            this.bullet_spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // bullet_shoot
            // 
            this.bullet_shoot.BackColor = System.Drawing.Color.Black;
            this.bullet_shoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bullet_shoot.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bullet_shoot.ForeColor = System.Drawing.Color.Red;
            this.bullet_shoot.Location = new System.Drawing.Point(530, 562);
            this.bullet_shoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bullet_shoot.Name = "bullet_shoot";
            this.bullet_shoot.Size = new System.Drawing.Size(197, 112);
            this.bullet_shoot.TabIndex = 3;
            this.bullet_shoot.Text = "Shoot";
            this.bullet_shoot.UseVisualStyleBackColor = false;
            this.bullet_shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // Retry_again
            // 
            this.Retry_again.BackColor = System.Drawing.Color.Black;
            this.Retry_again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retry_again.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retry_again.ForeColor = System.Drawing.Color.Red;
            this.Retry_again.Location = new System.Drawing.Point(1052, 562);
            this.Retry_again.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Retry_again.Name = "Retry_again";
            this.Retry_again.Size = new System.Drawing.Size(198, 112);
            this.Retry_again.TabIndex = 5;
            this.Retry_again.Text = "Retry";
            this.Retry_again.UseVisualStyleBackColor = false;
            this.Retry_again.Click += new System.EventHandler(this.retry);
            // 
            // Exit_game
            // 
            this.Exit_game.BackColor = System.Drawing.Color.Black;
            this.Exit_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_game.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_game.ForeColor = System.Drawing.Color.Red;
            this.Exit_game.Location = new System.Drawing.Point(1078, 168);
            this.Exit_game.Name = "Exit_game";
            this.Exit_game.Size = new System.Drawing.Size(152, 108);
            this.Exit_game.TabIndex = 8;
            this.Exit_game.Text = "Exit";
            this.Exit_game.UseVisualStyleBackColor = false;
            this.Exit_game.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Roullette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 703);
            this.Controls.Add(this.Exit_game);
            this.Controls.Add(this.Retry_again);
            this.Controls.Add(this.bullet_shoot);
            this.Controls.Add(this.bullet_spin);
            this.Controls.Add(this.bullet_load);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Roullette";
            this.Text = "Russian Game";
            this.Load += new System.EventHandler(this.game_Load);
            this.Click += new System.EventHandler(this.retry);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bullet_load;
        private System.Windows.Forms.Button bullet_spin;
        private System.Windows.Forms.Button bullet_shoot;
        private System.Windows.Forms.Button Retry_again;
        private System.Windows.Forms.Button Exit_game;
    }
}