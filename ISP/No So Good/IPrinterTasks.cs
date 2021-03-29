using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.ISP.No_So_Good
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
        /// <summary>
        /// Faxes the specified fax content.
        /// </summary>
        /// <param name="FaxContent">Content of the fax.</param>
        void Fax(string FaxContent);
        /// <summary>
        /// Prints the duplex.
        /// </summary>
        /// <param name="PrintDuplexContent">Content of the print duplex.</param>
        void PrintDuplex(string PrintDuplexContent);
    }
}
