using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gzpr.Models.Repos
{
    interface IFieldRepository
    {
        List<FieldModel> Get();
        object GetById(int id);
        void Create(FieldModel model);
        void Update(FieldModel model);
        void Delete(int id);
    }
}
