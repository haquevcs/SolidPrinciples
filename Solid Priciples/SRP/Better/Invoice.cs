using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.SRP.Better
{
    /// <summary>
    /// A class should have only one reason to change
    /// Invoice: All relevent activity handle here by using appripriate class
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
        /// The file logger
        /// </summary>
        private ILogger fileLogger;
        /// <summary>
        /// The email sender
        /// </summary>
        private MailSender emailSender;
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice"/> class.
        /// </summary>
        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }
        /// <summary>
        /// Adds the invoice.
        /// </summary>
        public void AddInvoice()
        {
            try
            {

                // Logged
                fileLogger.Info("Invoice Added.");
                /*
                                // Here we need to write the Code for adding invoice
                                // Once the Invoice has been added, then send the  mail
                                emailSender.EMailFrom = "emailfrom@mailinator.com";
                                emailSender.EMailTo = "emailto@mailinator.com";
                                emailSender.EMailSubject = "Single Responsibility Princile";
                                emailSender.EMailBody = "A class should have only one reason to change";
                                emailSender.SendEmail();

                                */
                fileLogger.Info("Email sent.");
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Generating Invoice", ex);
            }
        }
        /// <summary>
        /// Deletes the invoice.
        /// </summary>
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
}