namespace DesktopAppGimnasio.Models
{
    public interface ITipoCuotaRepository
    {
        void Edit(TipoCuotaModel tipoCuotaModel);
        IEnumerable<TipoCuotaModel> GetAll();
        IEnumerable<float> GetAllAmounts();
    }
}
