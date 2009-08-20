/*
 *  VeículoZ é um aplicativo para gerenciamento de abastecimentos e despesas de veículos.
 *  Copyright (C) 2009  Marlon Silva Carvalho
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Negocio;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Negocio
{
    
    public class PostoNegocio:Midas.Nucleo.Negocio.NegocioGenerico
    {
        private EnderecoNegocio enderecoNegocio = new EnderecoNegocio();
        private PessoaJuridicaNegocio pessoaJuridicaNegocio = Midas.Nucleo.Negocio.NegocioFactory.Instancia.PessoaJuridicaNegocio;

        public PostoNegocio()
        {
            this.AcessoDados = new Midas.VeiculoZ.Dados.SQLServer.PostoDados();
        }

        public override void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Posto posto = (Posto)objeto;
            pessoaJuridicaNegocio.Salvar(posto.PessoaJuridica);
            base.Salvar(posto);
        }

        public override void Excluir(long id)
        {
            Posto posto = (Posto)this.Obter(id);
            pessoaJuridicaNegocio.Excluir(posto.PessoaJuridica.Id);
            base.Excluir(id);
        }

    }

}
