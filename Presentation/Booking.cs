using PhumlaKamnandiHotel.Business;
using PhumlaKamnandiHotel.Database;
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
using static System.Net.Mime.MediaTypeNames;
using System.Net.Mime;

namespace PhumlaKamnandiHotel.Presentation
{
    public partial class Booking : Form
    {
        DatabaseManager d;
        public Booking()
        {
            InitializeComponent();
            d= new DatabaseManager();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            BookingC b = new BookingC(0,0,Reservation.checkin,Reservation.checkout,Reservation.roomn);
            validate v = new validate();
            string name = fname.Text;
            string email = emailB.Text;
            string id = idT.Text;
            long idd = Convert.ToInt64(id);
            int iddd = (int)idd;
            string number = phoneB.Text;
            string address = streetB.Text+","+cityB.Text+","+codeB.Text;


            if (v.IsValidID(id) == true && v.IsValidName(name) && IsValidEmail(email))
            {

                sendEmail(email);
                d.AddGuest(id, name, email, number, address);
                MessageBox.Show("Guest has been added");
                d.AddBooking(id, id, Reservation.checkin, Reservation.checkout, 1, b.CalculateDeposit(Reservation.days, Reservation.checkin), b.totalPrice(Reservation.days, Reservation.checkin), b.totalPrice(Reservation.days, Reservation.checkin) - b.CalculateDeposit(Reservation.days, Reservation.checkin), Reservation.roomn);
                MessageBox.Show("Booking has been added>>>>>");
                CreditCard c = new CreditCard();
                c.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Details entered are invalid");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            opti o = new opti();
            o.ShowDialog();
            //this.Close();
        }
        public void sendEmail(string email)
        {
            // Create the email
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("thanyanirudolf21@gmail.com"); // Sender's email
            try
            {
                mail.To.Add(email);  // Recipient's email
            }
            catch (Exception et)
            {
                MessageBox.Show("Incorrect email address");
                return;  // Exit method if email is incorrect
            }

            mail.Subject = "Thank you for booking with us";

            // Create the email body with HTML, including the banner image (cid:bannerImage)
            string htmlBody = "<html><body>" +
                              "<h1>Thank you for booking with us!</h1>" +
                              "<img src='cid:bannerImage' alt='Banner' width='600' height='150'/>" +
                              "<p>Here are your booking details:</p>" +
                              "<p><b>Name:</b> " + fname.Text + "</p>" +
                              "<p><b>Booking Reference:</b> " + idT.Text + "</p>" +
                              "<p>======================================</p>" +
                              "<p><b>Check-in:</b> " + Reservation.checkin.ToString() + "</p>" +
                              "<p><b>Check-out:</b> " + Reservation.checkout.ToString() + "</p>" +
                              "<p><b>Room number:</b> " + Reservation.days + "</p>" +
                              "</body></html>";

            // Create the AlternateView with HTML content
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);

            // Specify the path to the banner image
            string bannerImagePath = @"C:\Users\Rudolf\Downloads\thank you\1.png";  // Update this with the correct path to your banner
            //"C:\Users\Rudolf\Downloads\thank you\1.png"
            // Create the LinkedResource for the banner image
            LinkedResource bannerImage = new LinkedResource(bannerImagePath, MediaTypeNames.Image.Jpeg);
            bannerImage.ContentId = "bannerImage";  // Match this ID with the 'cid' in the email body

            // Add the banner image to the email's LinkedResources
            htmlView.LinkedResources.Add(bannerImage);

            // Attach the HTML view to the email
            mail.AlternateViews.Add(htmlView);

            // Set up the Gmail SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("thanyanirudolf21@gmail.com", "andk dkee ahby mgzi");
            smtpClient.EnableSsl = true;

            try
            {
                // Send the email
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }

    }
}
