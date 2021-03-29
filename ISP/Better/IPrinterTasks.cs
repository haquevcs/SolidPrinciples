using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.ISP.Better
{
    /// <summary>
    /// IPrinterTasks
    /// </summary>
    public interface IPrinterTasks
    {
        /// <summary>
        /// Prints the specified print content.
        /// </summary>
        /// <param name="PrintContent">Content of the print.</param>
        void Print(string PrintContent);
        /// <summary>
        /// Scans the specified scan content.
        /// </summary>
        /// <param name="ScanContent">Content of the scan.</param>
        void Scan(string ScanContent);
    }
    /// <summary>
    /// IFaxTasks
    /// </summary>
    interface IFaxTasks
    {
        /// <summary>
        /// Faxes the specified content.
        /// </summary>
        /// <param name="content">The content.</param>
        void Fax(string content);
    }
    /// <summary>
    /// IPrintDuplexTasks
    /// </summary>
    interface IPrintDuplexTasks
    {
        /// <summary>
        /// Prints the duplex.
        /// </summary>
        /// <param name="content">The content.</param>
        void PrintDuplex(string content);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SolidPriciple.ISP.Better.IPrinterTasks" />
    /// <seealso cref="SolidPriciple.ISP.Better.IFaxTasks" />
    /// <seealso cref="SolidPriciple.ISP.Better.IPrintDuplexTasks" />
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks,
                                     IPrintDuplexTasks
    {
        /// <summary>
        /// Prints the specified print content.
        /// </summary>
        /// <param name="PrintContent">Content of the print.</param>
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        /// <summary>
        /// Scans the specified scan content.
        /// </summary>
        /// <param name="ScanContent">Content of the scan.</param>
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        /// <summary>
        /// Faxes the specified fax content.
        /// </summary>
        /// <param name="FaxContent">Content of the fax.</param>
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        /// <summary>
        /// Prints the duplex.
        /// </summary>
        /// <param name="PrintDuplexContent">Content of the print duplex.</param>
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <seealso cref="SolidPriciple.ISP.Better.IPrinterTasks" />
        class LiquidInkjetPrinter : IPrinterTasks
        {
            /// <summary>
            /// Prints the specified print content.
            /// </summary>
            /// <param name="PrintContent">Content of the print.</param>
            public void Print(string PrintContent)
            {
                Console.WriteLine("Print Done");
            }
            /// <summary>
            /// Scans the specified scan content.
            /// </summary>
            /// <param name="ScanContent">Content of the scan.</param>
            public void Scan(string ScanContent)
            {
                Console.WriteLine("Scan content");
            }
        }
    }
}