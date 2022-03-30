using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;

namespace Annuaire
{
    public partial class Appli : Form
    {
        ManagerPerson managerPerson = new ManagerPerson(); //Pour appeler la class ManagerPerson

        public Appli()
        {
            InitializeComponent();
        }

        private void label_Recherche_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            managerPerson.connection.Open(); //Ouvrir la connexion à la BDD
            // Requête SQL
            object ID_DataGridView = dataGridView1.CurrentRow.Index + 1;
            managerPerson.cmd.CommandText = "SELECT Date_Arrivee FROM users WHERE ID = '"+ ID_DataGridView + "';"; //Défini la requete pour récuperer la Date d'arrivée par rapport à l'ID
            managerPerson.Reader = managerPerson.cmd.ExecuteReader();

            if (managerPerson.Reader.HasRows)
            {
                
                if (managerPerson.Reader.Read())
                {
                    string IDt = Convert.ToString(managerPerson.Reader[0]); //Converti l'objet en string
                    dateTimePicker_Date.Value = DateTime.Parse(IDt); //Affiche la date sur le DateTimePicker
                }
                
            }
            managerPerson.connection.Close(); //Ferme la connexion à la BDD
        }

        public void LoadGrid() //Affiche dans le DGV la BDD
        {
            dataGridView1.Rows.Clear();

            managerPerson.connection.Open();        
            // Requête SQL
            managerPerson.cmd.CommandText = "SELECT * FROM users"; //Défini la requete pour se connecter a la table users
            managerPerson.Reader = managerPerson.cmd.ExecuteReader();

            if (managerPerson.Reader.HasRows)
            {
                while (managerPerson.Reader.Read())
                {
                    dataGridView1.Rows.Add(managerPerson.Reader[0].ToString(), managerPerson.Reader[1].ToString(), managerPerson.Reader[2].ToString(), managerPerson.Reader[3].ToString(), managerPerson.Reader[4].ToString());
                }
            }
            managerPerson.connection.Close();
        }

        

        private void Button_Quitter_Click(object sender, EventArgs e)
        {
            managerPerson.connection.Close();
            Application.Exit(); //Ferme l'appli
        }

        private void Button_Recherche_Click(object sender, EventArgs e)
        {
            string Text_Recup = textBox_Recherche.Text; //Récuperer le texte qui est dans le textbox 
            dataGridView1.Rows.Clear(); //Efface le DGV

            managerPerson.connection.Open();
            // Requête SQL
            managerPerson.cmd.CommandText = "SELECT * FROM users WHERE ID='" + Text_Recup + "' OR Prenom='" + Text_Recup + "' OR Nom='" + Text_Recup + "' OR Telephone='" + Text_Recup + "' OR Service='" + Text_Recup + "' "; //Défini la requete pour se connecter a la table users
            managerPerson.Reader = managerPerson.cmd.ExecuteReader();

            if (managerPerson.Reader.HasRows)
            {
                while (managerPerson.Reader.Read())
                {
                    dataGridView1.Rows.Add(managerPerson.Reader[0].ToString(), managerPerson.Reader[1].ToString(), managerPerson.Reader[2].ToString(), managerPerson.Reader[3].ToString(), managerPerson.Reader[4].ToString()); //Affiche dans le DGV
                }
            }
            managerPerson.connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            managerPerson.cmd.Connection = managerPerson.connection;
            LoadGrid(); //Appel de LoadGrid
        }

        private async void button_Add_User_Click(object sender, EventArgs e)
        {
            await managerPerson.AddContact(); //Appel de AddContact pour ajouter un utilisateur dans le BDD
            LoadGrid(); //Appel de LoadGrid pour actualiser le DGV
        }

        private void textBox_Recherche_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker_Date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
