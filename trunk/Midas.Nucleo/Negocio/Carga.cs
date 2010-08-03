using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.Nucleo.Recursos;
using Midas.Nucleo.Objetos;

namespace Midas.Nucleo.Negocio
{
    public class Carga:ICargaSistema
    {
        #region ICargaSistema Members

        public void Iniciar()
        {
            SQLServerCE servidor = new SQLServerCE(Recursos.ConstantesGerais.BancoNucleo);
            if (!servidor.BancoExiste())
            {
                servidor.CriarBancoDados();
                this.IniciarTabelas();
                this.CriarDadosIniciais();
            }
        }

        private void IniciarTabelas()
        {
            new Comando(Recursos.ConstantesDados.TabelaPessoaJuridica, ConstantesGerais.BancoNucleo).Executar();
            new Comando(Recursos.ConstantesDados.TabelaPais, ConstantesGerais.BancoNucleo).Executar();
            new Comando(Recursos.ConstantesDados.TabelaEstado, ConstantesGerais.BancoNucleo).Executar();
            new Comando(Recursos.ConstantesDados.TabelaCidade, ConstantesGerais.BancoNucleo).Executar();
            new Comando(Recursos.ConstantesDados.TabelaEndereco, ConstantesGerais.BancoNucleo).Executar();
        }

        private void CriarDadosIniciais()
        {
            Pais brasil = new Pais();
            brasil.Nome = "Brasil";
            NegocioFactory.Instancia.PaisNegocio.Salvar(brasil);

            Estado estado = new Estado();
            estado.Nome = "Acre";
            estado.Sigla = "AC";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Alagoas";
            estado.Sigla = "AL";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Amapá";
            estado.Sigla = "AP";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Amazonas";
            estado.Sigla = "AM";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Bahia";
            estado.Sigla = "BA";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Ceará";
            estado.Sigla = "CE";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Distrito Federal";
            estado.Sigla = "DF";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Espírito Santo";
            estado.Sigla = "ES";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Goiás";
            estado.Sigla = "GO";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Maranhão";
            estado.Sigla = "MA";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Mato Grosso";
            estado.Sigla = "MT";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Mato Grosso do Sul";
            estado.Sigla = "MS";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Minas Gerais";
            estado.Sigla = "MG";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Pará";
            estado.Sigla = "PA";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Paraíba";
            estado.Sigla = "PB";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Paraná";
            estado.Sigla = "PR";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Pernambuco";
            estado.Sigla = "PE";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Piauí";
            estado.Sigla = "PI";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Rio de Janeiro";
            estado.Sigla = "RJ";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Rio Grande do Norte";
            estado.Sigla = "RN";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Rio Grande do Sul";
            estado.Sigla = "RS";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Rondônia";
            estado.Sigla = "RO";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Roraima";
            estado.Sigla = "RR";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Santa Catarina";
            estado.Sigla = "SC";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "São Paulo";
            estado.Sigla = "SP";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Sergipe";
            estado.Sigla = "SE";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);

            estado = new Estado();
            estado.Nome = "Tocantins";
            estado.Sigla = "TO";
            estado.Pais = brasil;
            NegocioFactory.Instancia.EstadoNegocio.Salvar(estado);
        }

        #endregion
    }
}
