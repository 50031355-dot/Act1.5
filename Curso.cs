namespace Act1._5;

class Curso
{
    private List<Alumno> listaAlumnos = new List<Alumno>();

    public Curso()
    {
    }

    public bool AgregarAlumno(int dni, string nombre, double cantFaltas)
    {
        bool esta = BuscarAlumno(dni);
        if (esta){
            return false;
        }
        Alumno a = new Alumno(dni, nombre, cantFaltas);
        listaAlumnos.Add(a);
        return true;
    }
    public bool BuscarAlumno(int dni){
        int index=0;
        while(index!=listaAlumnos.Count()){
            if (dni==listaAlumnos[index].GetDNI()){
                return true;
            }
            index+=1;
        }
        return false;
    }
    public List<Alumno> MostrarAlumnos(){
        return listaAlumnos;
    }
    public List<Alumno> MostrarAlumnosLibres(){
        List<Alumno> listaLibres = new List<Alumno>();
        foreach(Alumno a in listaAlumnos){
            double faltas= a.GetFaltas();
            if (faltas>15){
                listaLibres.Add(a);
            }
        }
        return listaLibres;
    }
    public bool AgregarFaltaCurso(int dni, double falta){
        bool encontrado=BuscarAlumno(dni);
        if (encontrado){
            Alumno a =EncontrarAlumno(dni);
            a.AgregarFaltaAlumno(falta);
        }
        return encontrado;
    }
    private Alumno EncontrarAlumno(int dni){ //Esta funcion busca el alumno y además devuelve el alumno
        int index=0;
        Alumno alumno=listaAlumnos[0];
        while(index!=listaAlumnos.Count()){
            if (dni==listaAlumnos[index].GetDNI()){
                 alumno=listaAlumnos[index];
            }
            index+=1;
        }
        return alumno;
    }
}