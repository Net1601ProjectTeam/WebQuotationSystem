using Application.IGenericRepository.Imp;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository.Imp
{
    public class StaffRepositoryImp : GenericRepositoryImp<Staff>
    {
        public StaffRepositoryImp(AppDBContext context) : base(context)
        {
        }
    }
}
