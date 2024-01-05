namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            //função Where para filtrar os elementos da lista original, mantendo apenas aqueles que são maiores que zero
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            // Ele utiliza a função Contains para verificar se o número passado como argumento está presente na lista. 
            var contem = lista.Contains(numero);
            // Retorna true se o número estiver na lista, e false caso contrário
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            //Usa a função Select para aplicar a multiplicação a cada elemento da lista.
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            //Retorna uma nova lista onde cada elemento é o resultado da multiplicação
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
