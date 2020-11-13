using System;

namespace Russian_Roulette
{
    partial class FormGame
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
            this.img_display = new System.Windows.Forms.PictureBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_spin = new System.Windows.Forms.Button();
            this.button_shoot = new System.Windows.Forms.Button();
            this.button_shootaway = new System.Windows.Forms.Button();
            this.button_playagain = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_display)).BeginInit();
            this.SuspendLayout();
            // 
            // img_display
            // 
            this.img_display.Location = new System.Drawing.Point(253, 89);
            this.img_display.Name = "img_display";
            this.img_display.Size = new System.Drawing.Size(337, 219);
            this.img_display.TabIndex = 0;
            this.img_display.TabStop = false;
            // 
            // button_load
            // 
            this.button_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_load.Location = new System.Drawing.Point(59, 12);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 32);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_spin
            // 
            this.button_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_spin.Location = new System.Drawing.Point(59, 74);
            this.button_spin.Name = "button_spin";
            this.button_spin.Size = new System.Drawing.Size(75, 34);
            this.button_spin.TabIndex = 2;
            this.button_spin.Text = "Spin";
            this.button_spin.UseVisualStyleBackColor = false;
            this.button_spin.Click += new System.EventHandler(this.button_spin_Click);
            // 
            // button_shoot
            // 
            this.button_shoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_shoot.Location = new System.Drawing.Point(59, 133);
            this.button_shoot.Name = "button_shoot";
            this.button_shoot.Size = new System.Drawing.Size(75, 33);
            this.button_shoot.TabIndex = 3;
            this.button_shoot.Text = "Shoot";
            this.button_shoot.UseVisualStyleBackColor = false;
            this.button_shoot.Click += new System.EventHandler(this.button_shoot_Click);
            // 
            // button_shootaway
            // 
            this.button_shootaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_shootaway.Location = new System.Drawing.Point(59, 192);
            this.button_shootaway.Name = "button_shootaway";
            this.button_shootaway.Size = new System.Drawing.Size(75, 34);
            this.button_shootaway.TabIndex = 4;
            this.button_shootaway.Text = "Shoot Away";
            this.button_shootaway.UseVisualStyleBackColor = false;
            this.button_shootaway.Click += new System.EventHandler(this.button_shootaway_Click);
            // 
            // button_playagain
            // 
            this.button_playagain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_playagain.Location = new System.Drawing.Point(59, 249);
            this.button_playagain.Name = "button_playagain";
            this.button_playagain.Size = new System.Drawing.Size(75, 36);
            this.button_playagain.TabIndex = 5;
            this.button_playagain.Text = "Play Again";
            this.button_playagain.UseVisualStyleBackColor = false;
            this.button_playagain.Click += new System.EventHandler(this.button_playagain_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Exit.Location = new System.Drawing.Point(59, 310);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 32);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click_1);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_Roulette.Properties.Resources.game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_playagain);
            this.Controls.Add(this.button_shootaway);
            this.Controls.Add(this.button_shoot);
            this.Controls.Add(this.button_spin);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.img_display);
            this.Name = "FormGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_display)).EndInit();
            this.ResumeLayout(false);

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox img_display;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_spin;
        private System.Windows.Forms.Button button_shoot;
        private System.Windows.Forms.Button button_shootaway;
        private System.Windows.Forms.Button button_playagain;
        private System.Windows.Forms.Button button_Exit;
    }
}

    