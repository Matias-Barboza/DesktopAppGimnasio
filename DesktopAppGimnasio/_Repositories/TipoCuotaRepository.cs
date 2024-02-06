using DesktopAppGimnasio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio._Repositories
{
    internal class TipoCuotaRepository : BaseRepository, ITipoCuotaRepository
    {
        // Constructor
        public TipoCuotaRepository(String conecctionString) 
        {
            this.connectionString = conecctionString;
        }

        // Methods
        public void Edit(TipoCuotaModel tipoCuotaModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoCuotaModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
