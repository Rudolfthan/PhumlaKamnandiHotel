using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandiHotel.Database;
using PhumlaKamnandiHotel.Business;

namespace PhumlaKamnandiHotel.Presentation
{
    public partial class Create : Form
    {
        private opti o;
        private DatabaseManager db;
       // private MDIParent1 parent;
        public Create()
        {
            InitializeComponent();
            o= new opti();
            db = new DatabaseManager();
           // parent= new MDIParent1();
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            validate v = new validate();
            if (v.IsValidID(textID.Text) == true && v.IsValidName(textName.Text) && IsValidEmail(textEmail.Text)) { 

                // Create the email
           
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("thanyanirudolf21@gmail.com"); // Sender's email
                mail.To.Add(textEmail.Text);  // Recipient's email


                mail.Subject = "Welcome to our Hotel";
                mail.Body = "Information.\n" +

                    "username: " + textName.Text + "\n" +
                    "password:" + textID.Text;

                // Attach the file


                // Set up the Gmail SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential("thanyanirudolf21@gmail.com", "andk dkee ahby mgzi");
                smtpClient.EnableSsl = true;

                try
                {
                    // Send the email
                    smtpClient.Send(mail);
                    Console.WriteLine("Email sent successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }


                db.AddNewStaff(textName.Text, textEmail.Text, Phone.Text, textID.Text, "Receptionist");

                db.AddLogin(textName.Text, textID.Text, textName.Text, textID.Text);

                this.Close();
            }else
            {
                MessageBox.Show("invalid details entered ,please verify");
            }



            

         //  this.Close();


        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
