using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.SRP.NotGood
{
    /// <summary>
    /// Invoice class
    /// referances taken: https://dotnettutorials.net/lesson/single-responsibility-principle/ 
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Gets or sets the inv amount.
        /// </summary>
        /// <value>
        /// The inv amount.
        /// </value>
        public long InvAmount { get; set; }
        /// <summary>
        /// Gets or sets the inv date.
        /// </summary>
        /// <value>
        /// The inv date.
        /// </value>
        public DateTime InvDate { get; set; }

        /// <summary>
        /// Adds the invoice.
        /// </summary>
        public void AddInvoice()
        {
            try
            {
                Console.WriteLine("Invoice Added.");

                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                //Email send - just written for an idea of responsibility defied in invoice class
                /*
                 * 
                 MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
                */

                Console.WriteLine("Email Sent.");
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Deletes the invoice.
        /// </summary>
        public void DeleteInvoice()
        {
            try
            {
                Console.WriteLine("Invoice deleted.");

                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
                Console.WriteLine("Error: " + ex.Message);

            }
        }

        /// <summary>
        /// Sends the invoice email..
        /// </summary>
        /// <param name="mailMessage">The mail message.</param>
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}