using Funeraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class MisArchivos <T>
    {

        /// <summary>
        /// Guarda la lista de personas en un archivo json
        /// </summary>
        public static void GuardarDatos(List<T> lista)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string archivoJson = "Cementerio.json";
            string rutaCompleta = Path.Combine(path, archivoJson);

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                string personasJson = JsonSerializer.Serialize(lista, options);
                sw.WriteLine(personasJson);
            }

        }

        /// <summary>
        /// Carga la lista de personas desde un archivo json
        /// </summary>
        /// <returns></returns>
        public static List<T> CargarDatos()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string archivoJson = "Cementerio.json";
            string rutaCompleta = Path.Combine(path, archivoJson);

            List<T> auxPersona;

            if (File.Exists(rutaCompleta))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(rutaCompleta))
                    {
                        string jsonString = sr.ReadToEnd();
                        auxPersona = JsonSerializer.Deserialize<List<T>>(jsonString);

                        return auxPersona;

                    }
                }
                catch (JsonException ex)
                {


                }

            }
            return null;

        }
    }
}
