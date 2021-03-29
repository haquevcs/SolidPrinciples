using SolidPriciple.SRP.NotGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using better= SolidPriciple.SRP.Better;
namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________Not so good approch__________________");

            // Not so good approch
            Invoice invoice = new Invoice();
            invoice.AddInvoice();
            Console.WriteLine("______________Better approch__________________");
            // Better approch
            better.Invoice bInvoice = new better.Invoice();
            bInvoice.AddInvoice();
            bInvoice.DeleteInvoice();



        }
    }
}
