using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio.Models
{
    public interface ISocioRepository
    {
        void Add(SocioModel socioModel);
        void Edit(SocioModel socioModel);
        void Delete(int codigoSocio);
        IEnumerable<SocioModel> GetAll();
        IEnumerable<SocioModel> GetByValue(string value);
    }
}
