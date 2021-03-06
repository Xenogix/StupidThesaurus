﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
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

            commandManager = new CommandManager(this, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            UserRelease();
        }

        private void RtbCommandPrompt_KeyPress(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    e.Handled = true;
                    SendCommand();
                    break;

            }
        }

        private void SendCommand()
        {
            string cmd = rtbCommandPrompt.Lines[rtbCommandPrompt.Lines.Length-1];
            List<string> parameters = new List<string>();
            rtbCommandPrompt.AppendText("\n");

            if (cmd != "")
            {
                cmd = cmd.Substring(cmd.IndexOf(nonUserDelimiter) + nonUserDelimiter.Length, cmd.Length - cmd.IndexOf(nonUserDelimiter) - nonUserDelimiter.Length);

                int commandLenght;

                if ((commandLenght = cmd.IndexOf(" ")) != -1)
                    if (commandLenght - 1 != cmd.IndexOf(" "))
                        while (cmd.IndexOf(" ") != -1)
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
                try
                {
                    var @delegate = commandManager.Commands[cmd];

                    ThreadPool.QueueUserWorkItem(Execute, new object[] {@delegate, parameters });
                }
                catch (Exception ex) { 
                    WriteLine("Commande inconnue. Tapez \"help\" pour voir la liste des commandes");
                    rtbCommandPrompt.AppendText("\n");
                    UserRelease();
                }
            }
        }

        private void Execute(object o)
        {
            Invoke(new MethodInvoker(() =>
            {
                try
                {
                    object[] array = o as object[];
                    Delegate @delegate = array[0] as Delegate;
                    string[] parameters = ((IEnumerable)array[1]).Cast<object>().Select(x => x.ToString()).ToArray();

                    @delegate.DynamicInvoke((object)parameters.ToArray());

                    rtbCommandPrompt.AppendText("\n");
                    UserRelease();
                }
                catch (Exception exci)
                {
                    commandManager.ShowLastError(null);
                }
            }));
        }


        public void WriteLine(string text)
        {
            rtbCommandPrompt.AppendText(text + "\n");
            ProtectAllLines();
        }

        public void Write(string text)
        {
            rtbCommandPrompt.AppendText(text);
        }

        public string Delimiter()
        {
            return commandManager.LocalDirectory + nonUserDelimiter;
        }

        public void UserRelease()
        {
            rtbCommandPrompt.ReadOnly = false;
            rtbCommandPrompt.AppendText(Delimiter());
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
