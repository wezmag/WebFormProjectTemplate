using ProjectTemplate.Core.DomainModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Core.DomainModel
{
    public class Sample : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
