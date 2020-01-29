using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesaurusAdministrator
{
    public partial class AdminConsole : Form
    {
        CommandManager commandManager;

        public AdminConsole()
        {
            InitializeComponent();

            commandManager = new CommandManager(this);
        }

        private void RtbCommandPrompt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                string cmd = rtbCommandPrompt.Lines[rtbCommandPrompt.Lines.Length - 2].ToLower();

                if (cmd != "")
                {
                    int commandLenght;

                    if ((commandLenght = cmd.IndexOf(" ")) == -1)
                        commandLenght = cmd.Length;

                    try {
                        ICommand command = commandManager.Commands[cmd.Substring(0, commandLenght)];
                        command.Call();
                    }
                    catch { Write("Commande inconnue. Tapez \"help\" pour voir la liste des commandes"); }
                }
            }
        }

        public void Write(string text)
        {
            rtbCommandPrompt.AppendText(text + "\n");
        }

        public void Clear()
        {
            rtbCommandPrompt.Clear();
        }
    }
}
