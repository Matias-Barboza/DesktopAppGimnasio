namespace DesktopAppGimnasio.Models
{
    public interface ICuotaRepository
    {
        void Add(CuotaModel cuotaModel);
        void Edit(CuotaModel cuotaModel);
        void Delete(int codigoCuota);
        void DeleteAllCuotasOfSocio(int codigoSocio);
        IEnumerable<CuotaModel> GetAll();
        IEnumerable<CuotaModel> GetByValue(string value);
        IEnumerable<CuotaModel> GetAllDebts();
        IEnumerable<CuotaModel> GetDebtsByValue(string value);
    }
}
