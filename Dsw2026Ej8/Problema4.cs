namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int contador = 0;

            // Procesar cada nota individualmente
            if (EsNotaValida(nota1))
            {
                suma += nota1!.Value;
                contador++;
            }

            if (EsNotaValida(nota2))
            {
                suma += nota2!.Value;
                contador++;
            }

            if (EsNotaValida(nota3))
            {
                suma += nota3!.Value;
                contador++;
            }

            // Si no hay notas válidas, retornar 0
            if (contador == 0) return 0;

            return suma / contador;
        }

        private bool EsNotaValida(int? nota)
        {
            // La nota es válida si tiene valor y está entre 0 y 10 inclusive
            return nota.HasValue && nota.Value >= 0 && nota.Value <= 10;
        }
    }
}
