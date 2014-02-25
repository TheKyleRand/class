namespace Heads_or_Tails
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
            this.tailPictureBox = new System.Windows.Forms.PictureBox();
            this.headPictureBox = new System.Windows.Forms.PictureBox();
            this.headButton = new System.Windows.Forms.Button();
            this.tailButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tailPictureBox
            // 
            this.tailPictureBox.Image = global::Heads_or_Tails.Properties.Resources.Tails1;
            this.tailPictureBox.Location = new System.Drawing.Point(271, 13);
            this.tailPictureBox.Name = "tailPictureBox";
            this.tailPictureBox.Size = new System.Drawing.Size(156, 153);
            this.tailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailPictureBox.TabIndex = 1;
            this.tailPictureBox.TabStop = false;
            this.tailPictureBox.Visible = false;
            // 
            // headPictureBox
            // 
            this.headPictureBox.Image = global::Heads_or_Tails.Properties.Resources.Heads1;
            this.headPictureBox.Location = new System.Drawing.Point(13, 13);
            this.headPictureBox.Name = "headPictureBox";
            this.headPictureBox.Size = new System.Drawing.Size(155, 153);
            this.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPictureBox.TabIndex = 0;
            this.headPictureBox.TabStop = false;
            this.headPictureBox.Visible = false;
            // 
            // headButton
            // 
            this.headButton.Location = new System.Drawing.Point(53, 195);
            this.headButton.Name = "headButton";
            this.headButton.Size = new System.Drawing.Size(75, 42);
            this.headButton.TabIndex = 2;
            this.headButton.Text = "Show &Heads";
            this.headButton.UseVisualStyleBackColor = true;
            this.headButton.Click += new System.EventHandler(this.headButton_Click);
            // 
            // tailButton
            // 
            this.tailButton.Location = new System.Drawing.Point(181, 195);
            this.tailButton.Name = "tailButton";
            this.tailButton.Size = new System.Drawing.Size(75, 42);
            this.tailButton.TabIndex = 3;
            this.tailButton.Text = "Show &Tails";
            this.tailButton.UseVisualStyleBackColor = true;
            this.tailButton.Click += new System.EventHandler(this.tailButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(316, 195);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 42);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tailButton);
            this.Controls.Add(this.headButton);
            this.Controls.Add(this.tailPictureBox);
            this.Controls.Add(this.headPictureBox);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headPictureBox;
        private System.Windows.Forms.PictureBox tailPictureBox;
        private System.Windows.Forms.Button headButton;
        private System.Windows.Forms.Button tailButton;
        private System.Windows.Forms.Button exitButton;
    }
}

