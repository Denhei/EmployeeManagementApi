using Contracts.Repository;
using Entities.Models;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges) => 
            FindByCondition(x => x.CompanyId.Equals(companyId), trackChanges)
            .OrderBy(x => x.Name)
            .ToList();

        public Employee GetEmployee(Guid companyId, Guid employeeId, bool trackChanges) => 
            FindByCondition(x => x.CompanyId.Equals(companyId) && x.Id.Equals(employeeId), trackChanges)
            .SingleOrDefault();

        public void CreateEmployeeForCompany(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }

        public void DeleteEmployee(Employee employee) => Delete(employee);
    }
}
