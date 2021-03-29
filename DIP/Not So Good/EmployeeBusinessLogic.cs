using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPriciple.DIP.Not_So_Good
{
    /// <summary>
    /// EmployeeBusinessLogic
    /// </summary>
    public class EmployeeBusinessLogic
    {
        /// <summary>
        /// The employee data access
        /// </summary>
        EmployeeDataAccess _EmployeeDataAccess;
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBusinessLogic"/> class.
        /// </summary>
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        /// <summary>
        /// Gets the employee details.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}