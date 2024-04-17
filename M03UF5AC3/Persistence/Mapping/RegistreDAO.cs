using Npgsql;
using M03UF5AC3.Persistence.DAO;
using M03UF5AC3.Persistence.Utils;

namespace M03UF5AC3.Persistence.Mapping
{
    public class RegistreDAO : IRegistreDAO
    {
        private readonly string connectionString;

        public RegistreDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Registre GetComarcaById(int id)
        {
            Registre contact = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"ID\", \"anycomarca\", \"codi\", \"comarca\", \"poblacio\", \"domesticxarxa\", \"acteconomiques\", \"total\", \"consumcapita\" FROM \"consum\" WHERE \"ID\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    contact = NpgsqlUtils.GetComarca(reader);
                }
            }
            return contact;
        }

        public void AddComarca(Registre contact)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO \"consum\" (\"anycomarca\", \"codi\", \"comarca\", \"poblacio\", \"domesticxarxa\", \"acteconomiques\", \"total\", \"consumcapita\") VALUES (@Any, @Codi, @Comarca, @Poblacio, @Domesticxarxa, @Acteconomiques, @Total, @Consumcapita)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Any", contact.Any);
                command.Parameters.AddWithValue("@Codi", contact.Codi_comarca);
                command.Parameters.AddWithValue("@Comarca", contact.Comarca);
                command.Parameters.AddWithValue("@Poblacio", contact.Població);
                command.Parameters.AddWithValue("@Domesticxarxa", contact.Domèstic_xarxa);
                command.Parameters.AddWithValue("@Acteconomiques", contact.Activitats_econòmiques_i_fonts_pròpies);
                command.Parameters.AddWithValue("@Total", contact.Total);
                command.Parameters.AddWithValue("@Consumcapita", contact.Consum_domèstic_per_càpita);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateComarca(Registre contact)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "UPDATE \"consum\" SET \"anycomarca\" = @Any, \"codi\" = @Codi, \"comarca\" = @Comarca, \"poblacio\" = @Poblacio, \"domesticxarxa\" = @Domesticxarxa, \"acteconomiques\" = @Acteconomiques, \"total\" = @Total, \"consumcapita\" = @Consumcapita WHERE \"ID\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Any", contact.Any);
                command.Parameters.AddWithValue("@Codi", contact.Codi_comarca);
                command.Parameters.AddWithValue("@Comarca", contact.Comarca);
                command.Parameters.AddWithValue("@Poblacio", contact.Població);
                command.Parameters.AddWithValue("@Domesticxarxa", contact.Domèstic_xarxa);
                command.Parameters.AddWithValue("@Acteconomiques", contact.Activitats_econòmiques_i_fonts_pròpies);
                command.Parameters.AddWithValue("@Total", contact.Total);
                command.Parameters.AddWithValue("@Consumcapita", contact.Consum_domèstic_per_càpita);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteComarca(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "DELETE FROM \"consum\" WHERE \"ID\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Registre> GetAllComarques()
        {
            List<Registre> contacts = new List<Registre>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"ID\", \"anycomarca\", \"codi\", \"comarca\", \"poblacio\", \"domesticxarxa\", \"acteconomiques\", \"total\", \"consumcapita\" FROM \"consum\"";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Registre contact = NpgsqlUtils.GetComarca(reader);
                    contacts.Add(contact);
                }
            }
            return contacts;
        }

        /*
        codi per a reiniciar la base de dades

        DROP table if exists Consum;

        Create table Consum (
            id SERIAL NOT NULL PRIMARY KEY ,
            anycomarca numeric(4),
            codi numeric,
            comarca varchar,
            poblacio numeric,
            domesticxarxa decimal,
            acteconomiques decimal,
            total decimal,
            consumcapita decimal
        )*/  

    }
}
