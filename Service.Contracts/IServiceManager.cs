﻿namespace Service.Contracts
{
    public interface IServiceManager
    {
        ICompanyService Company { get; }

        IEmployeeService Employee { get; }
    }
}
