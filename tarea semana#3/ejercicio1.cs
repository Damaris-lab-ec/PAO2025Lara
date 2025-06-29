using System;

namespace RegistroEstudiante
{
    // Clase que representa a un estudiante
    public class Estudiante
    {
        // Atributos privados
        private int id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string[] telefonos;

        // Constructor para inicializar los atributos
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefonos = telefonos;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Datos simulados para el ejemplo
            string[] telefonos = new string[3] { "0987654321", "0998765432", "0976543210" };

            // Crear objeto estudiante con todos sus datos
            Estudiante estudiante = new Estudiante(1, "Damaris", "Lara", "Av. Principal y Calle Secundaria", telefonos);

            // Mostrar la información del estudiante
            estudiante.MostrarInformacion();

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
