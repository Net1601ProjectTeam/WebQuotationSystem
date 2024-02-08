using Application.IGenericRepository.Imp;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository.Imp
{
    public class MaterialRepositoryImp : GenericRepositoryImp<Material>
    {
        public MaterialRepositoryImp(AppDBContext context) : base(context)
        {
        }
    }
}
