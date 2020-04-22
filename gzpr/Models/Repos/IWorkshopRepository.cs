using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gzpr.Models.Repos
{
    interface IWorkshopRepository
    {
        List<WorkshopModel> Get();
        object GetById(int id);
        void Create(WorkshopModel model);
        void Update(WorkshopModel model);
        void Delete(int id);
    }
}
