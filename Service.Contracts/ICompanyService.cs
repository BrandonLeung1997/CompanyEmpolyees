﻿using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
        CompanyDto GetCompany(Guid companyId, bool trackChnages);
        CompanyDto CreateCompany(CompanyForCreationDto company);
        IEnumerable<CompanyDto> GetByIds(IEnumerable<Guid> ids, bool trackChnages);
        (IEnumerable<CompanyDto> companies, string ids) CreateCompanyCollection
            (IEnumerable<CompanyForCreationDto> companyCollecction);
    }
}
