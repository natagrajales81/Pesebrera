using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pesebrera.MODELOS;

namespace Pesebrera.NEGOCIO
{
    // Método que lee el archivo EQUINOSBOVINOS.DAT para luego generar los txt resultantes de Bovinos y Equinos
    public class Generacion
    {
        string[] lineas;
        // Método que Lee el archivo consolidado de bovinos y equinos
        void LeerArchivo()
        {
            string pathArchivo = @"C:\Users\Pc\Downloads\EQUNOSBOVINOS.DAT";
            if (File.Exists(pathArchivo))
                lineas = System.IO.File.ReadAllLines(pathArchivo);
            else
                throw new Exception("No hay archivo para Clasificar");

        }

        // Método que Genera los archivos separados de bovinos y equinos
        public void GenerarArchivos()
        {
            LeerArchivo();
            Clasificacion clasificacion = new Clasificacion();
            string pathBovinos = @"C:\Users\Pc\Downloads\Bovinos.txt";
            string pathEquinos = @"C:\Users\Pc\Downloads\Equinos.txt";
            if (File.Exists(pathBovinos))
                File.Delete(pathBovinos);
            if (File.Exists(pathEquinos))
                File.Delete(pathEquinos);
            StreamWriter archivoBovinos = new StreamWriter(pathBovinos);
            StreamWriter archivoEquinos = new StreamWriter(pathEquinos);
            archivoBovinos.AutoFlush = true;
            archivoEquinos.AutoFlush = true;

            foreach (string linea in lineas)
            {
                if (clasificacion.ClasificaBovinoEquino(linea) == 'B')
                {
                    archivoBovinos.WriteLine(linea);
                }
                else
                {
                    archivoEquinos.WriteLine(linea);
                }
            }

        }

    }
}
