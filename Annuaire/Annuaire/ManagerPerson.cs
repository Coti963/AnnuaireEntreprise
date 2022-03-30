using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;

namespace Annuaire
{
    public class ManagerPerson
    {
        Personnes Personnes = new Personnes();

        public MySqlConnection connection = new MySqlConnection("SERVER=127.0.0.1; DATABASE=annuaire; UID=root; PASSWORD=; Convert Zero Datetime=True;"); //Défini la connexion à la BDD
        public MySqlDataReader Reader;
        public MySqlCommand cmd = new MySqlCommand();

        private static readonly HttpClient client = new HttpClient(); //Défini client pour HttpClient

        // Constructeur
        public ManagerPerson()
        {  
        }

        public async Task AddContact() //Fonction pour ajouter un contact
        {
            var streamTask = await client.GetStringAsync("https://randomuser.me/api/?nat=fr"); //Appel de l'API

            dynamic repositories = JsonConvert.DeserializeObject(streamTask); //déconcaténation du résultat de l'API

            Personnes.Prenom = repositories.results[0].name.first; //Récupération du Prénom
            Personnes.Nom = repositories.results[0].name.last; //Récupération du Nom
            Personnes.Telephone = repositories.results[0].phone; //Récupération du Téléphone
            Personnes.Service = repositories.results[0].id.name; //Récupération du Service
            Personnes.Date_Entree = repositories.results[0].registered.date; //Récupération de la Date D'arrivée

            string Date_Entree_Def = ""+ Personnes.Date_Entree.Year + "/" + Personnes.Date_Entree.Month + "/" + Personnes.Date_Entree.Day +""; //Mets dans le bon format la date sous forme de AAAA/MM/JJ
            Personnes.Telephone = new string((from Carac in Personnes.Telephone where char.IsWhiteSpace(Carac) || char.IsLetterOrDigit(Carac) select Carac).ToArray()); //Supression des "-"

            try
            {
                // Requête SQL
                string Query = "INSERT INTO Users (Prenom, Nom, Telephone, Service, Date_Arrivee) VALUES ('" + Personnes.Prenom + "','" + Personnes.Nom + "','" + Personnes.Telephone + "','" + Personnes.Service + "','" + Date_Entree_Def + "');";

                MySqlCommand Cmd = new MySqlCommand(Query, connection); 
                MySqlDataReader Reader;
                connection.Open();
                Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Console.WriteLine(Reader.GetString(0));
                }
                // Fermeture de la connexion
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
