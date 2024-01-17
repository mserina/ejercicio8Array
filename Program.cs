namespace ejercicio8Array{

    /// <summary>
    /// 
    /// msm - 170124
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            int condicion;
            bool cerrarBucle = false;

            string[] palabras = { "Hola", "Adios","Nuevo", "Viejo", "Vamos"};
           
            indice = Array.IndexOf(palabras,"Adios"); //si existe mas de uno solo nos dara la primera posicion

            if (indice < 0)
            {
                Console.WriteLine("No existe el el array");
            }
            else
            {
                Console.WriteLine("La posicion es " + indice);
            }

            //Establece un condicional que en función de la palabra que pase un usuario por consola
            Console.WriteLine(" ");
            Console.WriteLine("Inserte la palabra que desea encontrar");
            string palabraUsuario = Console.ReadLine();
            indice = Array.IndexOf(palabras, palabraUsuario);

            if (indice >= 0) 
            {
                Console.WriteLine("Existe en el array");
            }
            else
            {
                Console.WriteLine("No existe en el array");
            }




        }
    }
}