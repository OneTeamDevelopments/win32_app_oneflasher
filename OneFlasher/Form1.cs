using MaterialSkin;
using MaterialSkin.Controls;
using OneFlasher.Properties;
using System;
using System.Collections.Generic;
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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

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
                    RedirectStandardError = true,
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

        public string fastboot_get(string var, int line = 0)
        {
            return fastboot(var).Split('\n')[line].Split(':')[1].Trim();
        }

        public string fastboot_flash(string part, string file)
        {
            return fastboot("flash " + part + " " + file);
        }

        public void fastboot_reboot()
        {
            fastboot("reboot");
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
                    oem.Invoke((Action)delegate { oem.Text = (fastboot_get("oem device-info", 2) == "true" ? "Kilit Açık" : "Kilitli."); });
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
                    DirectoryInfo romFiles = new DirectoryInfo("Rom_Files");
                    FileInfo[] files = romFiles.GetFiles("*");

                    List<KeyValuePair<string, string>> flashList = new List<KeyValuePair<string, string>>();

                    foreach (FileInfo file in files)
                    {
                        if (file.Name == "rom.ini" || file.Name.Substring(0, 3) == "oem") continue;
                        flashList.Add(new KeyValuePair<string, string>(file.Name.Split('.')[0], file.Name));
                    }
                    if (oemType.Text != "") flashList.Add(new KeyValuePair<string, string>("oem", oemType.Text + ".img"));

                    foreach (KeyValuePair<string, string> flash in flashList)
                    {
                        action.Text = flash.Key + " Flashlanıyor.";
                        fastboot_flash(flash.Key, romDir + "/" + flash.Value);
                        action.Text = flash.Key + " Flashlandı.";
                    }

                    action.Text = "Cihaz Yeniden Başlatılıyor...";
                    progress.Value = 90;

                    MessageBox.Show("Yazılım Kurulum İşlemi Tamamlandı. Cihazınız Yeniden Başlatılıyor.", "Bilgilendirme Mesajı!",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fastboot_reboot();
                    action.Text = "Flashlama İşlemi Tamamlandı.";
                    progress.Value = 100;
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

                var ini = new IniFile(romDir + "/rom.ini");
                deviceName.Text = ini.Read("deviceName", "OneCompressor") + "( " + ini.Read("deviceCode", "OneCompressor") + " )";
                romName.Text = ini.Read("romName", "OneCompressor") + " ( V" + ini.Read("romVersion", "OneCompressor") + " )";

                oemType.Items.Clear();

                DirectoryInfo romFiles = new DirectoryInfo("Rom_Files");
                FileInfo[] files = romFiles.GetFiles("oem*");

                foreach (FileInfo file in files)
                {
                    oemType.Items.Add(file.Name.Split('.')[0]);
                }
                if (oemType.Items.Count != 0) oemType.SelectedIndex = 0;
                oemType.Update();

                action.Text = "Yazılım Okundu.";
            }
            else
            {
                deviceName.Text = "";
                romName.Text = "";
                MessageBox.Show("Yazılım Seçilmedi. Lütfen Yazılım Dosyasını Seçin.", "Hata Oluştu!",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
