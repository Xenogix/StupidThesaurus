using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesaurusAdministrator
{
    public class CommandManager
    {
        private AdminConsole Console;

        public Dictionary<string, ICommand> Commands { get; private set; }

        private MySqlConnection sqlConnection;

        public CommandManager(AdminConsole cmd)
        {
            InitializeCommands();

            this.Console = cmd;
        }

        private void InitializeCommands()
        {
            Commands = new Dictionary<string, ICommand>()
            {
                //Commandes utilitaires//
                { "help", new Help"Affiche la liste des commandes")},

                { "cls", new ConsoleClear("Efface la console", Console)},

                { "scdsk",Tuple.Create<delegate,string>( new Call(ScanDisk),"")},
                { "scandisk", Tuple.Create<delegate,string>(new Call(ScanDisk),"")},

                { "scdir", Tuple.Create<delegate,string>(new Call<string>(ScanDir),"")},
                { "scandir", Tuple.Create<delegate,string>(new Call<string>(ScanDir),"")},

                { "cd", Tuple.Create<delegate,string>(new Call<string>(ChooseDirectory),"")},
                /////////////////////////

                //Commandes d'initialisation//
                { "connectdatabase", Tuple.Create<delegate,string>(new ReturnCall<bool>(ConnectDatabase),"")},
                { "cnndb", Tuple.Create<delegate,string>(new ReturnCall<bool>(ConnectDatabase),"")},

                { "init", Tuple.Create<delegate,string>(new Call<string>(InitializeDisk), "")},*/
                //////////////////////////////
            };
        }

        private void Help()
        {
            Console.Write("Wala les commandes (uNoob)");
        }

        private void ScanDisk()
        {

        }

        private void ScanDir(string selectedPath)
        {

        }

        private void ChooseDirectory(string selectedPath)
        {

        }

        private void InitializeDisk(string selectedPath)
        {

        }

        private void ConsoleClear()
        {
            Console.Clear();
        }

        private bool ConnectDatabase()
        {
            string connetionString = null;

            //connetionString = "server=localhost;" + DATABASE + ";uid=" + USERNAME + ";pwd=" + PASSWORD + ";";

            sqlConnection = new MySqlConnection(connetionString);

            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
