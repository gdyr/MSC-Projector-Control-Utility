namespace PJControl
{
    partial class PJControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PJControl));
            this.powerOnButton = new System.Windows.Forms.Button();
            this.powerOffButton = new System.Windows.Forms.Button();
            this.sourceSelectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // powerOnButton
            // 
            this.powerOnButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerOnButton.Location = new System.Drawing.Point(12, 12);
            this.powerOnButton.Name = "powerOnButton";
            this.powerOnButton.Size = new System.Drawing.Size(175, 37);
            this.powerOnButton.TabIndex = 0;
            this.powerOnButton.Text = "TURN PROJECTOR ON";
            this.powerOnButton.UseVisualStyleBackColor = true;
            this.powerOnButton.Click += new System.EventHandler(this.powerOnButton_Click);
            // 
            // powerOffButton
            // 
            this.powerOffButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerOffButton.Location = new System.Drawing.Point(12, 55);
            this.powerOffButton.Name = "powerOffButton";
            this.powerOffButton.Size = new System.Drawing.Size(175, 37);
            this.powerOffButton.TabIndex = 1;
            this.powerOffButton.Text = "TURN PROJECTOR OFF";
            this.powerOffButton.UseVisualStyleBackColor = true;
            this.powerOffButton.Click += new System.EventHandler(this.powerOffButton_Click);
            // 
            // sourceSelectButton
            // 
            this.sourceSelectButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceSelectButton.Location = new System.Drawing.Point(12, 98);
            this.sourceSelectButton.Name = "sourceSelectButton";
            this.sourceSelectButton.Size = new System.Drawing.Size(175, 37);
            this.sourceSelectButton.TabIndex = 2;
            this.sourceSelectButton.Text = "SEARCH FOR INPUT";
            this.sourceSelectButton.UseVisualStyleBackColor = true;
            this.sourceSelectButton.Click += new System.EventHandler(this.sourceSelectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(12, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(175, 37);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PJControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(200, 191);
            this.Controls.Add(this.powerOnButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.powerOffButton);
            this.Controls.Add(this.sourceSelectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PJControl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powerOnButton;
        private System.Windows.Forms.Button powerOffButton;
        private System.Windows.Forms.Button sourceSelectButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

