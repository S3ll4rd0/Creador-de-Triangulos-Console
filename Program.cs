namespace Triangulo
{
    public class Triangulo
    {
        public static void Main(String [] args)
        {
            double ladoTriangulo = 0;
            double alturaTriangulo = 0; 
            double baseTriangulo = 0;

            Console.WriteLine("Introduzca el lado del triángulo.");
            ladoTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la altura del triángulo.");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la base del triángulo.");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());

            if (ladoTriangulo == alturaTriangulo)
            {
                if (ladoTriangulo == baseTriangulo)
                {
                    Console.WriteLine("El triángulo es equilatero");
                }
            }
            if(ladoTriangulo > baseTriangulo)
            {
                if(ladoTriangulo > alturaTriangulo)
                {
                    Console.WriteLine("El lado mayor es el Lado del triángulo: " + ladoTriangulo);
                }
                else
                {
                    Console.WriteLine("El lado mayor es la altura del triángulo: " + alturaTriangulo);
                }
            }
            else
            {
                if (baseTriangulo > alturaTriangulo)
                {
                    Console.WriteLine("El lado mayor es la base del triángulo: " + baseTriangulo);
                }
                else
                {
                    Console.WriteLine("El lado mayor es la altura del triángulo: " + alturaTriangulo);
                }
            }

            Console.WriteLine("El area del triángulo es: " + ((baseTriangulo * alturaTriangulo) / 2));
        }
    }
}