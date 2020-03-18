using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace ThesaurusAdministrator
{
    public class CommandManager
    {
        private delegate TResult Call<in T, out TResult>(T obj);
        private delegate void Call<in T>(T obj);

        private AdminConsole Console;

        public Dictionary<string, Delegate> Commands { get; private set; }
        public Dictionary<string, string> CommandsInfos { get; private set; }

        private string lastError = "Il n'y a pas eu d'erreur";

        private string parametersError = "Les paramètres entrés sont incorrects";

        private MySqlConnection sqlConnection;

        public string Directory {get; set;}

        public CommandManager(AdminConsole cmd, string directory)
        {
            InitializeCommands();

            this.Console = cmd;
            Directory = directory;
        }

        private void InitializeCommands()
        {
            Commands = new Dictionary<string, Delegate>()
            {
                //Commandes utilitaires//
                { "help", new Call<string[]>(Help)},

                { "cls", new Call<string[]>(ConsoleClear)},

                { "scdsk", new Call<string[]>(ScanDisk) },
                { "scandisk", new Call<string[]>(ScanDisk)},

                { "scdir", new Call<string[]>(ScanDir)},
                { "scandir", new Call<string[]>(ScanDir)},

                { "cd", new Call<string[]>(ChooseDirectory)},

                { "slr", new Call<string[]>(ShowLastError)},
                { "showlasterror", new Call<string[]>(ShowLastError)},
                /////////////////////////

                //Commandes d'initialisation//
                { "connectdatabase", new Call<string[]>(ConnectDatabase)},
                { "cnndb", new Call<string[]>(ConnectDatabase)},

                { "init", new Call<string[]>(LoadDisk) },
                //////////////////////////////
            };

            CommandsInfos = new Dictionary<string, string>()
            {
                //Commandes utilitaires//
                { "help", "Affiche la liste des commandes"},

                { "cls", "Efface la console"},

                { "scdsk", "Affiche le contenu d'un répertoire et de tous ses sous-répertoires"},
                { "scandisk", "Affiche le contenu d'un répertoire et de tous ses sous-répertoires"},

                { "scdir", "Affiche le contenu d'un répertoire"},
                { "scandir", "Affiche le contenu d'un répertoire"},

                { "cd", "Permet de définir le répertoire actuel\nParamètres : cheminDuRéperetoire"},
                /////////////////////////

                //Commandes d'initialisation//
                { "connectdatabase", "Permet de se connecter à une base de données MySql\nParamètres : nomDeLaDB  nomUtilisateur  motDePasse"},
                { "cnndb", "Permet de se connecter à une base de données MySql\nParamètres : nomDeLaDB  nomUtilisateur  motDePasse"},

                { "init", "Créer une nouvelle table dans la base qui contient toutes les informations nécéssaire des fichiers\nParamètres : nomDeLaDB cheminSource"},
                //////////////////////////////
            };
        }

        private void Help(string[] parameters)
        {
            foreach(string command in CommandsInfos.Keys)
                Console.WriteLine(command + " : " + CommandsInfos[command] + " \n");
        }

        private void ScanDisk(string[] parameters)
        {
        }

        private void ScanDir(string[] parameters)
        {

        }
        
        private void ChooseDirectory(string[] parameters)
        {
            string path = "";

            try
            {
                path = parameters[0];
            }
            catch (Exception e)
            {
                lastError = parametersError;
                throw e;
            }

            try
            {
                if (System.IO.Directory.Exists(path))
                {
                    Directory = path;
                }
                else if (System.IO.Directory.Exists(Directory + path))
                {
                    Directory = Directory + path;
                }
                else
                    throw new FileNotFoundException();
            }
            catch (Exception exc)
            {
                lastError = exc.ToString();
                throw exc;
            }
        }

        private void LoadDisk(string[] parameters)
        {
            if (sqlConnection != null)
            {
                string[] files = Directory.GetFiles("C:\Users\na_trium\Desktop\", ".", SearchOption.AllDirectories);
                int[] points = new int[files.Length];
                int i = 0;
                foreach (var file in files)
                {
                    Console.WriteLine(file);

                    i++;
                }
            }
            else
            {
            }
        }

        public void ShowLastError(string[] parameters)
        {
            Console.WriteLine(lastError);
        }

        private void ConsoleClear(string[] parameters)
        {
            Console.Clear();
        }

        private void ConnectDatabase(string[] parameters)
        {
            string connetionString = "";

            try
            {
                string username = parameters[1];
                string password = parameters[2];
                string server = parameters[0];

                connetionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";";

            }
            catch (Exception e)
            {
                lastError = parametersError;
                throw e;
            }

            try
            {
                sqlConnection = new MySqlConnection(connetionString);
                sqlConnection.Open();
                Console.WriteLine("La connexion a été effectuée avec succès !");
            }
            catch (Exception exc)
            {
                lastError = exc.ToString();
                throw exc;
            }
        }
    }
}
