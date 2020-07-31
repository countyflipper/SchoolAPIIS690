using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Entities.RequestFeatures;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class SectionEnrollManageRepository : RepositoryBase<SectionEnrollManage>, ISectionEnrollManage
    {
        public SectionEnrollManageRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<SectionEnrollManage>> GetSectionEnrollManageAsync(SectionEnrollmentManageParameters ecoursesParameters, bool trackChanges)
        {
            var employees = await FindAll(trackChanges)
              .ToListAsync();

            return PagedList<SectionEnrollManage>
              .ToPagedList(employees, ecoursesParameters.PageNumber, ecoursesParameters.PageSize);
        }

        public IEnumerable<SectionEnrollManage> GetAllSectionEnrollManage(bool trackChanges) =>
      FindAll(trackChanges)
      .OrderBy(c => c.Id)
      .ToList();


        public SectionEnrollManage GetASectionEnrollManage(Guid Id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(Id), trackChanges)
            .SingleOrDefault();

        public void CreateSectionEnrollManage(SectionEnrollManage coursemanage) => Create(coursemanage);

        public IEnumerable<SectionEnrollManage> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToList();

        public void DeleteSectionEnrollManage(SectionEnrollManage coursemanage)
        {
            Delete(coursemanage);
        }

    }
}