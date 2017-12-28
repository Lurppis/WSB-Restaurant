namespace WSB_Restaurant
{
    partial class ClientType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientType));
            this.DrivethroughButton = new System.Windows.Forms.Button();
            this.LocalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrivethroughButton
            // 
            this.DrivethroughButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrivethroughButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrivethroughButton.ForeColor = System.Drawing.Color.Black;
            this.DrivethroughButton.Image = ((System.Drawing.Image)(resources.GetObject("DrivethroughButton.Image")));
            this.DrivethroughButton.Location = new System.Drawing.Point(24, 128);
            this.DrivethroughButton.Name = "DrivethroughButton";
            this.DrivethroughButton.Size = new System.Drawing.Size(180, 180);
            this.DrivethroughButton.TabIndex = 0;
            this.DrivethroughButton.Text = "Drive-through";
            this.DrivethroughButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DrivethroughButton.UseVisualStyleBackColor = false;
            this.DrivethroughButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LocalButton
            // 
            this.LocalButton.BackColor = System.Drawing.SystemColors.Control;
            this.LocalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalButton.Image = ((System.Drawing.Image)(resources.GetObject("LocalButton.Image")));
            this.LocalButton.Location = new System.Drawing.Point(262, 128);
            this.LocalButton.Name = "LocalButton";
            this.LocalButton.Size = new System.Drawing.Size(180, 180);
            this.LocalButton.TabIndex = 1;
            this.LocalButton.Text = "Local";
            this.LocalButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LocalButton.UseVisualStyleBackColor = false;
            this.LocalButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client type";
            // 
            // ClientType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocalButton);
            this.Controls.Add(this.DrivethroughButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientType";
            this.Text = "ClientType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrivethroughButton;
        private System.Windows.Forms.Button LocalButton;
        private System.Windows.Forms.Label label1;
    }
}