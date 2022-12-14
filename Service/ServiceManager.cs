using AutoMapper;
using Contracts;
using Entities.ConfigurationModels;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IEmployeeService> _employeeService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger, 
            IMapper mapper, IDataShaper<EmployeeDto> dataShaper,
            UserManager<User> userManeger,
            IOptions<JwtConfiguration> configuration)
        {
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repository, logger, mapper));
            _employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repository, logger, mapper, dataShaper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManeger, configuration));
        }

        public ICompanyService CompanyService => _companyService.Value;
        public IEmployeeService EmployeeService => _employeeService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
