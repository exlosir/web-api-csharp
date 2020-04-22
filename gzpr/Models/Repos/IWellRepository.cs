using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gzpr.Helpers;

namespace gzpr.Models.Repos
{
    interface IWellRepository
    {
        List<WellModel> Get();
        object GetById(int id);
        void Create(WellRequest model);
        void Update(WellRequest model);
        void Delete(int id);
    }
}
