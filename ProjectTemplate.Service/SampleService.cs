using ProjectTemplate.Core.DomainModel;
using ProjectTemplate.Core.Interface.Service;
using ProjectTemplate.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Interface;
using ProjectTemplate.Core.Interface.Repository.Common;

namespace ProjectTemplate.Service
{
    public class SampleService : EntityService<Sample>, ISampleService
    {
        public SampleService(IUnitOfWork unitOfWork, IGenericRepository<Sample> repository) : base(unitOfWork, repository)
        {
        }
    }
}
