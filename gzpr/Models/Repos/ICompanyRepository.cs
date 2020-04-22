using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gzpr.Models.Repos
{
    interface ICompanyRepository
    {
        List<CompanyModel> Get();
        object GetById(int id);
        void Create(CompanyModel model);
        void Update(CompanyModel model);
        void Delete(int id);
    }
}
