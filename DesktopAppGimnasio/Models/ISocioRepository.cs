namespace DesktopAppGimnasio.Models
{
    public interface ISocioRepository
    {
        void Add(SocioModel socioModel);
        void Edit(SocioModel socioModel);
        void Delete(int codigoSocio);
        bool IsActive(int codigoSocio);
        void ReactivateSocio(int codigoSocio);
        IEnumerable<SocioModel> GetAll();
        IEnumerable<SocioModel> GetByValue(string value);
    }
}
