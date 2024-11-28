namespace AlgoritmoMonteCarlo
{
    public class Congruencial
    {
        private int Xn, a, c, m;

        public Congruencial(int semilla, int a, int c, int m)
        {
            Xn = semilla;
            this.a = a;
            this.c = c;
            this.m = m;
        }

        public List<int> GenerarNumeros(int cantidad)
        {
            List<int> numeros = new();

            for (int i = 0; i < cantidad; i++)
            {
                Xn = (a * Xn + c) % m;
                numeros.Add(Xn);  
            }

            return numeros;
        }
    }
}
