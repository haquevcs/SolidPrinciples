using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.OCP.Not_So_Good
{
    /// <summary>
    /// Invoice: Example without using the Open-Closed Principle
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Gets the invoice discount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="invoiceType">Type of the invoice.</param>
        /// <returns>double</returns>
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public enum InvoiceType
    {
        /// <summary>
        /// The final invoice
        /// </summary>
        FinalInvoice,
        /// <summary>
        /// The proposed invoice
        /// </summary>
        ProposedInvoice
    };
}