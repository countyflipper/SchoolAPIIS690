using Entities.Models;
using Entities.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ISectionEnrollManage
    {
        IEnumerable<SectionEnrollManage> GetAllSectionEnrollManage(bool trackChanges);
       // SectionEnrollManage GetSectionEnrollManage(Guid SectionEnrollManageectionID, Guid id, bool trackChanges);

        SectionEnrollManage GetASectionEnrollManage(Guid id, bool trackChanges);


        Task<PagedList<SectionEnrollManage>> GetSectionEnrollManageAsync(SectionEnrollmentManageParameters para, bool trackChanges);
        //Task<SectionEnrollManage> GetSectionEnrollManageAsync(Guid companyId, bool trackChanges);

        void CreateSectionEnrollManage(SectionEnrollManage SectionEnrollManage);

        IEnumerable<SectionEnrollManage> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteSectionEnrollManage(SectionEnrollManage organization);
    }
}

