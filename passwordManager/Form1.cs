using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace passwordManager
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> passwordDatabase = new Dictionary<string, string>();
        private const string PasswordsFile = "passwords.txt";
        private const int TimeoutInSeconds = 15;
        private Timer lockTimer;

        public Form1()
        {
            InitializeComponent();
            LoadPasswords();

            lockTimer = new Timer();
            lockTimer.Interval = TimeoutInSeconds * 1000;
            lockTimer.Tick += timer1_Tick;
            lockTimer.Start();
        }

        private void LoadPasswords()
        {
            if (File.Exists(PasswordsFile))
            {
                var lines = File.ReadAllLines(PasswordsFile);

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        passwordDatabase[parts[0]] = parts[1];
                    }
                }
            }
        }

        private void SavePasswords()
        {
            var lines = new List<string>();
            foreach (var kvp in passwordDatabase)
            {
                lines.Add($"{kvp.Key},{kvp.Value}");
            }

            File.WriteAllLines(PasswordsFile, lines);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SavePasswords();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            lockTimer.Stop();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            var key = KeyTextBox.Text;

            if (passwordDatabase.TryGetValue(key, out var encryptedPassword))
            {
                PasswordTextBox.Text = Decrypt(encryptedPassword);
            }

            else
            {
                MessageBox.Show("Slaptažodis nerastas");
            }

            RefreshTimer();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var key = KeyTextBox.Text;
            var newPassword = PasswordTextBox.Text;

            if (passwordDatabase.ContainsKey(key))
            {
                passwordDatabase[key] = Encrypt(newPassword);
                MessageBox.Show("Slaptažodis pakeistas sėkmingai");
            }

            else
            {
                MessageBox.Show("Slaptažodis nerastas");
            }

            KeyTextBox.Clear();
            PasswordTextBox.Clear();

            RefreshTimer();
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            if (KeyTextBox.Text == "" || KeyTextBox.Text == " " || KeyTextBox.Text == " ")
            {
                MessageBox.Show("Negali būti tuščias slaptažodis!");
            }
            
            else
            {
                var key = KeyTextBox.Text;
                var password = PasswordTextBox.Text;

                passwordDatabase[key] = Encrypt(password);
                KeyTextBox.Clear();
                PasswordTextBox.Clear();
            }

            RefreshTimer();
        }

        private string Encrypt(string clearText)
        {
            var data = Encoding.UTF8.GetBytes(clearText);
            var encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encrypted);
        }

        private string Decrypt(string cipherText)
        {
            var data = Convert.FromBase64String(cipherText);
            var decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decrypted);
        }

        private void GenerateButton_Click_1(object sender, EventArgs e)
        {
            var rng = new RNGCryptoServiceProvider();
            var buffer = new byte[10];
            rng.GetBytes(buffer);
            var generatedPassword = Convert.ToBase64String(buffer.Take(7).ToArray());
            PasswordTextBox.Text = generatedPassword;

            RefreshTimer();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            var key = KeyTextBox.Text;

            if (passwordDatabase.ContainsKey(key))
            {
                passwordDatabase.Remove(key);
                MessageBox.Show("Slaptažodis sėkmingai ištrintas");
            }
            else
            {
                MessageBox.Show("Slaptažodis nerastas");
            }

            KeyTextBox.Clear();
            PasswordTextBox.Clear();

            RefreshTimer();
        }

        private void DisplayAllButton_Click(object sender, EventArgs e)
        {
            string key = KeyTextBox.Text;

            if (!passwordDatabase.ContainsKey(key))
            {
                DisplayTextBox.Text = "Su šiuo raktu slaptažodžių nėra.";
                return;
            }

            StringBuilder sb = new StringBuilder();
            int counter = 1;

            foreach (var entry in passwordDatabase)
            {
                if (entry.Key.Equals(key))
                {
                    sb.AppendLine($"{counter}. Slaptažodis: {Decrypt(entry.Value)}");
                    counter++;
                }
            }

            DisplayTextBox.Text = sb.ToString();

            RefreshTimer();
        }

        private void btnRodyti_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '\0')
            {
                PasswordTextBox.PasswordChar = '*';
            }

            else
            {
                PasswordTextBox.PasswordChar = '\0';
            }

            RefreshTimer();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Clear();
            RefreshTimer();
        }

        private void btnDidint_Click(object sender, EventArgs e)
        {
            float currentSize = DisplayTextBox.Font.Size;
            DisplayTextBox.Font = new Font(DisplayTextBox.Font.FontFamily, currentSize + 1);
        }

        private void btnMazint_Click(object sender, EventArgs e)
        {
            float currentSize = DisplayTextBox.Font.Size;
            DisplayTextBox.Font = new Font(DisplayTextBox.Font.FontFamily, currentSize - 1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string key = KeyTextBox2.Text;

            if (!passwordDatabase.ContainsKey(key))
            {
                MessageBox.Show("Su šiuo raktu slaptažodžių nėra.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                int counter = 1;

                foreach (var entry in passwordDatabase)
                {
                    if (entry.Key.Equals(key))
                    {
                        sb.AppendLine($"{counter}. Slaptažodis: {Decrypt(entry.Value)}");
                        counter++;
                    }
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Slaptažodžiai sėkmingai įrašyti į failą.");
            }

            RefreshTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LockApplication();
        }

        private void LockApplication()
        {
            KeyTextBox.Text = "";
            KeyTextBox2.Text = "";
            PasswordTextBox.Text = "";
            DisplayTextBox.Text = "";

            DialogResult dr = MessageBox.Show("Ar norite tęsti?", "Programa užrakinta", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                lockTimer.Stop();
                lockTimer.Start();
            }

            else
            {
                Application.Exit();
            }
        }

        private void RefreshTimer()
        {
            lockTimer.Stop();
            lockTimer.Start();
        }
    }
}
