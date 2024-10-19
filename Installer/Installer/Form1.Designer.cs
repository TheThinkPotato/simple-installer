namespace Installer
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxSplash = new System.Windows.Forms.PictureBox();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(264, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Game Lan Edition Installer";
            // 
            // pictureBoxSplash
            // 
            this.pictureBoxSplash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxSplash.Location = new System.Drawing.Point(-3, 48);
            this.pictureBoxSplash.Name = "pictureBoxSplash";
            this.pictureBoxSplash.Size = new System.Drawing.Size(750, 300);
            this.pictureBoxSplash.TabIndex = 1;
            this.pictureBoxSplash.TabStop = false;
            // 
            // buttonInstall
            // 
            this.buttonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstall.ForeColor = System.Drawing.Color.White;
            this.buttonInstall.Location = new System.Drawing.Point(569, 278);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(154, 50);
            this.buttonInstall.TabIndex = 2;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = false;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFolder.Location = new System.Drawing.Point(569, 212);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(154, 50);
            this.buttonFolder.TabIndex = 2;
            this.buttonFolder.Text = "Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFolder.Location = new System.Drawing.Point(123, 372);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(600, 24);
            this.textBoxFolder.TabIndex = 3;
            this.textBoxFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFolder_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Install folder:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(123, 372);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 24);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonFinish
            // 
            this.buttonFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.ForeColor = System.Drawing.Color.White;
            this.buttonFinish.Location = new System.Drawing.Point(569, 358);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(154, 50);
            this.buttonFinish.TabIndex = 2;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(745, 419);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.pictureBoxSplash);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Lan Installer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxSplash;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonFinish;
    }
}

