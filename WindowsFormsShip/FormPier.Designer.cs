namespace WindowsFormsShip
{
    partial class FormPier
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
            this.pictureBoxPier = new System.Windows.Forms.PictureBox();
            this.btnParkShip = new System.Windows.Forms.Button();
            this.btnParkDieselShip = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPier
            // 
            this.pictureBoxPier.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPier.Name = "pictureBoxPier";
            this.pictureBoxPier.Size = new System.Drawing.Size(879, 561);
            this.pictureBoxPier.TabIndex = 0;
            this.pictureBoxPier.TabStop = false;
            // 
            // btnParkShip
            // 
            this.btnParkShip.Location = new System.Drawing.Point(928, 12);
            this.btnParkShip.Name = "btnParkShip";
            this.btnParkShip.Size = new System.Drawing.Size(103, 60);
            this.btnParkShip.TabIndex = 1;
            this.btnParkShip.Text = "Поставить корабль";
            this.btnParkShip.UseVisualStyleBackColor = true;
            this.btnParkShip.Click += new System.EventHandler(this.buttonParkShip_Click);
            // 
            // btnParkDieselShip
            // 
            this.btnParkDieselShip.Location = new System.Drawing.Point(928, 90);
            this.btnParkDieselShip.Name = "btnParkDieselShip";
            this.btnParkDieselShip.Size = new System.Drawing.Size(103, 62);
            this.btnParkDieselShip.TabIndex = 2;
            this.btnParkDieselShip.Text = "Поставить теплоход";
            this.btnParkDieselShip.UseVisualStyleBackColor = true;
            this.btnParkDieselShip.Click += new System.EventHandler(this.buttonParkDieselShip_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxTake);
            this.groupBox.Controls.Add(this.buttonTake);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(903, 281);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 292);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Забрать корабль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место: ";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(73, 35);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(43, 20);
            this.maskedTextBox.TabIndex = 2;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(25, 61);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(103, 23);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(6, 110);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(189, 148);
            this.pictureBoxTake.TabIndex = 4;
            this.pictureBoxTake.TabStop = false;
            // 
            // FormPier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 585);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnParkDieselShip);
            this.Controls.Add(this.btnParkShip);
            this.Controls.Add(this.pictureBoxPier);
            this.Name = "FormPier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Причал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPier;
        private System.Windows.Forms.Button btnParkShip;
        private System.Windows.Forms.Button btnParkDieselShip;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
    }
}