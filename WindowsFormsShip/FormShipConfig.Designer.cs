namespace WindowsFormsShip
{
    partial class FormShipConfig
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
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelDieselShip = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.panelShip = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelViolet = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxType.SuspendLayout();
            this.panelShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelDieselShip);
            this.groupBoxType.Controls.Add(this.labelShip);
            this.groupBoxType.Location = new System.Drawing.Point(12, 46);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(152, 146);
            this.groupBoxType.TabIndex = 1;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип корабля";
            // 
            // labelDieselShip
            // 
            this.labelDieselShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDieselShip.Location = new System.Drawing.Point(22, 95);
            this.labelDieselShip.Name = "labelDieselShip";
            this.labelDieselShip.Size = new System.Drawing.Size(100, 42);
            this.labelDieselShip.TabIndex = 1;
            this.labelDieselShip.Text = "Теплоход";
            this.labelDieselShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDieselShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDieselShip_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(22, 33);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(100, 41);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShip.Controls.Add(this.label1);
            this.panelShip.Controls.Add(this.labelMainColor);
            this.panelShip.Controls.Add(this.pictureBoxShip);
            this.panelShip.Location = new System.Drawing.Point(170, 25);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(200, 237);
            this.panelShip.TabIndex = 2;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(48, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доп. цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(48, 131);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(110, 36);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShip.Location = new System.Drawing.Point(3, 8);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(194, 114);
            this.pictureBoxShip.TabIndex = 0;
            this.pictureBoxShip.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelViolet);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelLightBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Location = new System.Drawing.Point(402, 25);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(137, 250);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelViolet
            // 
            this.panelViolet.AllowDrop = true;
            this.panelViolet.BackColor = System.Drawing.Color.Violet;
            this.panelViolet.Location = new System.Drawing.Point(72, 187);
            this.panelViolet.Name = "panelViolet";
            this.panelViolet.Size = new System.Drawing.Size(50, 50);
            this.panelViolet.TabIndex = 7;
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(6, 187);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(50, 50);
            this.panelBlue.TabIndex = 6;
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.AllowDrop = true;
            this.panelLightBlue.BackColor = System.Drawing.Color.Aqua;
            this.panelLightBlue.Location = new System.Drawing.Point(72, 131);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(50, 50);
            this.panelLightBlue.TabIndex = 5;
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(6, 131);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(50, 50);
            this.panelGreen.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(72, 75);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(50, 50);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(6, 75);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(50, 50);
            this.panelRed.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.AllowDrop = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(72, 19);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(50, 50);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(6, 19);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(50, 50);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(45, 203);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(45, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 301);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBoxType);
            this.Name = "FormShipConfig";
            this.Text = "Выбор корабля";
            this.groupBoxType.ResumeLayout(false);
            this.panelShip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelDieselShip;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelViolet;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}