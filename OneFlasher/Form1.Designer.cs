namespace OneFlasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rom = new MaterialSkin.Controls.MaterialLabel();
            this.romFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flashRom = new MaterialSkin.Controls.MaterialRaisedButton();
            this.progress = new MaterialSkin.Controls.MaterialProgressBar();
            this.action = new MaterialSkin.Controls.MaterialLabel();
            this.androidDevice = new System.Windows.Forms.PictureBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.softwareInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider8 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider9 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.board = new MaterialSkin.Controls.MaterialLabel();
            this.serialno = new MaterialSkin.Controls.MaterialLabel();
            this.bootloader = new MaterialSkin.Controls.MaterialLabel();
            this.oem = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.androidDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // rom
            // 
            this.rom.Depth = 0;
            this.rom.Font = new System.Drawing.Font("Roboto", 11F);
            this.rom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rom.Location = new System.Drawing.Point(318, 88);
            this.rom.MouseState = MaterialSkin.MouseState.HOVER;
            this.rom.Name = "rom";
            this.rom.Size = new System.Drawing.Size(201, 24);
            this.rom.TabIndex = 5;
            this.rom.Text = "Yüklenecek Yazılım Dosyası : ";
            // 
            // romFile
            // 
            this.romFile.AutoSize = true;
            this.romFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.romFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.romFile.Depth = 0;
            this.romFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.romFile.Icon = null;
            this.romFile.Location = new System.Drawing.Point(552, 80);
            this.romFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.romFile.Name = "romFile";
            this.romFile.Primary = true;
            this.romFile.Size = new System.Drawing.Size(162, 36);
            this.romFile.TabIndex = 7;
            this.romFile.Text = "Yazılım Dosyası Seç";
            this.romFile.UseVisualStyleBackColor = true;
            this.romFile.Click += new System.EventHandler(this.romFile_Click);
            // 
            // flashRom
            // 
            this.flashRom.AutoSize = true;
            this.flashRom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flashRom.Cursor = System.Windows.Forms.Cursors.Default;
            this.flashRom.Depth = 0;
            this.flashRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flashRom.Icon = null;
            this.flashRom.Location = new System.Drawing.Point(734, 80);
            this.flashRom.MouseState = MaterialSkin.MouseState.HOVER;
            this.flashRom.Name = "flashRom";
            this.flashRom.Primary = true;
            this.flashRom.Size = new System.Drawing.Size(122, 36);
            this.flashRom.TabIndex = 8;
            this.flashRom.Text = "Yazılımı Yükle";
            this.flashRom.UseVisualStyleBackColor = true;
            this.flashRom.Click += new System.EventHandler(this.flashRom_Click);
            // 
            // progress
            // 
            this.progress.Depth = 0;
            this.progress.Location = new System.Drawing.Point(318, 574);
            this.progress.MouseState = MaterialSkin.MouseState.HOVER;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(535, 5);
            this.progress.TabIndex = 9;
            // 
            // action
            // 
            this.action.Depth = 0;
            this.action.Font = new System.Drawing.Font("Roboto", 11F);
            this.action.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.action.Location = new System.Drawing.Point(318, 540);
            this.action.MouseState = MaterialSkin.MouseState.HOVER;
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(536, 22);
            this.action.TabIndex = 10;
            this.action.Text = "İşlem Bekleniyor.";
            this.action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // androidDevice
            // 
            this.androidDevice.Location = new System.Drawing.Point(12, 74);
            this.androidDevice.Name = "androidDevice";
            this.androidDevice.Size = new System.Drawing.Size(283, 515);
            this.androidDevice.TabIndex = 11;
            this.androidDevice.TabStop = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(318, 516);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(536, 3);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(318, 385);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(3, 133);
            this.materialDivider3.TabIndex = 14;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(851, 385);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(3, 133);
            this.materialDivider4.TabIndex = 15;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // softwareInfo
            // 
            this.softwareInfo.Depth = 0;
            this.softwareInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.softwareInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.softwareInfo.Location = new System.Drawing.Point(318, 353);
            this.softwareInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.softwareInfo.Name = "softwareInfo";
            this.softwareInfo.Size = new System.Drawing.Size(130, 25);
            this.softwareInfo.TabIndex = 16;
            this.softwareInfo.Text = "Yazılım Bilgileri :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(318, 145);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 25);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Cihaz Bilgileri :";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(851, 177);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(3, 160);
            this.materialDivider5.TabIndex = 20;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(318, 177);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(3, 160);
            this.materialDivider6.TabIndex = 19;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // materialDivider7
            // 
            this.materialDivider7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider7.Depth = 0;
            this.materialDivider7.Location = new System.Drawing.Point(318, 337);
            this.materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider7.Name = "materialDivider7";
            this.materialDivider7.Size = new System.Drawing.Size(536, 3);
            this.materialDivider7.TabIndex = 18;
            this.materialDivider7.Text = "materialDivider7";
            // 
            // materialDivider8
            // 
            this.materialDivider8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider8.Depth = 0;
            this.materialDivider8.Location = new System.Drawing.Point(318, 177);
            this.materialDivider8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider8.Name = "materialDivider8";
            this.materialDivider8.Size = new System.Drawing.Size(536, 3);
            this.materialDivider8.TabIndex = 17;
            this.materialDivider8.Text = "materialDivider8";
            // 
            // materialDivider9
            // 
            this.materialDivider9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider9.Depth = 0;
            this.materialDivider9.Location = new System.Drawing.Point(318, 385);
            this.materialDivider9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider9.Name = "materialDivider9";
            this.materialDivider9.Size = new System.Drawing.Size(536, 3);
            this.materialDivider9.TabIndex = 22;
            this.materialDivider9.Text = "materialDivider9";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(327, 267);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(95, 22);
            this.materialLabel4.TabIndex = 25;
            this.materialLabel4.Text = "Bootloader :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(327, 194);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 22);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Board :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(327, 229);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(95, 22);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Serial :";
            // 
            // board
            // 
            this.board.Depth = 0;
            this.board.Font = new System.Drawing.Font("Roboto", 11F);
            this.board.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.board.Location = new System.Drawing.Point(428, 194);
            this.board.MouseState = MaterialSkin.MouseState.HOVER;
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(415, 22);
            this.board.TabIndex = 28;
            this.board.Text = "data";
            // 
            // serialno
            // 
            this.serialno.Depth = 0;
            this.serialno.Font = new System.Drawing.Font("Roboto", 11F);
            this.serialno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serialno.Location = new System.Drawing.Point(428, 229);
            this.serialno.MouseState = MaterialSkin.MouseState.HOVER;
            this.serialno.Name = "serialno";
            this.serialno.Size = new System.Drawing.Size(415, 22);
            this.serialno.TabIndex = 29;
            this.serialno.Text = "data";
            // 
            // bootloader
            // 
            this.bootloader.Depth = 0;
            this.bootloader.Font = new System.Drawing.Font("Roboto", 11F);
            this.bootloader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bootloader.Location = new System.Drawing.Point(428, 267);
            this.bootloader.MouseState = MaterialSkin.MouseState.HOVER;
            this.bootloader.Name = "bootloader";
            this.bootloader.Size = new System.Drawing.Size(415, 22);
            this.bootloader.TabIndex = 30;
            this.bootloader.Text = "data";
            // 
            // oem
            // 
            this.oem.Depth = 0;
            this.oem.Font = new System.Drawing.Font("Roboto", 11F);
            this.oem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oem.Location = new System.Drawing.Point(428, 303);
            this.oem.MouseState = MaterialSkin.MouseState.HOVER;
            this.oem.Name = "oem";
            this.oem.Size = new System.Drawing.Size(415, 22);
            this.oem.TabIndex = 32;
            this.oem.Text = "data";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(327, 303);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(95, 22);
            this.materialLabel6.TabIndex = 31;
            this.materialLabel6.Text = "Oem Kilidi :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 591);
            this.Controls.Add(this.oem);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.bootloader);
            this.Controls.Add(this.serialno);
            this.Controls.Add(this.board);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialDivider9);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider5);
            this.Controls.Add(this.materialDivider6);
            this.Controls.Add(this.materialDivider7);
            this.Controls.Add(this.materialDivider8);
            this.Controls.Add(this.softwareInfo);
            this.Controls.Add(this.materialDivider4);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.androidDevice);
            this.Controls.Add(this.action);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.flashRom);
            this.Controls.Add(this.romFile);
            this.Controls.Add(this.rom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Flasher - one-teams.com";
            ((System.ComponentModel.ISupportInitialize)(this.androidDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel rom;
        private MaterialSkin.Controls.MaterialRaisedButton romFile;
        private MaterialSkin.Controls.MaterialRaisedButton flashRom;
        private MaterialSkin.Controls.MaterialProgressBar progress;
        private MaterialSkin.Controls.MaterialLabel action;
        private System.Windows.Forms.PictureBox androidDevice;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialLabel softwareInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialDivider materialDivider7;
        private MaterialSkin.Controls.MaterialDivider materialDivider8;
        private MaterialSkin.Controls.MaterialDivider materialDivider9;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel board;
        private MaterialSkin.Controls.MaterialLabel serialno;
        private MaterialSkin.Controls.MaterialLabel bootloader;
        private MaterialSkin.Controls.MaterialLabel oem;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

