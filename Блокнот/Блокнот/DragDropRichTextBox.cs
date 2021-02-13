using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Блокнот
{
    class DragDropRichTextBox1 : RichTextBox
    {
        public DragDropRichTextBox1()
        {
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(DragDropRichTextBox_DragDrop);
        }

           private void DragDropRichTextBox_DragDrop(object sender, DragEventArgs e)
           {
             if(e.Data.GetDataPresent(DataFormats.FileDrop))
             { 
                  string[] filenames = e.Data.GetData(DataFormats.FileDrop) as string[];

                if (filenames != null)
                {
                    foreach (string name in filenames)
                    {
                        try
                        {
                            this.AppendText(File.ReadAllText(name) + "\n");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }   
             }
           }


        
    }
}
