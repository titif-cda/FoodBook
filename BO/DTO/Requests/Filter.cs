using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Requests
{
    public class Filter
    {
        public int Popularite { get; set; }

        public TypeRepas typeRepas { get; set; }

        public Ingredient typeIngredient { get; set; }

        public Filter()
        {
        }
    }
}
