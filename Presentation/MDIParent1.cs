using PhumlaKamnandiHotel.Business;
using PhumlaKamnandiHotel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiHotel.Presentation
{

    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        //private Create c;
        //private opti opt;
        private DatabaseManager database;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rudolf\\Documents\\PhumlaKamnandiHotel\\KhumlaDatabase.mdf;Integrated Security=True";
        




        public MDIParent1()
        {
            InitializeComponent();
           // c=new Create();
            //opt = new opti();
            database = new DatabaseManager();
            this.IsMdiContainer = true;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        //login button


        static bool AuthenticateUser(string connectionString, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM [dbo].[Login] WHERE [username] = @username AND [password] = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            }
            private void button1_Click(object sender, EventArgs e)
        {
           // string connectionString1 = "your_connection_string_here"; // Update with your connection string
            string username = textUsername.Text; // Replace with the actual username to check
            string password = textPassword.Text; // Replace with the actual password to check
            validate v = new validate();
            if (v.IsValidName(username)==true && v.IsValidID(password)==true)
            {
                bool isAuthenticated = AuthenticateUser(connectionString, username, password);
                // opti opt = new opti();
                if (isAuthenticated==true)
                {
                    MessageBox.Show("User authenticated successfully.");
                    //this.Hide()



                    opti opt = new opti();
                    opt.StartPosition = FormStartPosition.Manual;
                    opt.Location = this.Location;
                  
                    opt.Show();
                    // Visible = false;
                    //openOpt();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("please enter correct details");
            }
           
            
        }

        //creating an account

        private void create_Click(object sender, EventArgs e)
        {

           // opti opt = new opti()
            Create c = new Create();
            c.StartPosition = FormStartPosition.Manual;
            c.Location = this.Location;

           
            c.Show();
        }

  
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create c = new Create();
            c.StartPosition = FormStartPosition.Manual;
            c.Location = this.Location;


            c.Show();

        }
    }
}
