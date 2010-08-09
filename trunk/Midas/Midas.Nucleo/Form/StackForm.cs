using System;
using System.ComponentModel;
using System.Threading;

namespace Midas.Nucleo.Form
{
    public delegate void FormClose();

    /// <summary>
    /// StackForm.
    /// </summary>
    public class StackForm : System.Windows.Forms.Form
    {
        public event FormClose FormClosed;
        public ManualResetEvent threadRunning = new ManualResetEvent(false);
        private System.Windows.Forms.MainMenu mainMenu1;

        public StackForm()
        {
            this.Closing += new System.ComponentModel.CancelEventHandler(Form1_Closing);
        }

        public void Form1_Closing(Object sender, CancelEventArgs args)
        {
            this.Visible = false;
            args.Cancel = true;
            FormClosed();
        }

        public void LoadData()
        {
            Thread workerThread = new Thread(new ThreadStart(DataThread));

            // set out synchronization object
            threadRunning.Reset();

            // start the thread
            workerThread.Start();
        }

        public virtual void DataThread()
        {
            // overload this method if you need to load data but
            // you MUST call this base method to set this event
            threadRunning.Set();
        }

        public virtual void TratarDados()
        {
            // overload this method if you need to populate controls with data
            // retrieved in the data thread
        }

        public virtual void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            MenuFabrica.Construtor.Construir(this.mainMenu1);
            this.SuspendLayout();
            // 
            // StackForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Menu = this.mainMenu1;
            this.Name = "StackForm";
            this.ResumeLayout(false);

        }

        public virtual void Limpar()
        {
        }

        public virtual void Lembrar() 
        {
        }

    }

}
