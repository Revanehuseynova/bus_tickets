using System;
using System.Windows.Forms;

namespace travel_ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;

            string[] cities = { "Bakı", "Gəncə", "Sumqayıt", "Mingəçevir", "Naxçıvan", "Lənkəran", "Şəki", "Qəbələ", "Quba", "Xankəndi" };

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.AddRange(cities);
            comboBox2.Items.AddRange(cities);
        }

        // 1. Yer Dəyişdirmə Düyməsi (<>)
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        // 2. Buy Ticket (Bilet Al) Düyməsi
        private void button2_Click(object sender, EventArgs e)
        {
            // Bütün xanaların doluluğunu yoxlayırıq
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||   // Ad və Soyad
                string.IsNullOrWhiteSpace(textBox3.Text) ||   // FIN
                string.IsNullOrWhiteSpace(textBox1.Text) ||   // Oturacaq (Yer)
                !maskedTextBox1.MaskCompleted ||              // Tarix
                !maskedTextBox2.MaskCompleted ||              // Saat
                !maskedTextBox4.MaskCompleted)                // Telefon
            {
                MessageBox.Show("Xahiş olunur bütün məlumatları (Şəhərlər, Ad, FIN, Tarix, Saat, Telefon, Yer) tam doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passengerInfo = $"{textBox2.Text} | {comboBox1.Text} -> {comboBox2.Text} | Tarix: {maskedTextBox1.Text} {maskedTextBox2.Text} | Yer: {textBox1.Text} | FIN: {textBox3.Text} | Tel: {maskedTextBox4.Text}";

            listBox1.Items.Add(passengerInfo);

            MessageBox.Show("Bilet uğurla əlavə olundu!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Bilet alındıqdan sonra daxil edilən xanaları təmizləyirik
            ClearInputFields();
        }

        // 3. Delete Ticket (Bileti Sil / Təmizlə) Düyməsi
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("Seçilmiş bilet silindi!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listBox1.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Siyahıdakı bütün biletlər silinsinmi?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                    ClearInputFields();
                    MessageBox.Show("Bütün biletlər təmizləndi!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Siyahıda silinəcək bilet yoxdur!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xanaları təmizləyən funksiya
        private void ClearInputFields()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox4.Clear();
        }

        // 4. Exit Program (Çıxış Düyməsi)
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
    }
}