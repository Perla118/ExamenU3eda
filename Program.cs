namespace ExamenU3eda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lista lista = new Lista();

            lista.ImprimirLista();

            Console.WriteLine("Ingresa el nombre y la edad de la persona:");
            string Nombre=Convert.ToString(Console.ReadLine());
            int Edad= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1.-Insertar al final de la lista");
            


            Console.WriteLine("2.-Buscar en la lista");



            Console.WriteLine("3.-Ver posición de un elemento");



            Console.WriteLine("4.-Imprimir elementos de la lista");
            Console.ReadLine();

        }
    }//Guardjfdejk
}