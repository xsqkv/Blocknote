using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
namespace Блокнот
{
    public partial class Form1 : Form{public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Tick += new EventHandler((sender, e) =>{if ((Opacity += 0.04d) == 1) timer1.Stop();});
            timer1.Interval = 10;
            timer1.Start();
            saveFileDialog1.DefaultExt = "Untitled";
saveFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
fontDialog1.ShowColor = true;
colorDialog1.FullOpen = true;
colorDialog1.Color = this.BackColor;
}
private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
{
}
private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
{
if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
return;
string filename = saveFileDialog1.FileName;
System.IO.File.WriteAllLines(filename, richTextBox1.Lines);
MessageBox.Show("Файл сохранен", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
    return;
string filename = openFileDialog1.FileName;
string fileText = System.IO.File.ReadAllText(filename);
richTextBox1.Text = fileText;
MessageBox.Show("Файл открыт","Info", MessageBoxButtons.OK , MessageBoxIcon.Information);
    }
private void заменитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.Text = richTextBox1.Text.Replace(toolStripTextBox1.Text , toolStripTextBox2.Text);
    }
private void шрифтЦветToolStripMenuItem_Click(object sender, EventArgs e)
{
if (fontDialog1.ShowDialog() == DialogResult.Cancel)
    return;
richTextBox1.Font = fontDialog1.Font; 
}      
private void toolStripMenuItem1_Click(object sender, EventArgs e)
{
if (colorDialog1.ShowDialog() == DialogResult.Cancel)
    return;
this.BackColor = colorDialog1.Color;
}
private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
{
this.Opacity = 0;
зелёныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
стандартToolStripMenuItem.BackColor = SystemColors.Control;
белыйToolStripMenuItem.BackColor = Color.DodgerBlue;
жёлтыйНаЧёрномToolStripMenuItem.BackColor = SystemColors.Control;
оранжевыйНаЧерномToolStripMenuItem.BackColor = SystemColors.Control;
красныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
голубойНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
Form1 frm = new Form1();
frm.BackColor = Color.Gainsboro;
richTextBox1.ForeColor = Color.Black;
richTextBox1.BackColor = Color.White;
label1.ForeColor = Color.White;
label2.ForeColor = Color.White;
label3.ForeColor = Color.White;
label4.ForeColor = Color.White;
button1.ForeColor = Color.White;
button4.ForeColor = Color.White;
button6.ForeColor = Color.White;
button5.ForeColor = Color.White;
}
private void стандартToolStripMenuItem_Click(object sender, EventArgs e)
{
this.Opacity = 0;
зелёныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
стандартToolStripMenuItem.BackColor = Color.DodgerBlue;
белыйToolStripMenuItem.BackColor = SystemColors.Control;
жёлтыйНаЧёрномToolStripMenuItem.BackColor = SystemColors.Control;
оранжевыйНаЧерномToolStripMenuItem.BackColor = SystemColors.Control;
красныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
голубойНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
richTextBox1.BackColor = Color.FromArgb(43, 43, 43);
richTextBox1.ForeColor = Color.White;
label1.ForeColor = Color.White;
label2.ForeColor = Color.White;
label3.ForeColor = Color.White;
label4.ForeColor = Color.White;
button1.ForeColor = Color.White;
button4.ForeColor = Color.White;
button6.ForeColor = Color.White;
button5.ForeColor = Color.White;
}
private void button1_Click(object sender, EventArgs e)
{
try
{
    richTextBox1.Clear();
}
catch (Exception)
{
    MessageBox.Show("Поле и так пусто", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private void жёлтыйНаЧёрномToolStripMenuItem_Click(object sender, EventArgs e)
{
this.Opacity = 0;
зелёныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
стандартToolStripMenuItem.BackColor = SystemColors.Control;
белыйToolStripMenuItem.BackColor = SystemColors.Control;
жёлтыйНаЧёрномToolStripMenuItem.BackColor = Color.DodgerBlue;
оранжевыйНаЧерномToolStripMenuItem.BackColor = SystemColors.Control;
красныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
голубойНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
richTextBox1.BackColor = Color.FromArgb(43, 43, 43);
richTextBox1.ForeColor = Color.Yellow;
label1.ForeColor = Color.Yellow;
label2.ForeColor = Color.Yellow;
label3.ForeColor = Color.Yellow;
label4.ForeColor = Color.Yellow;
button1.ForeColor = Color.Yellow;
button4.ForeColor = Color.Yellow;
button6.ForeColor = Color.Yellow;
button5.ForeColor = Color.Yellow;
}
private void оранжевыйНаЧерномToolStripMenuItem_Click(object sender, EventArgs e)
{
this.Opacity = 0;
зелёныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
стандартToolStripMenuItem.BackColor = SystemColors.Control;
белыйToolStripMenuItem.BackColor = SystemColors.Control;
жёлтыйНаЧёрномToolStripMenuItem.BackColor = SystemColors.Control;
оранжевыйНаЧерномToolStripMenuItem.BackColor = Color.DodgerBlue;
красныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
голубойНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
richTextBox1.BackColor = Color.FromArgb(43, 43, 43);
richTextBox1.ForeColor = Color.Orange;
label1.ForeColor = Color.Orange;
label2.ForeColor = Color.Orange;
label3.ForeColor = Color.Orange;
label4.ForeColor = Color.Orange;
button1.ForeColor = Color.Orange;
button4.ForeColor = Color.Orange;
button6.ForeColor = Color.Orange;
button5.ForeColor = Color.Orange;
}
private void красныйНаТёмномToolStripMenuItem_Click(object sender, EventArgs e)
{
this.Opacity = 0;
зелёныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
стандартToolStripMenuItem.BackColor = SystemColors.Control;
белыйToolStripMenuItem.BackColor = SystemColors.Control;
жёлтыйНаЧёрномToolStripMenuItem.BackColor = SystemColors.Control;
оранжевыйНаЧерномToolStripMenuItem.BackColor = SystemColors.Control;
красныйНаТёмномToolStripMenuItem.BackColor = Color.DodgerBlue;
голубойНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
richTextBox1.BackColor = Color.FromArgb(43, 43, 43);
richTextBox1.ForeColor = Color.IndianRed;
label1.ForeColor = Color.Red;
label2.ForeColor = Color.Red;
label3.ForeColor = Color.Red;
label4.ForeColor = Color.Red;
button1.ForeColor = Color.Red;
button4.ForeColor = Color.Red;
button6.ForeColor = Color.Red;
button5.ForeColor = Color.Red;
}
private void голубойНаТёмномToolStripMenuItem_Click(object sender, EventArgs e)
{
this.Opacity = 0;
зелёныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
стандартToolStripMenuItem.BackColor = SystemColors.Control;
белыйToolStripMenuItem.BackColor = SystemColors.Control;
жёлтыйНаЧёрномToolStripMenuItem.BackColor = SystemColors.Control;
оранжевыйНаЧерномToolStripMenuItem.BackColor = SystemColors.Control;
красныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
голубойНаТёмномToolStripMenuItem.BackColor = Color.DodgerBlue;
richTextBox1.BackColor = Color.FromArgb(43, 43, 43);
richTextBox1.ForeColor = Color.DeepSkyBlue;
label1.ForeColor = Color.DeepSkyBlue;
label2.ForeColor = Color.DeepSkyBlue;
label3.ForeColor = Color.DeepSkyBlue;
label4.ForeColor = Color.DeepSkyBlue;
button1.ForeColor = Color.DeepSkyBlue;
button4.ForeColor = Color.DeepSkyBlue;
button6.ForeColor = Color.DeepSkyBlue;
button5.ForeColor = Color.DeepSkyBlue;
}
private void button2_Click(object sender, EventArgs e)
{
this.Close();
}
private void button2_MouseEnter(object sender, EventArgs e)
{
button2.ForeColor = Color.Red;
button2.BackColor = Color.White;
}
private void button2_MouseLeave(object sender, EventArgs e)
{
button2.ForeColor = Color.White;
button2.BackColor = Color.Red;
}
private void button4_Click(object sender, EventArgs e)
{
 if (richTextBox1.SelectionLength > 0)
 richTextBox1.Copy();
 else if (richTextBox1.SelectionLength == 0)
 MessageBox.Show("Выделите Текст", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
private void button5_Click(object sender, EventArgs e)
{
if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
{
    richTextBox1.Paste();
}
}
private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
{
if (richTextBox1.TextLength > 0)
    richTextBox1.SelectAll();
MessageBox.Show("Все поля успешно выделенны", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
private void button6_Click(object sender, EventArgs e)
{
if (richTextBox1.SelectionLength > 0)
    richTextBox1.Cut();
else if (richTextBox1.SelectionLength == 0)
    MessageBox.Show("Поле пусто", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
private void зелёныйНаТёмномToolStripMenuItem_Click(object sender, EventArgs e)
{
this.Opacity = 0;
стандартToolStripMenuItem.BackColor = SystemColors.Control;
зелёныйНаТёмномToolStripMenuItem.BackColor = Color.DodgerBlue;
белыйToolStripMenuItem.BackColor = SystemColors.Control;
жёлтыйНаЧёрномToolStripMenuItem.BackColor = SystemColors.Control;
оранжевыйНаЧерномToolStripMenuItem.BackColor = SystemColors.Control;
красныйНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
голубойНаТёмномToolStripMenuItem.BackColor = SystemColors.Control;
richTextBox1.BackColor = Color.FromArgb(43, 43, 43);
richTextBox1.ForeColor = Color.Lime;
label1.ForeColor = Color.Lime;
label2.ForeColor = Color.Lime;
label3.ForeColor = Color.Lime;
label4.ForeColor = Color.Lime;
button1.ForeColor = Color.Lime;
button4.ForeColor = Color.Lime;
button6.ForeColor = Color.Lime;
button5.ForeColor = Color.Lime;
}
private void Form1_MouseDown_1(object sender, MouseEventArgs e)
{
base.Capture = false;
Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
this.WndProc(ref m);
}
bool press = false; Point n = new Point(0, 0);
private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
{
press = true; n = new Point(e.X, e.Y);
}
private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
{
if (press)
{
    Point P = this.PointToScreen(new Point(e.X, e.Y));
    this.Location = new Point(P.X - n.X, P.Y - n.Y);
}
}
private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
{
press = false;
}
WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
private void energyToolStripMenuItem_Click(object sender, EventArgs e)
{
wmPlayer.controls.stop();
wmPlayer.URL = @"http://live.borneo.ru:8888/128";
wmPlayer.controls.play();
}
private void выключитьToolStripMenuItem_Click(object sender, EventArgs e)
{
wmPlayer.controls.stop();
}
private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
{
}
private void radioRecordToolStripMenuItem_Click(object sender, EventArgs e)
{
wmPlayer.controls.stop();
wmPlayer.URL = @"http://188.242.142.150:8010/edr256.mp3";
wmPlayer.controls.play();
}
private void удалитьДубликатыToolStripMenuItem_Click(object sender, EventArgs e)
{
if (richTextBox1.SelectionLength == 0)
    MessageBox.Show("Выделите текст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
}
private void перевестиВСтрочныеБуквыToolStripMenuItem_Click(object sender, EventArgs e)
{
if (richTextBox1.SelectionLength == 0)
    MessageBox.Show("Выделите текст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
richTextBox1.Text = richTextBox1.SelectedText.ToLower();
}
private void шифровкаТекстаToolStripMenuItem_Click(object sender, EventArgs e)
{
шифр a = new шифр();
a.ShowDialog();
}
private void richTextBox1_TextChanged(object sender, EventArgs e)
{
richTextBox1.Multiline = true;
label2.Text = richTextBox1.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Length.ToString();
if (richTextBox1.TextLength < 1000)
{
    label4.Text = richTextBox1.Text.Length.ToString() + (" Байт");
}
if (richTextBox1.TextLength >= 1000)
{
    label4.Text = richTextBox1.TextLength / 1000 + (" Кбайт".Replace(" Байт", ""));
}
if (richTextBox1.TextLength >= 1000000)
{
    label4.Text = richTextBox1.TextLength / 1000000 + (" Мбайт".Replace(" Кбайт", ""));
}
if (richTextBox1.TextLength >= 1000000000)
{
    label4.Text = richTextBox1.TextLength / 1000000000 + (" Гбайт".Replace(" Мбайт", ""));
}
GC.GetTotalMemory(false);GC.Collect(4, GCCollectionMode.Forced);GC.WaitForPendingFinalizers();
}

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}