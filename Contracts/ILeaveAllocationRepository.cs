using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {

        public Task LeaveAllocation(int leaveTypeID);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);

        Task<LeaveAllocation> GetEmployeeAllocation(string employeeId, int leaveTypeId);

        public Task<EditLeaveAllocationVM> GetEmployeeAllocation(int id);

        public Task<bool> UpdateEmployeeAllocation(EditLeaveAllocationVM model);

    }
}
