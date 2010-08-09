using System;
using System.ComponentModel;
using System.Threading;
using Midas.Nucleo.Validador;
using System.Windows.Forms;
using System.Collections;

namespace Midas.Nucleo.Form
{

    public class ListForm : StackForm
    {
        
        // all derived classes must call this custructor!
        public ListForm()
        {
        }

        public void Excluir(DataGrid dataGrid, IList lista)
        {
            if ( dataGrid.CurrentRowIndex < 0 )
            {
                return;
            }
            if (MessageBox.Show("Confirma Exclusão?", "Confirmação", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Objetos.ObjetoNegocio objeto = (Objetos.ObjetoNegocio)lista[dataGrid.CurrentRowIndex];
                if (objeto != null)
                {
                    try
                    {
                        DoExcluir(objeto.Id);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não é permitido excluir este registro, pois há outros cadastros que o referenciam.", "Erro");
                    }
                }
            }
        }

        public virtual void DoExcluir(long id)
        {
        }

    }

}
