using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betaMartApplication
{
    public partial class FormBetaMart : Form
    {
        public FormBetaMart()
        {
            InitializeComponent();

            // Hide ID Column
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormBetaMart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'betaMartDatabaseDataSet.barangBetaMart' table. You can move, or remove it, as needed.
            this.barangBetaMartTableAdapter.Fill(this.betaMartDatabaseDataSet.barangBetaMart);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FormBetaMart_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Do You Want To Exit The Application?";
            string caption = "Exite Application : Anila Dwi Lestari";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            DialogResult result;

            result = MessageBox.Show(this, msg, caption, buttons, ico);

            if (result == DialogResult.Yes)
            {
                // Close The Form 
                MessageBox.Show("Goodbye, it was nice to meet you.", "Anila Dwi Lestari",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.barangBetaMartBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.barangBetaMartBindingSource.MoveNext();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            this.barangBetaMartBindingSource.AddNew();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Do You Want To Save The Selected Record?";
                string caption = "Save : Anila Dwi Lestari";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    // Save
                    this.barangBetaMartBindingSource.EndEdit();
                    this.barangBetaMartTableAdapter.Update(this.betaMartDatabaseDataSet.barangBetaMart);

                    // Refresh Data
                    this.barangBetaMartTableAdapter.Fill(this.betaMartDatabaseDataSet.barangBetaMart);

                    MessageBox.Show("The Record Has Been Saved Successfully.", "Save Data : Anila Dwi Lestari",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Harus Menggunakan Angka! :" + ex.Message.ToString(), "Tipe Data Anda Salah, Coba Lagi Ya!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Dou You Want To Permanently Delete The Selected Records?";
                string caption = "Delete Data : Anila Dwi Lestari";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    // Delete
                    this.barangBetaMartBindingSource.RemoveCurrent();

                    // Save The Change 
                    this.barangBetaMartBindingSource.EndEdit();
                    this.barangBetaMartTableAdapter.Update(this.betaMartDatabaseDataSet.barangBetaMart);

                    // Refresh Data
                    this.barangBetaMartTableAdapter.Fill(this.betaMartDatabaseDataSet.barangBetaMart);

                    MessageBox.Show("The Record Has Been Deleted.", "Delete Data : Anila Dwi Lestari",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Failed : " + ex.Message.ToString(), "Delete Data : Anila Dwi Lestari",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            buttonAddNew.PerformClick();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            buttonDelete.PerformClick();
        }

        private void toolStripButtonUpdateItem_Click(object sender, EventArgs e)
        {
            buttonSave.PerformClick();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            barangBetaMartBindingSource.Filter = null;
            this.barangBetaMartTableAdapter.Fill(this.betaMartDatabaseDataSet.barangBetaMart);

            if (KeywordTextBox.CanSelect)
            {
                KeywordTextBox.Clear();
                KeywordTextBox.Select();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchAccessDatabase();
        }

        private void searchAccessDatabase()
        {
            if (string.IsNullOrEmpty(KeywordTextBox.Text.Trim()))
            {
                refreshData();
                return;
            }

            string strkeyword = KeywordTextBox.Text.Trim().ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("(Convert(ID_Barang, 'System.String') LIKE '" + "{0}" + "')", strkeyword);
            sb.AppendFormat("OR (Nama_Barang LIKE '*" + "{0}" + "*')", strkeyword);
            sb.AppendFormat("OR (Kategori LIKE '*" + "{0}" + "*')", strkeyword);
            sb.AppendFormat("OR (Brand LIKE '" + "{0}" + "')", strkeyword);
            sb.AppendFormat("OR (Harga LIKE '*" + "{0}" + "*')", strkeyword);
            sb.AppendFormat("OR (Stok LIKE '%" + "{0}" + "%')", strkeyword);

            String strFilter = sb.ToString();
            barangBetaMartBindingSource.Filter = strFilter;

            if (barangBetaMartBindingSource.Count != 0)
            {
                dataGridView1.DataSource = barangBetaMartBindingSource;
            }
            else
            {
                MessageBox.Show("Sorry, No Records Found.", "Search Result : Anila Dwi Lestari",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshData();
                return;
            }
        }

        private void clearImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.photoPictureBox.Image = null;
            }
            catch
            {

            }
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                string myPictures = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                ofd.Filter = "Jpg, Jpeg Images|*.jpg;*.jpeg|PNG Images|*.png|BMP Images|*.bmp|" + "All files (*.*)|*.*";
                ofd.FileName = "Image file name";
                ofd.Title = "Choose an image...";
                ofd.AddExtension = true;
                ofd.FilterIndex = 0;
                ofd.Multiselect = false;
                ofd.ValidateNames = true;
                ofd.InitialDirectory = myPictures;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.photoPictureBox.Image = Image.FromFile(ofd.FileName);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error : Something Went Wrong,", "Choose Image : Anila Dwi Lestari",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Do You Want To Update The Selected Record?";
                string caption = "Update : Anila Dwi Lestari";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);

                if (result == DialogResult.Yes)
                {
                    // Save | Update 
                    this.barangBetaMartBindingSource.EndEdit();
                    this.barangBetaMartTableAdapter.Update(this.betaMartDatabaseDataSet.barangBetaMart);

                    // Refresh Data
                    this.barangBetaMartTableAdapter.Fill(this.betaMartDatabaseDataSet.barangBetaMart);

                    MessageBox.Show("The Record Has Been Update Successfully.", "Update Data : Anila Dwi Lestari",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Failed : " + ex.Message.ToString(), "Update Data : Anila Dwi Lestari",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocumentDataGridView_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printDocumentDataGridViewBitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(printDocumentDataGridViewBitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(printDocumentDataGridViewBitmap, 0, 0);
        }

        private void btnPrintDataGridView_Click(object sender, EventArgs e)
        {
            PrintDialog printDataGridViewPrintDialog = new PrintDialog();
            // Document
            printDataGridViewPrintDialog.Document = printDocumentDataGridView;

            printDataGridViewPrintDialog.UseEXDialog = true;

            // Dialog Result
            DialogResult printDataGridViewPrintDialogResult = printDataGridViewPrintDialog.ShowDialog();

            if (printDataGridViewPrintDialogResult == DialogResult.OK)
            {
                // Document Name
                printDocumentDataGridView.DocumentName = "Print DataGridView";

                // Print Function
                printDocumentDataGridView.Print();

                // Output Message After Printing Successfully
                MessageBox.Show("DataGridView Printing Successfully.....", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}