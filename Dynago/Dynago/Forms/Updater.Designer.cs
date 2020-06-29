namespace Dynago.Forms {
    partial class Updater {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pb = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBytes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.Label();
            this.txtUpgrading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(26, 90);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(304, 23);
            this.pb.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Cheat will automatically restart once completed.";
            // 
            // lblBytes
            // 
            this.lblBytes.AutoSize = true;
            this.lblBytes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBytes.Location = new System.Drawing.Point(85, 124);
            this.lblBytes.Name = "lblBytes";
            this.lblBytes.Size = new System.Drawing.Size(187, 13);
            this.lblBytes.TabIndex = 107;
            this.lblBytes.Text = "Downloading bytes - [0/0] - 0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 106;
            this.label1.Text = "Updating Dynago";
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.githubLink.Location = new System.Drawing.Point(115, 146);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(127, 13);
            this.githubLink.TabIndex = 110;
            this.githubLink.Text = "github.com/Me-re-ly/";
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // txtUpgrading
            // 
            this.txtUpgrading.AutoSize = true;
            this.txtUpgrading.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpgrading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtUpgrading.Location = new System.Drawing.Point(61, 43);
            this.txtUpgrading.Name = "txtUpgrading";
            this.txtUpgrading.Size = new System.Drawing.Size(235, 13);
            this.txtUpgrading.TabIndex = 112;
            this.txtUpgrading.Text = "Upgrading Dynago from v[0.0] to v[0.0]";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(357, 175);
            this.Controls.Add(this.txtUpgrading);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBytes);
            this.Controls.Add(this.label1);
            this.Name = "Updater";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynago v[0.0] - AutoUpdater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBytes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label githubLink;
        private System.Windows.Forms.Label txtUpgrading;
    }
}