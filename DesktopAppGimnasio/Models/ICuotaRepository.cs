using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio.Models
{
    public interface ICuotaRepository
    {
        void Add(CuotaModel cuotaModel);
        void Edit(CuotaModel cuotaModel);
        void Delete(int codigoCuota);
        IEnumerable<CuotaModel> GetAll();
        IEnumerable<CuotaModel> GetByValue(string value);
    }
}
