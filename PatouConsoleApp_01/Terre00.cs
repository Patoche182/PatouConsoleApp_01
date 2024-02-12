/*using System;

class Terre00
{
    static void Main()
    {
        for (char lettre = 'A'; lettre <= 'Z'; lettre++)
        {
            Console.Write(lettre.ToString().ToLower());
        }
        Console.WriteLine();
    }
}
*/

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(" █████╗ ██╗     ███████╗██╗  ██╗    ███████╗████████╗    ██╗     ███████╗    ██████╗ ██████╗  █████╗  ██████╗  ██████╗ ███╗   ██╗    ██╗ ");
		Console.WriteLine("██╔══██╗██║     ██╔════╝╚██╗██╔╝    ██╔════╝╚══██╔══╝    ██║     ██╔════╝    ██╔══██╗██╔══██╗██╔══██╗██╔════╝ ██╔═══██╗████╗  ██║    ██║ ");
		Console.WriteLine("███████║██║     █████╗   ╚███╔╝     █████╗     ██║       ██║     █████╗      ██║  ██║██████╔╝███████║██║  ███╗██║   ██║██╔██╗ ██║    ██║ ");
		Console.WriteLine("██╔══██║██║     ██╔══╝   ██╔██╗     ██╔══╝     ██║       ██║     ██╔══╝      ██║  ██║██╔══██╗██╔══██║██║   ██║██║   ██║██║╚██╗██║    ╚═╝ ");
		Console.WriteLine("██║  ██║███████╗███████╗██╔╝ ██╗    ███████╗   ██║       ███████╗███████╗    ██████╔╝██║  ██║██║  ██║╚██████╔╝╚██████╔╝██║ ╚████║    ██╗ ");
		Console.WriteLine("╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝    ╚══════╝   ╚═╝       ╚══════╝╚══════╝    ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝    ╚═╝ ");
		Console.WriteLine("Notre histoire nous ammène dans un pays loingtain, notre héro se prénomme Alex. \nCe grand bonhomme est un guerrier très vaillant. \nUn jour il trouva une Foret, avec son fidèle cheval dénomé Tornnado, il s'aventura dans la Forêt. \nAprès plusieurs kilomètres il trouva un sentier qui grimpait très très haut, il décida de le suivre. \nA m'en donné ce sentier se divisa en 2, un alla vers l'Ouest et l'autre vers l'Est.  \n...Mais, le quel suivre ???");
		Console.WriteLine("\n est ou ouest?\n");
		string dir = Console.ReadLine();
		if (dir == "ouest")
		{
			Console.WriteLine("Alex se retrouve devant le Dragon et se fait brûler. FIN");
			Environment.Exit(0);
		}
		else if (dir =="est")
		{
			Console.WriteLine("Alex arrive dans le chateau. Il entend la princesse crier au secours !\nil faut maintenant choisir le bon escalier pour ne pas tomber dans le chachot !\n Alors, Nord ou Sud?\n");
            Console.WriteLine("\nNord ous Sud ?\n");
            string dir2 = Console.ReadLine();
            if (dir2 == "sud")
            {
                Console.WriteLine("Alex se retrouve alors piégé dans le cachot du chateau à tout jamais. FIN");
                Environment.Exit(0);
            }
            else if (dir2 == "nord")
			{
				Console.WriteLine("Alex délivra la princesse dans le Donjon, YOUPIII !\n");
            }
        }
		else 
		{
			Console.WriteLine("Faites un choix correcte !");
			dir = Console.ReadLine();
		}
	}
	
}
 
