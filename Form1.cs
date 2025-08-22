using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace FileAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_fileselector.Items.Add("Dosya Türü Seçiniz:");
            cmb_fileselector.Items.Add("(*.txt)");
            cmb_fileselector.Items.Add("(*.docx)");
            cmb_fileselector.SelectedIndex = 0;
        }

        private void btn_txtanlyz_Click(object sender, EventArgs e)
        {
            ArrayList wordlist = new ArrayList();

            string combinedText = string.Join(" ", lst_txttext.Items.Cast<string>());//listbox içindeki itemları bir düz metin haline cevirdim.
            MatchCollection punctuations = Regex.Matches(combinedText, @"[é!'^+%&/()=?_.,<>£#$½{\[}\|*\-]");//noktalama işaretleri kümesi
            txt_textpuncnumber.Text = punctuations.Count.ToString();

            string[] conjuctions = { "ve", "ama", "fakat", "çünkü", "ile", "ya", "ya da", "ne", "ki", "de", "da", "dahi", "oysa", "lakin", "veya", "ise" }; //bağlaçları tanımladım.
            string cleanedText = Regex.Replace(combinedText, @"[^a-zA-ZğüşöçıİĞÜŞÖÇ\s]", ""); //sadece karakter içeren kelimeleri derledim
            string[] listboxContent = cleanedText.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


            //listboxtaki kelimeleri bir listeye ekledim. ve tüm kelimeleri küçük harfe çevirdim ki aynı kelime tekrar etmesin.
            foreach (var item in listboxContent)
            {
                wordlist.Add(item.ToString().ToLower());
            }

            //farklı kelimeleri bulmak için hashset fonksiyonunu kullandım.
            HashSet<string> uniqueWords = new HashSet<string>();
            foreach (string item in wordlist)
            {
                if (!uniqueWords.Contains(item))
                {
                    uniqueWords.Add(item);
                }
            }
            //farklı kelşime sayısının gösterilmesi için textBox1'e yazdırdım.
            int uniqueCount = uniqueWords.Count;
            txt_textuniqnumber.Text = uniqueCount.ToString();

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in wordlist)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;

                }
            }
            lst_txtrepeats.Items.Clear();
            lst_txtrepeats.Items.Add("----TEKRARLAR VE SAYILARI----");
            foreach (var pair in wordCounts.OrderByDescending(x => x.Value))
            {
                lst_txtrepeats.Items.Add($"{pair.Key}: {pair.Value} kez");
            }

            MessageBox.Show("Metin Analizi Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btn_txtupload_Click(object sender, EventArgs e)
        {
            timer1.Start();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Metin Dosyaları|*.txt";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fullText = "";

                if (dialog.FileName.EndsWith("*.txt"))
                {
                    fullText = File.ReadAllText(dialog.FileName);
                }
            }
            MessageBox.Show("Dosya Yolu: " + dialog.FileName, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StreamReader read = new StreamReader(dialog.FileName);
            string satır = read.ReadLine();
            while (satır != null)
            {
                lst_txttext.Items.Add(satır);
                satır = read.ReadLine();
            }
            prg1_uploadstatus.Value = 0; // ProgressBar'ı sıfırla ki formu temizledikten sonra bir daha yükleme işlemi yapabilsin.
            cmb_fileselector.SelectedIndex = 0; // comboboxı ilk haline getirdim.
        }

        private void btn_clearform_Click(object sender, EventArgs e)
        {
            //SATIRLARI TEK TEK SİLME int secilen = listBox1.SelectedIndex;
            txt_textuniqnumber.Clear();
            txt_textpuncnumber.Clear();
            txt_wordpuncnumber.Clear();
            txt_worduniqnumber.Clear();
            rtx_wordtext.Clear();
            lst_txttext.Items.Clear();
            lst_txtrepeats.Items.Clear();
            lst_wordrepeats.Items.Clear();
            MessageBox.Show("Form Başarıyla Temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*if (secilen >= 0)
            {
                listBox1.Items.RemoveAt(secilen);
                
            }
            else
            {
                MessageBox.Show("Silmek için satır seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }TXT'NİN SATIRLARI TEK TEK SİLMEK İSTERSEN BU KOMUTU UYGULA.*/

        }

        private void cmb_fileselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxtan seçilen dosya türüne göre butonları etkinleştirme ve deaktifleştirme yapıldı
            string selected = cmb_fileselector.SelectedItem.ToString();
            if (selected == "(*.txt)")
            {
                btn_txtupload.Enabled = true;
                btn_wordupload.Enabled = false;
            }
            else if (selected == "(*.docx)")
            {
                btn_txtupload.Enabled = false;
                btn_wordupload.Enabled = true;
            }
            else
            {
                btn_txtupload.Enabled = false;
                btn_wordupload.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //yükleme durumunu göstermek için timer kullanıldı.
            prg1_uploadstatus.Value += 10;
            if (prg1_uploadstatus.Value == 100)
            {
                timer1.Stop();
            }
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            prg2_uploadstatus.Value += 10;
            if (prg2_uploadstatus.Value == 100)
            {
                timer2.Stop();
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //aşağıdaki button2 düzenlenecek
        private void btn_wordupload_Click(object sender, EventArgs e)
        {
            timer2.Start();
            //OpenFileDialog fileDialog = new OpenFileDialog();
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.ShowDialog();//fileDialog

            dialog.Filter = "Word Belgeleri|*.docx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Dosya Yolu: " + dialog.FileName, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string filepathe = dialog.FileName.ToString();//fileDialog
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Word.Document document = app.Documents.Open(filepathe);
                string data = document.Content.Text;
                rtx_wordtext.Text = data;
                app.Quit();
            }
            prg2_uploadstatus.Value = 0; // ProgressBar'ı sıfırla ki bir daha yükleme işlemi yapabilsin.
            cmb_fileselector.SelectedIndex = 0; // comboboxı ilk haline getirdim.
        }


        private void btn_wordanlyz_Click(object sender, EventArgs e)
        {
            ArrayList wordlist = new ArrayList();

            MatchCollection punctuations = Regex.Matches(rtx_wordtext.Text, @"[é!'^+%&/()=?_.,<>£#$½{[}\|*-]");//noktalama işaretleri
            txt_wordpuncnumber.Text = punctuations.Count.ToString();//noktalama işaretlerinin sayısını textBox2'ye yazdırdım.

            string[] conjuctions = { "ve", "ama", "fakat", "çünkü", "ile", "ya", "ya da", "ne", "ki", "de", "da", "dahi", "oysa", "lakin", "veya", "ise" };//bağlaçları tanımladım.
            string cleanedText = Regex.Replace(rtx_wordtext.Text, @"[^a-zA-ZğüşöçıİĞÜŞÖÇ\s]", "");//sadece karakter içeren kelimeleri derledim
            string[] richTextBoxContent = cleanedText.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);// richtextbox içindeki kelimeleri boşluk, yeni satır ve satır sonu karakterlerine göre ayırdım. satır boşluklarını temizledim


            foreach (var item in richTextBoxContent)
            {
                wordlist.Add(item.ToString().ToLower());
            }

            //tekrar eden kelimeleri önlemek için bir HashSet kullandım ör: Elma , elma, ELMA vb.
            HashSet<string> uniqueWords = new HashSet<string>();
            foreach (string item in wordlist)
            {
                if (!uniqueWords.Contains(item))
                {
                    uniqueWords.Add(item);
                }
            }

            //richtextbox içindeki kelimeleri tek tek kontrol ettim ve bağlaçları içermeyen kelimeleri uniqueWords setine ekledim.
            foreach (var item in richTextBoxContent)
            {
                string lowerItem = item.ToString().ToLower();
                if (!conjuctions.Contains(lowerItem))
                {
                    uniqueWords.Add(lowerItem);
                }
            }

            // farklı kelime sayısının gösterilmesi için textBox3'e yazdırdım.  
            int uniqueCount = uniqueWords.Count;
            txt_worduniqnumber.Text = uniqueCount.ToString();

            //burada tekrar eden kelimeleri bulmak için sözlük kullandım
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            //richTextBox içindeki kelimeleri tek tek kontrol ettim kaç kez tekrar ettiyse o kadar sözlüğe ekledim
            foreach (string word in richTextBoxContent)
            {
                string lowerWord = word.ToLower();
                if (!conjuctions.Contains(lowerWord))//burada küçük harfle yazılan kelimeleri bağlaçlar ile karşılaştırdım ve bağlaçları içermeyen kelimeleri sözlüğe ekledim.
                {
                    if (wordCounts.ContainsKey(lowerWord))
                        wordCounts[lowerWord]++;
                    else
                        wordCounts[lowerWord] = 1;
                }
            }
            lst_wordrepeats.Items.Clear();
            //sözlükteki kelimeleri tekrar sayısına göre azalan şekilde sıraladım ve listBox3'e ekledim
            lst_wordrepeats.Items.Add("----TEKRARLAR VE SAYILARI----");
            foreach (var pair in wordCounts.OrderByDescending(x => x.Value))
            {
                lst_wordrepeats.Items.Add($"{pair.Key}: {pair.Value} kez");
            }

            MessageBox.Show("Metin Analizi Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
