using Application.IGenericRepository.Imp;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository.Imp
{
    public class ProjectRepositoryImp : GenericRepositoryImp<Project>
    {
        public ProjectRepositoryImp(AppDBContext context) : base(context)
        {
        }
    }
}
