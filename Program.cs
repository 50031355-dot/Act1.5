namespace Act1._5;

class Program
{
    static void Main(string[] args)
    {
        int eleccion=-1;
        Curso curso1=Curso();
        do{
            Console.WriteLine("1-AGREGAR NUEVO ALUMNO");
            Console.WriteLine("2-BUSCAR ALUMNO POR SU DNI");
            Console.WriteLine("3-AGREGAR UNA FALTA O MEDIA FALTA A UN ALUMNO");
            Console.WriteLine("4-MOSTRAR TODOS LOS ALUMNOS");
            Console.WriteLine("5-MOSTRAR ALUMNOS LIBRES");
            Console.WriteLine("6- SALIR");
            eleccion= int.Parse(Console.ReadLine());
            switch (eleccion){
                case 1:
                    int dni=-1;
                    do{
                        dni=IngreseInt("Ingrese el DNI");
                    }while(dni<0 && dni>999);
                    Console.WriteLine("INGRESE EL NOMBRE");
                    string nombre=Console.ReadLine();
                    double faltas=-1;
                    do{
                         faltas=IngreseInt("Ingrese la cantidad de faltas");
                    }while(faltas<0 && faltas>20);
                    bool exito=curso1.AgregarAlumno(dni, nombre, faltas);
                    if (exito){
                        Console.WriteLine("Alumno agregado");
                    }
                    else{
                        Console.WriteLine("Alumno no agregado, error");
                    }
                case 2:
                    Console.WriteLine("Ingrese el DNI del alumno que quiere buscar");
                    do{
                        int dni=IngreseInt("Ingrese el DNI");
                    }while(dni<0 && dni>999);
                    bool esta=curso1.BuscarAlumno(dni);
                    if(esta){
                        Console.WriteLine("Alumno encontrado");
                    }
                    else{
                        Console.WriteLine("Alumno no encontrado");
                    }

                case 3:
                    Console.WriteLine("Ingrese el DNI del alumno que quiere agregar falta");
                    do{
                        int dni=IngreseInt("Ingrese el DNI");
                    }while(dni<0 && dni>999);
                    do{
                        int faltas=IngreseInt("Ingrese la cantidad de faltas");
                    }while(faltas<0 && faltas>20);
                    bool encontrado=AgregarFaltaCurso(dni, faltas);
                    if(encontrado){
                        Console.WriteLine("Falta agregada");
                    }
                    else{
                        Console.WriteLine("Error. Falta no agregada");
                    }

                case 4:
                    List<Alumno> listaAlumnos = curso1.MostrarAlumnos();
                    foreach(Alumno a in listaAlumnos){
                        Console.WriteLine(a.MostrarInfo());
                    }
                case 5: 
                    List<Alumno> listaAlumnosLibres = curso1.MostrarAlumnosLibres();
                    foreach(Alumno a in listaAlumnosLibres){
                        Console.WriteLine(a.MostrarInfo());
                    }
            }
        }while(eleccion<1 && eleccion>6);

    }
}
