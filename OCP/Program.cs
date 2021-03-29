using SolidPriciple.OCP.Better;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using notBetter = SolidPriciple.OCP.Not_So_Good;
namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defination: The Open-Closed Principle states that “software entities such as modules, 
            // classes, functions, etc. should be open for extension, but closed for modification“.

            //Example without using the Open-Closed Principle
            // So far look so good but still there is problem in future if you want to have one more invoice type
            //when new features going to add in existing code, it mean violating OCP priciple

            // The first thing is Open for extension and the second thing is Closed for modification - respect OCP
            notBetter.Invoice nBInvoice = new notBetter.Invoice();
            var finalInvoice = nBInvoice.GetInvoiceDiscount(1000, notBetter.InvoiceType.FinalInvoice);
            Console.WriteLine(finalInvoice);
            var proposedInvoice = nBInvoice.GetInvoiceDiscount(1000, notBetter.InvoiceType.ProposedInvoice);
            Console.WriteLine(proposedInvoice);




            //The following example follows the Open-Closed Principle
            //Modify the Main method of Program class as shown below to test the application.
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();

            //Final Invoice
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(FInvoiceAmount);
            // Proposed Invoice
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(PInvoiceAmount);
            //Recurring Invoice
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(RInvoiceAmount);


            Console.ReadKey();
        }

    }
}
