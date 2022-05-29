using CadastroDeSeries.Interfaces;
namespace CadastroDeSeries.Classes
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Series entidade)
        {
            throw new NotImplementedException();
        }

        public List<Series> Lista()
        {
            throw new NotImplementedException();
        }

        public int Proximo()
        {
            throw new NotImplementedException();
        }

        public Series RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}