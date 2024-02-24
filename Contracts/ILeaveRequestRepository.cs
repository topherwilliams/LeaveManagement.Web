using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveRequestRepository: IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequestAsync(LeaveRequestCreateVM request);

        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetailsAsync();

        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task<List<LeaveRequest>> GetAllAsync (string employeeId);

        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();


    }
}
