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

        public override bool Equals(object obj)
        {
            return obj is ServiceMets mets &&
                   Id == mets.Id &&
                   EqualityComparer<Service>.Default.Equals(Service, mets.Service) &&
                   EqualityComparer<Met>.Default.Equals(Met, mets.Met);
        }

        public override int GetHashCode()
        {
            int hashCode = 2030462829;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Service>.Default.GetHashCode(Service);
            hashCode = hashCode * -1521134295 + EqualityComparer<Met>.Default.GetHashCode(Met);
            return hashCode;
        }
    }
}
