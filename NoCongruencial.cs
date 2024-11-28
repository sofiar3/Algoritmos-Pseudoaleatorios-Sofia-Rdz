namespace AlgoritmoMonteCarlo
{
    public class NoCongruencial
    {
        private int semilla;

        public NoCongruencial(int semilla)
        {
            this.semilla = semilla;
        }

        public List<int> GenerarNumeros(int cantidad, int n)
        {
            List<int> numeros = new();
            int x = semilla;

            for (int i = 0; i < cantidad; i++)
            {
                long cuadrado = (long)x * x;
                string cuadradoStr = cuadrado.ToString();

                while (cuadradoStr.Length < 2 * n)
                {
                    cuadradoStr = "0" + cuadradoStr;
                }

                int inicio = (cuadradoStr.Length - n) / 2;
                string digitosCentrales = cuadradoStr.Substring(inicio, n);

                x = int.Parse(digitosCentrales);
                numeros.Add(x);
            }

            return numeros;
        }
    }
}
