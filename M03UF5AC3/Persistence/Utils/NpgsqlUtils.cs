using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Npgsql;

namespace M03UF5AC3.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile(@"C:\Users\argo\Documents\ADavid Galan\Visual studio m3\M03UF5AC4\M03UF5AC3\appsettings.json", optional: false, reloadOnChange: true)
            .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static Registre GetComarca(NpgsqlDataReader reader)
        {
            Registre c = new Registre
            {
                Any = reader.GetInt32(0),
                Codi_comarca = reader.GetInt32(1),
                Comarca = reader.GetString(2),
                Població = reader.GetInt32(3),
                Domèstic_xarxa = reader.GetInt32(4),
                Activitats_econòmiques_i_fonts_pròpies = reader.GetInt32(5),
                Total = reader.GetInt32(6),
                Consum_domèstic_per_càpita = reader.GetDouble(7)
            };
            return c;
        }

    }
}
