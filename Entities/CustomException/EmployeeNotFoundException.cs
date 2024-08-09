using Entities.Models;

namespace Entities.CustomException
{
    public sealed class EmployeeNotFoundException : NotFoundException
    {
        public EmployeeNotFoundException(Guid employeeId) : 
            base($"Employee with id: {employeeId} doesn't exist in the database.")
        {
        }
    }
}
