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

namespace Midas.VeiculoZ.Negocio
{

    public sealed class NegocioFactory
    {

        private static NegocioFactory instancia = new NegocioFactory();
        public static NegocioFactory Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        private TipoCombustivelNegocio tipoCombustivelNegocio;
        public TipoCombustivelNegocio TipoCombustivelNegocio
        {
            get 
            {
                if (tipoCombustivelNegocio == null)
                {
                    tipoCombustivelNegocio = new TipoCombustivelNegocio();
                }
                return tipoCombustivelNegocio; 
            }
            set { tipoCombustivelNegocio = value; }
        }

        private VeiculosNegocio veiculoNegocio;
        public VeiculosNegocio VeiculoNegocio
        {
            get 
            {
                if (veiculoNegocio == null)
                {
                    veiculoNegocio = new VeiculosNegocio();
                }
                return veiculoNegocio; 
            }
            set { veiculoNegocio = value; }
        }

        private PostoNegocio postoNegocio;
        public PostoNegocio PostoNegocio
        {
            get 
            {
                if (postoNegocio == null)
                {
                    postoNegocio = new PostoNegocio();
                }
                return postoNegocio; 
            }
            set { postoNegocio = value; }
        }

        private DistribuidoraNegocio distribuidoraNegocio;
        public DistribuidoraNegocio DistribuidoraNegocio
        {
            get 
            {
                if (distribuidoraNegocio == null)
                {
                    distribuidoraNegocio = new DistribuidoraNegocio();
                }
                return distribuidoraNegocio; 
            }
            set { distribuidoraNegocio = value; }
        }

        private PercursoNegocio percursoNegocio;
        public PercursoNegocio PercursoNegocio
        {
            get 
            {
                if (percursoNegocio == null)
                {
                    percursoNegocio = new PercursoNegocio();
                }
                return percursoNegocio; 
            }
            set { percursoNegocio = value; }
        }

        private AbastecimentoNegocio abastecimentoNegocio;
        public AbastecimentoNegocio AbastecimentoNegocio
        {
            get 
            {
                if (abastecimentoNegocio == null)
                {
                    abastecimentoNegocio = new AbastecimentoNegocio();
                }
                return abastecimentoNegocio; 
            }
            set { abastecimentoNegocio = value; }
        }

        private TipoDespesaNegocio tipoDespesaNegocio;
        public TipoDespesaNegocio TipoDespesaNegocio
        {
            get 
            {
                if (tipoDespesaNegocio == null)
                {
                    tipoDespesaNegocio = new TipoDespesaNegocio();
                }
                return tipoDespesaNegocio; 
            }
            set { tipoDespesaNegocio = value; }
        }

        private DespesaNegocio despesaNegocio;
        public DespesaNegocio DespesaNegocio
        {
            get 
            {
                if (despesaNegocio == null)
                {
                    despesaNegocio = new DespesaNegocio();
                }
                return despesaNegocio; 
            }
            set { despesaNegocio = value; }
        }

        private ManutencaoNegocio manutencaoNegocio;
        public ManutencaoNegocio ManutencaoNegocio
        {
            get 
            {
                if (manutencaoNegocio == null)
                {
                    manutencaoNegocio = new ManutencaoNegocio();
                }
                return manutencaoNegocio; 
            }
            set { manutencaoNegocio = value; }
        }

        private MotoristaNegocio motoristaNegocio;
        public MotoristaNegocio MotoristaNegocio
        {
            get 
            {
                if (motoristaNegocio == null)
                {
                    motoristaNegocio = new MotoristaNegocio();
                }
                return motoristaNegocio; 
            }
            set { motoristaNegocio = value; }
        }

        private ClassificacaoInfracaoNegocio classificacaoInfracaoNegocio;
        public ClassificacaoInfracaoNegocio ClassificacaoInfracaoNegocio
        {
            get
            {
                if (classificacaoInfracaoNegocio == null)
                {
                    classificacaoInfracaoNegocio = new ClassificacaoInfracaoNegocio();
                }
                return classificacaoInfracaoNegocio;
            }
            set { classificacaoInfracaoNegocio = value; }
        }

        private InfracaoNegocio infracaoNegocio;
        public InfracaoNegocio InfracaoNegocio
        {
            get
            {
                if (infracaoNegocio == null)
                {
                    infracaoNegocio = new InfracaoNegocio();
                }
                return infracaoNegocio;
            }
            set { infracaoNegocio = value; }
        }

        private SituacaoMultaNegocio situacaoMultaNegocio;
        public SituacaoMultaNegocio SituacaoMultaNegocio
        {
            get
            {
                if (situacaoMultaNegocio == null)
                {
                    situacaoMultaNegocio = new SituacaoMultaNegocio();
                }
                return situacaoMultaNegocio;
            }
            set { situacaoMultaNegocio = value; }
        }

        private MultaNegocio multaNegocio;
        public MultaNegocio MultaNegocio
        {
            get
            {
                if (multaNegocio == null)
                {
                    multaNegocio = new MultaNegocio();
                }
                return multaNegocio;
            }
            set { multaNegocio = value; }
        }

    }


}
