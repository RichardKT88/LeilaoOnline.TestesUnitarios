namespace LeilaoOnline.Core
{
    public class OfertaSuperiorMaisProxima : IModalidadeAvaliacao
    {
        public OfertaSuperiorMaisProxima(double valorDestino)
        {
            ValorDestino = valorDestino;
        }

        public double ValorDestino { get; }

        public Lance Avalia(Leilao leilao)
        {
            return leilao.Lances
                .DefaultIfEmpty(new Lance(null!, 0))
                  .Where(l => l.Valor > ValorDestino)
                  .OrderBy(l => l.Valor)
                  .FirstOrDefault()!;
        }
    }
}
