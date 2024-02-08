using Application.IGenericRepository.Imp;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository.Imp
{
    public class EquipmentRepositoryImp : GenericRepositoryImp<Equipment>
    {
        public EquipmentRepositoryImp(AppDBContext context) : base(context)
        {
        }
    }
}
