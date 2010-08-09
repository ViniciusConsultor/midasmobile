using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using Midas.Nucleo.Dados.SQLServerCE;

namespace Midas.Nucleo.Form
{
    public class FormStack : CollectionBase
    {
        private System.Collections.ArrayList stack = new ArrayList();
        private bool remember;

        public void Run()
        {
            do
            {
                System.Windows.Forms.Application.DoEvents();
            } while (List.Count > 0);
        }

        public void Remember()
        {
            this.remember = true;
        }

        public void Stop()
        {
            // nicely destroy each Form
            foreach (StackForm sf in List)
            {
                sf.Dispose();
            }

            // clear the list to kill the message pump in Run()
            List.Clear();
            SQLServerCEFactory.FecharTodasConexoes();
        }

        public void Push(Type FormType)
        {
            // only allow 1 Push at a time to maintain cache and stack integrity
            Monitor.Enter(this);

            foreach (StackForm sf in List)
            {
                if (sf.GetType().Name.Equals(FormType.Name))
                {
                    sf.Limpar();
                    sf.TratarDados();

                    // form is cached so display cached version
                    sf.Visible = true;

                    // add it to the stack
                    stack.Add(FormType.Name);

                    return;
                }
            }

            // the Form wasn't cached, so create it
            StackForm form = Preload(FormType);

            // display it
            form.Visible = true;

            // add a close event handler
            form.FormClosed += new FormClose(form_FormClosed);

            // add it to the stack
            stack.Add(FormType.Name);

            Monitor.Exit(this);
        }

        public StackForm Preload(Type FormType)
        {
            StackForm form = (StackForm)Activator.CreateInstance(FormType);

            // get data on a separate thread
            form.LoadData();

            // build the form
            form.InitializeComponent();

            // wait for the data thread to finish
            form.threadRunning.WaitOne();

            form.Limpar();

            // now populate the controls with any retrieved data
            form.TratarDados();

            form.MinimizeBox = false;  // required to get close event on PPC!

            // add it to the cache
            List.Add(form);

            return form;
        }

        public void Pop(uint FormsToPop)
        {
            if (stack.Count <= FormsToPop)
            {
                this.Stop();
            }
            else
            {
                // remove from stack but not cache
                for (int i = 0; i < FormsToPop; i++)
                {
                    stack.RemoveAt(stack.Count - 1);
                }

                foreach (StackForm sf in List)
                {
                    // find the last form in the stack
                    if (sf.GetType().Name.Equals(stack[stack.Count - 1]))
                    {
                        // make it visible
                        sf.Visible = true;
                        
                        if (remember)
                        {
                            sf.TratarDados();
                            sf.Lembrar();
                        }
                        else
                        {
                            sf.Limpar();
                            sf.TratarDados();
                        }
                        this.remember = false;
                    }
                }
            }
        }

        public void PopNoClear(uint FormsToPop)
        {
            if (stack.Count <= FormsToPop)
            {
                this.Stop();
            }
            else
            {
                // remove from stack but not cache
                for (int i = 0; i < FormsToPop; i++)
                {
                    stack.RemoveAt(stack.Count - 1);
                }

                foreach (StackForm sf in List)
                {
                    // find the last form in the stack
                    if (sf.GetType().Name.Equals(stack[stack.Count - 1]))
                    {
                        sf.Visible = true;
                    }
                }
            }
        }

        private void form_FormClosed()
        {
            Pop(1);
        }

        public override string ToString()
        {
            string message = "There are " + List.Count.ToString() + " forms cached\r\n";
            message += "Stack contents:";

            for (int i = stack.Count - 1; i >= 0; i--)
            {
                message += "\r\n" + stack[i].ToString();
            }

            return message;
        }
    }
}
