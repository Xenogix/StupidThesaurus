using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Timers;

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

        private Timer connexionTestTimer = new Timer(1000);

        public string LocalDirectory {get; set;}

        public CommandManager(AdminConsole cmd, string directory)
        {
            InitializeCommands();

            Console = cmd;
            LocalDirectory = directory;

            connexionTestTimer.Elapsed += new ElapsedEventHandler(CheckDatabaseConnexion);
        }

        private void InitializeCommands()
        {
            Commands = new Dictionary<string, Delegate>()
            {
                //Commandes utilitaires//
                { "help", new Call<string[]>(Help)},

                { "cls", new Call<string[]>(ConsoleClear)},

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

                { "cd", "Permet de définir le répertoire actuel\nParamètres : cheminDuRéperetoire"},
                /////////////////////////

                //Commandes d'initialisation//
                { "connectdatabase", "Permet de se connecter à une base de données MySql\nParamètres : nomDeLaDB  nomUtilisateur  motDePasse"},
                { "cnndb", "Permet de se connecter à une base de données MySql\nParamètres : hôte  nomUtilisateur  motDePasse"},

                { "init", "Créer une nouvelle table dans la base qui contient toutes les informations nécéssaire des fichiers\nParamètres : nomDeLaDB cheminSource"},
                //////////////////////////////
            };
        }

        private void Help(string[] parameters)
        {
            foreach(string command in CommandsInfos.Keys)
                Console.WriteLine(command + " : " + CommandsInfos[command] + " \n");
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
                    LocalDirectory = path;
                }
                else if (System.IO.Directory.Exists(LocalDirectory + path))
                {
                    LocalDirectory = LocalDirectory + path;
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
                try
                {
                    string dbName = parameters[0];
                    string filePath;

                    if (parameters.Length < 2)
                        filePath = LocalDirectory;
                    else
                        filePath = parameters[1];

                    try
                    {
                        FileManager manager = new FileManager();

                        List<IndexedFile> list = manager.GetAllFilesFromFolder(filePath, true, Console);
                        Console.WriteLine("\n\n\n" + list.Count.ToString() + " fichiers ont été indexés\n");

                        try
                        {
                            sqlConnection.Open();
                            MySqlCommand command = new MySqlCommand(GetCreationScript(dbName), sqlConnection);
                            command.ExecuteNonQuery();
                            Console.WriteLine("La base de donnée à bien été crée");
                        }
                        catch (MySqlException exdb)
                        {
                            lastError = exdb.ToString();
                            sqlConnection.Close();
                            throw exdb;
                        }

                        try
                        {
                            MySqlCommand cmd;
                            foreach (IndexedFile file in list)
                            {
                                var test = file.filType.ToString();
                                cmd = new MySqlCommand("INSERT INTO `"+dbName+"`.`files` (`filName`, `filType`, `filDirectory`, `filBasepoints`) VALUES('"+file.filName+"', '"+ file.filType.ToString() + "', '"+file.filDirectory+"', '');", sqlConnection);
                                cmd.ExecuteNonQuery();
                                Console.WriteLine("Le fichier "+file.filName+" à été importé dans la base de donnée");
                            }
                        }
                        catch (Exception exf)
                        {
                            lastError = exf.ToString();
                            sqlConnection.Close();
                            throw exf;
                        }
                    }
                    catch (Exception exf)
                    {
                        lastError = exf.ToString();
                        throw exf;
                    }
                }
                catch (Exception e)
                {
                    lastError = e.ToString();
                    throw e;
                }
            }
            else
            {
                Exception ex = new Exception("La connexion mysql n'a pas été faite\nVeuiller utiliser la commande \"cnndb\"");
                lastError = ex.ToString();
                throw ex;
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

                Console.lblIP.Text = server;
                Console.lblUser.Text = username;
                Console.lblStatus.Text = "Disconnected";
                Console.lblStatus.ForeColor = Color.DarkRed;
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
                sqlConnection.Close();

                Console.lblStatus.Text = "Connected";
                Console.lblStatus.ForeColor = Color.DarkGreen;

                connexionTestTimer.Start();
            }
            catch (Exception exc)
            {
                connexionTestTimer.Start();
                lastError = exc.ToString();
                throw exc;
            }
        }

        private string GetCreationScript(string dbName)
        {
            return Properties.Resources.DBTemplate.Replace("NAMEHERE", dbName);
        }

        private void CheckDatabaseConnexion(object sender, ElapsedEventArgs e)
        {
            try
            {
                if(sqlConnection.State != System.Data.ConnectionState.Open)
                    sqlConnection.Open();

                sqlConnection.Close();

                Console.lblStatus.Invoke(new System.Windows.Forms.MethodInvoker(delegate
                {
                    Console.lblStatus.Text = "Connected";
                    Console.lblStatus.ForeColor = Color.DarkGreen;
                }));
            }
            catch (Exception exc)
            {
                Console.lblStatus.Invoke(new System.Windows.Forms.MethodInvoker(delegate
                {
                    Console.lblStatus.Text = "Disconnected";
                    Console.lblStatus.ForeColor = Color.DarkRed;
                }));
            }
        }
    }
}
