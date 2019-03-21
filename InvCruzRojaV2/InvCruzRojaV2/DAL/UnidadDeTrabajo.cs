using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAL
{
    public class UnidadDeTrabajo<T> : IDisposable where T : class
    {
        private readonly CruzRojaInventarios_V2Entities context;
        public IDALGenerico<T> genericDAL;


        public UnidadDeTrabajo(CruzRojaInventarios_V2Entities _context)
        {
            context = _context;
            genericDAL = new DALGenericoImpl<T>(context);

        }

        public void Complete()
        {
            context.SaveChanges();
        }


        public void Dispose()
        {
            context.Dispose();
        }
    }
}
