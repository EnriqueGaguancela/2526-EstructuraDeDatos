public class Paciente //Definición de la clase paciente.
{
    public string Nombre { get; set; } //Almacenar el nombre del paciente.
    public int Edad { get; set; }   //Almacenar la edad del paciente.
    public string DNI { get; set; }  //Almacenar el número de cédula del paciente.

    public Paciente(string nombre, int edad, string dni) //Creación del constructor.
    {
        this.Nombre = nombre;  //Asigna el valor del parámetro "nombre" a la propiedad "Nombre".
        this.Edad = edad;  //Asigna el valor del parámetro "edad" a la propiedad "Edad".
        this.DNI = dni;  //Asigna el valor del parámetro "dni" a la propiedad "DNI".
    }
}
