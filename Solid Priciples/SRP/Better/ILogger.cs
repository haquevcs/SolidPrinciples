using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.SRP.Better
{
    /// <summary>
    /// ILogger : Single responsibility assignied here to handle all relevent logged
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Informations the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        void Info(string info);
        /// <summary>
        /// Debugs the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        void Debug(string info);
        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        void Error(string message, Exception ex);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SolidPriciple.SRP.Better.ILogger" />
    public class Logger : ILogger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        public Logger()
        {
            // here we need to write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }
        /// <summary>
        /// Informations the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        public void Info(string info)
        {
            // here we need to write the Code for info information into the ErrorLog text file

            Console.WriteLine(info);
        }
        /// <summary>
        /// Debugs the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        public void Debug(string info)
        {
            Console.WriteLine(info);

            // here we need to write the Code for Debug information into the ErrorLog text file
        }
        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        public void Error(string message, Exception ex)
        {
            Console.WriteLine(message + ", Error: "+ ex.Message);

            // here we need to write the Code for Error information into the ErrorLog text file
        }
    }
}