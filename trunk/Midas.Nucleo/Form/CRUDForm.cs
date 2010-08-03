using System;
using System.ComponentModel;
using System.Threading;
using Midas.Nucleo.Validador;
using System.Windows.Forms;

namespace Midas.Nucleo.Form
{

    public class CRUDForm : StackForm
    {
        private IValidador validador;
        public IValidador Validador
        {
            get { return validador; }
            set { validador = value; }
        }

        // all derived classes must call this custructor!
        public CRUDForm()
        {
        }

        public void Salvar()
        {
            Objetos.ObjetoNegocio objeto = this.ConstruirObjeto();
            if (this.Validador != null)
            {
                Validacao validacao = this.validador.Validar(objeto);
                if (validacao.Passou)
                {
                    try
                    {
                        this.DoSalvar(objeto);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Erro");
                        return;
                    }
                    MessageBox.Show("Dados armazenados com sucesso.", "Sucesso");
                }
                else
                {
                    MessageBox.Show(validacao.Mensagem, "Erro");
                }
            }
            else
            {
                MessageBox.Show("Informe o Validador", "Erro");
            }
        }

        public void Excluir(string id)
        {
            if (MessageBox.Show("Confirma Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (id != "" && id != null)
                {
                    long oid = Int32.Parse(id);
                    try
                    {
                        DoExcluir(oid);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não é permitido excluir este registro, pois há outros cadastros que o referenciam." , "Erro");
                        return;
                    }
                    MessageBox.Show("Dados excluídos com sucesso.", "Sucesso");
                    FormStackFactory.FormStack.Pop(1);
                }
            }
        }

        public virtual void DoSalvar(Objetos.ObjetoNegocio objeto)
        {
        }

        public virtual Objetos.ObjetoNegocio ConstruirObjeto()
        {
            return null;
        }

        public virtual void DoExcluir(long id)
        {
        }

    }

}
