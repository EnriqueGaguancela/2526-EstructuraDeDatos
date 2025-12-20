Clinica clinica = new Clinica();  //Crea una instancia de la clínica.
clinica.CargarPacientesDesdeArchivo("pacientes.txt");
clinica.CargarAgendaDesdeArchivo("agenda.txt");

bool salir = false;

while (!salir)  //Bucle principal del menú.
{
    Console.Clear();  //Limpia la consola para mostrar el menú principal.
    Console.WriteLine("*** Bienvenidos al Sistema de Agendamiento ***");
    Console.WriteLine("1. Agregar Paciente");
    Console.WriteLine("2. Asignar Turno");
    Console.WriteLine("3. Mostrar Pacientes");
    Console.WriteLine("4. Mostrar Agenda");
    Console.WriteLine("5. Guardar y Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();  //Ejecuta la opción seleccionada en el menú principal.

    switch (opcion)
    {
        case "1":  //Agregar un nuevo paciente.
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Paciente nuevo = new Paciente(nombre, edad, dni);  //Crea un nuevo Paciente.
            clinica.AgregarPaciente(nuevo);
            break;

        case "2":  //Asignación de un turno a un paciente.
            Console.Write("DNI del paciente: ");
            string dniTurno = Console.ReadLine();
            Console.Write("Día (0=Lunes, 1=Martes, 2=Miércoles, 3=Jueves, 4=Viernes): ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Hora (0=08:00, 1=09:00, 2=10:00, 3=11:00, 4=12:00): ");
            int hora = int.Parse(Console.ReadLine());

            clinica.AsignarTurno(dniTurno, dia, hora);  //Llama al método que asigna los turnos.
            break;

        case "3":  //Opción para mostrar la lista de pacientes registrados.
            clinica.MostrarPacientes();
            Console.ReadKey();
            break;

        case "4":  //Opción para mostrar la agenda de turnos asignados.
            clinica.MostrarAgenda();
            Console.ReadKey();
            break;

        case "5":  //Guardar datos antes de salir.
            clinica.GuardarPacientesEnArchivo("pacientes.txt");
            clinica.GuardarAgendaEnArchivo("agenda.txt");
            salir = true;
            break;

        default:
            Console.WriteLine("Opción no válida.");  //Opción inválida si el usuario opta por una ópcion que no existe en el menú principal.
            Console.ReadKey();
            break;
    }
}
