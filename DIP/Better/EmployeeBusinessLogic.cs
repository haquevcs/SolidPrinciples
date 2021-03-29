
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b = SolidPriciple.DIP.Better;
namespace SolidPriciple.DIP.Better
{
    /// <summary>
    /// EmployeeBusinessLogic: separately defined employee login calass
    /// </summary>
    public class EmployeeBusinessLogic
    {
        /// <summary>
        /// The employee data access
        /// </summary>
        IEmployeeDataAccess _EmployeeDataAccess;
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