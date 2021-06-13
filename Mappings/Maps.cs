using AutoMapper;
using leave_management.Data;
using leave_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, DetailsLeaveTypeModel>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationModel>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryModel>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
        }
    }
}
