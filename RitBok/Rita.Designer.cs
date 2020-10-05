namespace RitBok
{
    partial class RitClass
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
            this.BtnLinje = new System.Windows.Forms.Button();
            this.BtnRektangel = new System.Windows.Forms.Button();
            this.BtnEllips = new System.Windows.Forms.Button();
            this.BtnPenna = new System.Windows.Forms.Button();
            this.BtnÅngra = new System.Windows.Forms.Button();
            this.tbxStorlek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectColor = new System.Windows.Forms.ColorDialog();
            this.pbxColorView = new System.Windows.Forms.PictureBox();
            this.BtnBytFärg = new System.Windows.Forms.Button();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBrushSize = new System.Windows.Forms.TextBox();
            this.BtnRedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLinje
            // 
            this.BtnLinje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLinje.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnLinje.Location = new System.Drawing.Point(29, 23);
            this.BtnLinje.Name = "BtnLinje";
            this.BtnLinje.Size = new System.Drawing.Size(144, 53);
            this.BtnLinje.TabIndex = 0;
            this.BtnLinje.Text = "Linje";
            this.BtnLinje.UseVisualStyleBackColor = true;
            this.BtnLinje.Click += new System.EventHandler(this.BtnLinje_Click);
            // 
            // BtnRektangel
            // 
            this.BtnRektangel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRektangel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnRektangel.Location = new System.Drawing.Point(29, 93);
            this.BtnRektangel.Name = "BtnRektangel";
            this.BtnRektangel.Size = new System.Drawing.Size(144, 53);
            this.BtnRektangel.TabIndex = 1;
            this.BtnRektangel.Text = "Rektangel";
            this.BtnRektangel.UseVisualStyleBackColor = true;
            this.BtnRektangel.Click += new System.EventHandler(this.BtnRektangel_Click);
            // 
            // BtnEllips
            // 
            this.BtnEllips.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEllips.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnEllips.Location = new System.Drawing.Point(29, 164);
            this.BtnEllips.Name = "BtnEllips";
            this.BtnEllips.Size = new System.Drawing.Size(144, 53);
            this.BtnEllips.TabIndex = 2;
            this.BtnEllips.Text = "Ellips";
            this.BtnEllips.UseVisualStyleBackColor = true;
            this.BtnEllips.Click += new System.EventHandler(this.BtnEllips_Click);
            // 
            // BtnPenna
            // 
            this.BtnPenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPenna.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnPenna.Location = new System.Drawing.Point(29, 235);
            this.BtnPenna.Name = "BtnPenna";
            this.BtnPenna.Size = new System.Drawing.Size(144, 53);
            this.BtnPenna.TabIndex = 3;
            this.BtnPenna.Text = "Penna";
            this.BtnPenna.UseVisualStyleBackColor = true;
            this.BtnPenna.Click += new System.EventHandler(this.BtnPenna_Click);
            // 
            // BtnÅngra
            // 
            this.BtnÅngra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnÅngra.ForeColor = System.Drawing.Color.Red;
            this.BtnÅngra.Location = new System.Drawing.Point(29, 356);
            this.BtnÅngra.Name = "BtnÅngra";
            this.BtnÅngra.Size = new System.Drawing.Size(144, 53);
            this.BtnÅngra.TabIndex = 4;
            this.BtnÅngra.Text = "Ångra";
            this.BtnÅngra.UseVisualStyleBackColor = true;
            this.BtnÅngra.Click += new System.EventHandler(this.BtnÅngra_Click);
            // 
            // tbxStorlek
            // 
            this.tbxStorlek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStorlek.Location = new System.Drawing.Point(113, 430);
            this.tbxStorlek.Name = "tbxStorlek";
            this.tbxStorlek.Size = new System.Drawing.Size(100, 23);
            this.tbxStorlek.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Storlek";
            // 
            // SelectColor
            // 
            this.SelectColor.AnyColor = true;
            // 
            // pbxColorView
            // 
            this.pbxColorView.Location = new System.Drawing.Point(44, 490);
            this.pbxColorView.Name = "pbxColorView";
            this.pbxColorView.Size = new System.Drawing.Size(37, 33);
            this.pbxColorView.TabIndex = 7;
            this.pbxColorView.TabStop = false;
            // 
            // BtnBytFärg
            // 
            this.BtnBytFärg.Location = new System.Drawing.Point(87, 496);
            this.BtnBytFärg.Name = "BtnBytFärg";
            this.BtnBytFärg.Size = new System.Drawing.Size(54, 27);
            this.BtnBytFärg.TabIndex = 8;
            this.BtnBytFärg.Text = "Byt Färg";
            this.BtnBytFärg.UseVisualStyleBackColor = true;
            this.BtnBytFärg.Click += new System.EventHandler(this.BtnBytFärg_Click);
            // 
            // pbxMain
            // 
            this.pbxMain.Location = new System.Drawing.Point(228, 12);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(692, 516);
            this.pbxMain.TabIndex = 9;
            this.pbxMain.TabStop = false;
            this.pbxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickDetect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pensel Storlek";
            // 
            // tbxBrushSize
            // 
            this.tbxBrushSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrushSize.Location = new System.Drawing.Point(113, 461);
            this.tbxBrushSize.Name = "tbxBrushSize";
            this.tbxBrushSize.Size = new System.Drawing.Size(100, 23);
            this.tbxBrushSize.TabIndex = 10;
            // 
            // BtnRedo
            // 
            this.BtnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRedo.ForeColor = System.Drawing.Color.Red;
            this.BtnRedo.Location = new System.Drawing.Point(29, 297);
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.Size = new System.Drawing.Size(144, 53);
            this.BtnRedo.TabIndex = 12;
            this.BtnRedo.Text = "Gör Om";
            this.BtnRedo.UseVisualStyleBackColor = true;
            this.BtnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // RitClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 563);
            this.Controls.Add(this.BtnRedo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBrushSize);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.BtnBytFärg);
            this.Controls.Add(this.pbxColorView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxStorlek);
            this.Controls.Add(this.BtnÅngra);
            this.Controls.Add(this.BtnPenna);
            this.Controls.Add(this.BtnEllips);
            this.Controls.Add(this.BtnRektangel);
            this.Controls.Add(this.BtnLinje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RitClass";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RitClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLinje;
        private System.Windows.Forms.Button BtnRektangel;
        private System.Windows.Forms.Button BtnEllips;
        private System.Windows.Forms.Button BtnPenna;
        private System.Windows.Forms.Button BtnÅngra;
        private System.Windows.Forms.TextBox tbxStorlek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog SelectColor;
        private System.Windows.Forms.PictureBox pbxColorView;
        private System.Windows.Forms.Button BtnBytFärg;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBrushSize;
        private System.Windows.Forms.Button BtnRedo;
    }
}

