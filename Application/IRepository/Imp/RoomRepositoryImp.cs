using Application.IGenericRepository.Imp;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository.Imp
{
    public class RoomRepositoryImp : GenericRepositoryImp<Room>
    {
        public RoomRepositoryImp(AppDBContext context) : base(context)
        {
        }
    }
}
