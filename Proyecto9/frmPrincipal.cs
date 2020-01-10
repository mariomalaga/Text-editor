/*
* PRÁCTICA.............: Práctica 9.
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Editor de Textos.
* FECHA DE ENTREGA.....: 02 de Febrero de 2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto9
{
    public partial class frmPrincipal : Form
    {
        static string filename = "";
        static bool save = true;

        public frmPrincipal()
        {
            InitializeComponent();
            foreach (FontFamily f in FontFamily.Families)
            {
                string nombre = f.Name;
                cboTipoLetra.Items.Add(nombre);
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if (save == false)
            {
                DialogResult dialogResult = MessageBox.Show("Va a crear un nuevo documento sin guardar, ¿está seguro?", "Guardar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    rtbTexto.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                rtbTexto.Clear();
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivo .rtf|*.rtf";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
                {
                    rtbTexto.LoadFile(openFileDialog1.FileName);
                    filename = openFileDialog1.FileName;
                }
            }
            catch (ArgumentException a)
            {
                MessageBox.Show("Extension no válida");
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivo .rtf|*.rtf";
            string fileName = string.Empty;
            if (fileName == string.Empty)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    fileName = saveFileDialog1.FileName;
            }
            if (fileName != string.Empty)
            {
                try
                {
                    rtbTexto.SaveFile(fileName, RichTextBoxStreamType.RichText);
                    save = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                DialogResult dialogResult = MessageBox.Show("Va a cerrar el documento sin guardar, ¿está seguro?", "Guardar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                this.Close();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Paste();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (filename != string.Empty)
            {
                rtbTexto.SaveFile(filename, RichTextBoxStreamType.RichText);
                save = true;
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Archivo .rtf|*.rtf";
                string fileName = string.Empty;
                if (fileName == string.Empty)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        fileName = saveFileDialog1.FileName;
                }
                if (fileName != string.Empty)
                {
                    try
                    {
                        rtbTexto.SaveFile(fileName, RichTextBoxStreamType.RichText);
                        save = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectAll();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.ForeColor = color.Color;
            }
        }

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.SelectionBackColor = fondo.Color;
            }
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbTexto.SelectionFont;
            if (old1.Bold)
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            rtbTexto.SelectionFont = new1;
            rtbTexto.Focus();
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbTexto.SelectionFont;
            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            rtbTexto.SelectionFont = new1;

            rtbTexto.Focus();
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbTexto.SelectionFont;
            if (old1.Underline)
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            rtbTexto.SelectionFont = new1;
            rtbTexto.Focus();
        }

        private void btnAlineacionIzquierda_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnAlineacionCentro_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnAlineacionDerecha_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(rtbTexto.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.rtbTexto.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(rtbTexto.Text);
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPrint.Print();
            }
        }

        private void cboTamanoLetra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoLetra.SelectedItem == null && cboTamanoLetra.SelectedItem == null)
            {
                rtbTexto.SelectionFont = new Font("Microsoft Sans Serif", 10);
            }
            else if (cboTamanoLetra.SelectedItem == null)
            {
                rtbTexto.SelectionFont = new Font(cboTipoLetra.SelectedItem.ToString(), 10);
            }
            else if (cboTipoLetra.SelectedItem == null)
            {
                rtbTexto.SelectionFont = new Font("Microsoft Sans Serif", int.Parse(cboTamanoLetra.SelectedItem.ToString()));

            }
            else
            {
                rtbTexto.SelectionFont = new Font(cboTipoLetra.SelectedItem.ToString(), int.Parse(cboTamanoLetra.SelectedItem.ToString()));
            }
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            save = false;
        }
    }

}
