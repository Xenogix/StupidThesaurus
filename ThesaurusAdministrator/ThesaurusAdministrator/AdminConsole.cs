using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesaurusAdministrator
{
    public partial class AdminConsole : Form
    {
        CommandManager commandManager;

        private string nonUserDelimiter = "> ";

        public AdminConsole()
        {
            InitializeComponent();

            commandManager = new CommandManager(this, Path.GetPathRoot(Environment.SystemDirectory));
         
            UserRelease();
        }

        private void RtbCommandPrompt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                string cmd = rtbCommandPrompt.Lines[rtbCommandPrompt.Lines.Length - 2];
                List<string> parameters = new List<string>();

                if (cmd != "")
                {

                    cmd = cmd.Substring(cmd.IndexOf(nonUserDelimiter) + nonUserDelimiter.Length, cmd.Length - cmd.IndexOf(nonUserDelimiter) - nonUserDelimiter.Length);

                    int commandLenght;

                    if ((commandLenght = cmd.IndexOf(" ")) != -1)
                        if(commandLenght - 1 != cmd.IndexOf(" "))
                            while(cmd.IndexOf(" ") != -1)
                            {
                                int fid = cmd.IndexOf(" ") + 1;
                                int sid = cmd.IndexOf(" ", cmd.IndexOf(" ") + 1);

                                if (fid != sid)
                                {
                                    if (sid == -1)
                                    {
                                        if (fid != cmd.Length)
                                        {
                                            parameters.Add(cmd.Substring(fid, cmd.Length - fid));
                                            cmd = cmd.Substring(0, fid);
                                        }
                                        else
                                            cmd = cmd.Substring(0, fid - 1) + cmd.Substring(fid, cmd.Length - fid);
                                    }
                                    else
                                    {
                                        parameters.Add(cmd.Substring(fid, sid - fid));
                                        cmd = cmd.Substring(0, fid) + cmd.Substring(sid, cmd.Length - sid);
                                    }
                                }
                                else
                                    cmd = cmd.Substring(0, fid - 1) + cmd.Substring(fid, cmd.Length - fid);
                            }

                    try {
                        var @delegate = commandManager.Commands[cmd];

                        try
                        {
                            @delegate.DynamicInvoke((object) parameters.ToArray());
                        }
                        catch(Exception exd)
                        {
                            try
                            {
                                Write("Une erreur est survenue. ");
                                Write(commandManager.CommandsInfos.FirstOrDefault(x => x.Value == commandManager.CommandsInfos[cmd]).Key + " : " + commandManager.CommandsInfos[cmd]);
                                commandManager.ShowLastError(null);
                            }
                            catch(Exception exci)
                            {
                                commandManager.ShowLastError(null);
                            }
                        }
                    }
                    catch(Exception ex) { Write("Commande inconnue. Tapez \"help\" pour voir la liste des commandes"); }
                }

                rtbCommandPrompt.AppendText("\n");
                UserRelease();
            }
        }

        public void Write(string text)
        {
            rtbCommandPrompt.ReadOnly = true;
            rtbCommandPrompt.AppendText(text + "\n");
            ProtectAllLines();
        }

        public void UserRelease()
        {
            rtbCommandPrompt.ReadOnly = false;
            rtbCommandPrompt.AppendText(commandManager.Directory + nonUserDelimiter);
            ProtectAllLines();
        }

        private void ProtectAllLines()
        {
            rtbCommandPrompt.SelectAll();
            rtbCommandPrompt.SelectionProtected = true;
            rtbCommandPrompt.Select(rtbCommandPrompt.TextLength, rtbCommandPrompt.TextLength);
        }

        public void Clear()
        {
            rtbCommandPrompt.Clear();
        }
    }
}
