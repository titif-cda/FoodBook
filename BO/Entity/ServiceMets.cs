using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class ServiceMets
    {
        public int? Id  { get; set; }

        public Service Service { get; set; }

        public Met Met{ get; set; }

        public ServiceMets()
        {
        }

        public ServiceMets(int? id, Service service, Met met)
        {
            Id = id;
            this.Service = service;
            this.Met = met;
        }
    }
}
