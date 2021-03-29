using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.OCP.Better
{
    /// <summary>
    /// Invoice : The following example follows the Open-Closed Principle
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Gets the invoice discount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns></returns>
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SolidPriciple.OCP.Better.Invoice" />
    public class FinalInvoice : Invoice
    {
        /// <summary>
        /// Gets the invoice discount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns></returns>
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SolidPriciple.OCP.Better.Invoice" />
    public class ProposedInvoice : Invoice
    {
        /// <summary>
        /// Gets the invoice discount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns></returns>
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SolidPriciple.OCP.Better.Invoice" />
    public class RecurringInvoice : Invoice
    {
        /// <summary>
        /// Gets the invoice discount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns></returns>
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}