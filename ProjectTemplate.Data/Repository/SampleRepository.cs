using ProjectTemplate.Core.DomainModel;
using ProjectTemplate.Core.Interface.Repository;
using ProjectTemplate.Data.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Interface;

namespace ProjectTemplate.Data.Repository
{
    public class SampleRepository : GenericRepository<Sample>, ISampleRepository
    {
        public SampleRepository(IDataContext context) : base(context)
        {
        }
    }
}
