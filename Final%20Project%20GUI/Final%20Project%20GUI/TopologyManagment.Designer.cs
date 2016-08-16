namespace Final_Project_GUI
{
    partial class TopologyManagment
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TopologyLabel = new System.Windows.Forms.Label();
            this.TopologyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CloseButton.Location = new System.Drawing.Point(361, 509);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(105, 49);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DeleteButton.Location = new System.Drawing.Point(123, 509);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 49);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete Topology";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(12, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Topology";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TopologyLabel
            // 
            this.TopologyLabel.AutoSize = true;
            this.TopologyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TopologyLabel.Location = new System.Drawing.Point(100, 20);
            this.TopologyLabel.Name = "TopologyLabel";
            this.TopologyLabel.Size = new System.Drawing.Size(267, 31);
            this.TopologyLabel.TabIndex = 6;
            this.TopologyLabel.Text = "Topology Database";
            // 
            // TopologyList
            // 
            this.TopologyList.FormattingEnabled = true;
            this.TopologyList.Location = new System.Drawing.Point(12, 59);
            this.TopologyList.Name = "TopologyList";
            this.TopologyList.Size = new System.Drawing.Size(454, 407);
            this.TopologyList.TabIndex = 5;
            // 
            // TopologyManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 570);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TopologyLabel);
            this.Controls.Add(this.TopologyList);
            this.Name = "TopologyManagment";
            this.Text = "TopologyManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TopologyLabel;
        private System.Windows.Forms.ListBox TopologyList;
    }
}