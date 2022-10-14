class Program
{
    static void Main(string[] args)
    {
        string usuario1, contra;

        Console.WriteLine("Bienvenido ;)");


     

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ingrese un el usuario ");
            usuario1 = (Console.ReadLine());


            Console.WriteLine("Ingrese su contraseña: ");
            contra = (Console.ReadLine());


            if (usuario1 == "usuario" && contra == "asdasd")
            {
                Console.WriteLine("Bienvenido, Su usuario y contraseña son correctas ");
                break;
            }
            else
            {
                Console.WriteLine("Incorrecto");
            }
        }




    }
}