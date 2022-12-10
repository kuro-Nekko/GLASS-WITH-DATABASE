using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GLASS_WITH_DATABASE
{
    public partial class uploadFile : Form
    {
        OdbcConnection connection = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};Server=localhost;Port=3306;DATABASE=glassdatabase;uId=root;pwd=root;OPTION=3;");
        OdbcCommand cmd;
        OdbcDataReader dr;
        public uploadFile()
        {
            InitializeComponent();
        }
        public void UploadFile(string file)
        {
            connection.Open();
            FileStream fs = File.OpenRead(file);
            byte[] contents = new byte[fs.Length];
            fs.Read(contents, 0, (int)fs.Length);
            fs.Close();
            
            using (cmd = new OdbcCommand("INSERT INTO upload_file(file_ID, file_upload) VALUES (@id, @files)", connection))
            {
                OdbcParameter blobname = new OdbcParameter("@id", OdbcType.Int);
                OdbcParameter blobFile = new OdbcParameter("@files", OdbcType.VarBinary, contents.Length);
                blobname.Value = txtFilePath.Text;
                blobFile.Value = contents;
                cmd.Parameters.Add(blobname);

                //cmd.Parameters.AddWithValue("@id", OdbcType.Int).Value = 1;
                cmd.Parameters.AddWithValue("@files", blobFile).Value = contents;  
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("File Uploaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "Text Documents(*.pdf) |*.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to upload this file?", "Upload File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string filename = dlg.FileName;
                        UploadFile(filename);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
