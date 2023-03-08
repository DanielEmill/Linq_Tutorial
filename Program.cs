using System;
using System.Collections.Generic;
using System.Linq;
// Program.cs
public class Program
{
	public static void Main()
	{
		//lista
		IList<Student> studentList = new List<Student>() 
        { 
            new Student() { EstudianteID = 1, Nombre = "Jose", Edad = 14} ,
            new Student() { EstudianteID = 2, Nombre = "Marco",  Edad = 12 } ,
            new Student() { EstudianteID = 3, Nombre = "Juan",  Edad = 54 } ,
            new Student() { EstudianteID = 4, Nombre = "Ramon" , Edad = 7} ,
            new Student() { EstudianteID = 5, Nombre = "Lucas" , Edad = 15 } 
        };

        //Uso de Where
		var edades = from o in studentList where o.EstudianteID >= 1 && o.EstudianteID <= 3 select o;
		Console.WriteLine("Estudiante con ID del 1 al 3");
		foreach(Student std in edades){			
			Console.WriteLine(std.Nombre);
		}
        //


	}
}

public class Student{
	public int EstudianteID { get; set; }
	public string? Nombre { get; set; }
	public int Edad { get; set; }
}