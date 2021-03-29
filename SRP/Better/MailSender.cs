using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.SRP.Better
{
    /// <summary>
    /// MailSender: Single responsibility assigined to handle email activity only
    /// </summary>
    public class MailSender
    {
        /// <summary>
        /// Gets or sets the e mail from.
        /// </summary>
        /// <value>
        /// The e mail from.
        /// </value>
        public string EMailFrom { get; set; }
        /// <summary>
        /// Gets or sets the e mail to.
        /// </summary>
        /// <value>
        /// The e mail to.
        /// </value>
        public string EMailTo { get; set; }
        /// <summary>
        /// Gets or sets the e mail subject.
        /// </summary>
        /// <value>
        /// The e mail subject.
        /// </value>
        public string EMailSubject { get; set; }
        /// <summary>
        /// Gets or sets the e mail body.
        /// </summary>
        /// <value>
        /// The e mail body.
        /// </value>
        public string EMailBody { get; set; }
        /// <summary>
        /// Sends the email.
        /// </summary>
        public void SendEmail()
        {
            // Here we need to write the Code for sending the mail
        }
    }
}