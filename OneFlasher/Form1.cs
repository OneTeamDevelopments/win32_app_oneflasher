using MaterialSkin;
using MaterialSkin.Controls;
using OneFlasher.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OneFlasher
{
    public partial class Form1 : MaterialForm
    {

        OpenFileDialog input = new OpenFileDialog();
        string romDir = "Rom_Files";

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            if (Directory.Exists(romDir)) Directory.Delete(romDir, true);

            Timer deviceCheck = new Timer();
            deviceCheck.Tick += new EventHandler(deviceChecker);
            deviceCheck.Interval = 25; // in miliseconds
            deviceCheck.Start();
        }

        private void deviceChecker(object sender, EventArgs e)
        {
            if (action.BackColor != System.Drawing.Color.BlueViolet) action.ForeColor = System.Drawing.Color.BlueViolet;
            checkDevice(1);
        }

        public string fastboot(string command)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "library/fastboot.exe",
                    Arguments = command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError=true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            StringBuilder q = new StringBuilder();
            while (!proc.HasExited)
            {
                q.Append(proc.StandardOutput.ReadToEnd());
                q.Append(proc.StandardError.ReadToEnd());
            }
            return q.ToString();
        }

        public string fastboot_get(string var,int line=0)
        {
            return fastboot(var).Split('\n')[line].Split(':')[1].Trim();
        }

        public bool checkDevice(int bg = 0)
        {
            if (fastboot("devices") != "")
            {
                if (bg == 1)
                {
                    androidDevice.Image = Resources.androidDevice_Connected;
                    board.Invoke((Action)delegate { board.Text = fastboot_get("getvar product"); });
                    serialno.Invoke((Action)delegate { serialno.Text = fastboot_get("getvar serialno"); });
                    bootloader.Invoke((Action)delegate { bootloader.Text = fastboot_get("getvar version-bootloader"); });
                    oem.Invoke((Action)delegate { oem.Text = (fastboot_get("oem device-info",2)=="true"?"Kilit Açık":"Kilitli."); });
                }
                return true;
            }
            else if (bg == 1)
            {
                androidDevice.Image = Resources.androidDevice_NotConnected;
                board.Invoke((Action)delegate { board.Text = "Algılanamadı."; });
                serialno.Invoke((Action)delegate { serialno.Text = "Algılanamadı."; });
                bootloader.Invoke((Action)delegate { bootloader.Text = "Algılanamadı."; });
                oem.Invoke((Action)delegate { oem.Text = "Algılanamadı."; });
            }
            return false;
        }

        private void flashRom_Click(object sender, EventArgs e)
        {
            if (checkDevice())
            {

                    if (MessageBox.Show("\"" + input.SafeFileName + "\" Yazılımının Kurulum İşlemini Onaylıyor Musunuz? İşlemlerden One Team Ve Rom Sahibi Sorumlu Tutulamaz!", "İşlem Onayı",
MessageBoxButtons.YesNo, MessageBoxIcon.Question,
MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                }
                else
                {
                    MessageBox.Show("Yazılım Dosyası Seçilmedi. Lütfen Yazılım Dosyası Seçiniz.", "Hata Oluştu!",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cihaz Bağlı Değil. Lütfen Cihazı Bootloader Moduna Alın.", "Hata Oluştu!",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void romFile_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            input.Reset();
            input.Filter = "OT Bin Dosyaları (*.otbin)|*.otbin";
            input.Title = "Yazılım Dosyasını Seçin";
            input.ShowDialog();

            if (input.FileNames.Length != 0)
            {

                    if (Directory.Exists(romDir)) Directory.Delete(romDir, true);

                    DirectoryInfo di = Directory.CreateDirectory(romDir);
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

                    progress.Value = 10;
                    action.Text = "Yazılım Okunuyor.";
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "library/oneteam.exe",
                            Arguments = "x -y -o " + romDir + " " + input.FileName + " *",
                            UseShellExecute = false,
                            CreateNoWindow = true
                        }
                    };
                    proc.Start();
                    proc.WaitForExit();
                    progress.Value = 25;
                    action.Text = "Yazılım Okundu.";
            }
            else
            {
                MessageBox.Show("Yazılım Seçilmedi. Lütfen Yazılım Dosyasını Seçin.", "Hata Oluştu!",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
