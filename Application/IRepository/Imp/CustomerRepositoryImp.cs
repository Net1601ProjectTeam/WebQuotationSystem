using Application.IGenericRepository.Imp;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository.Imp
{
    public class CustomerRepositoryImp : GenericRepositoryImp<Customer>
    {
        public CustomerRepositoryImp(AppDBContext context) : base(context)
        {
        }
    }
}
