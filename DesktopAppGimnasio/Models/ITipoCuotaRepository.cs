using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppGimnasio.Models
{
    public interface ITipoCuotaRepository
    {
        void Edit(TipoCuotaModel tipoCuotaModel);
        IEnumerable<TipoCuotaModel> GetAll();
        IEnumerable<float> GetAllAmounts();
    }
}
