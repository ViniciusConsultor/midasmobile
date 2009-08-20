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
using System.Windows.Forms;
using Midas.Nucleo.Form;
using Midas.VeiculoZ.Forms;
using System.Drawing;

namespace Midas.VeiculoZ
{
    static class Program
    {
        private static FormStack formStack = new FormStack();
        public static FormStack FormStack
        {
            get { return Program.formStack; }
            set { Program.formStack = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            // Chegar o tamanho da tela.
            Size tela = new Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width ,System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            if (! Ambiente.Instancia.ResolucaoSuportada(tela) )
            {
                MessageBox.Show("Esta versão do VeículoZ foi desenvolvida para rodar em dispositivos com as seguintes resoluções:" + Ambiente.Instancia.ObterResolucoesSuportadas(), "Atenção");
            }

            new Midas.Nucleo.Negocio.Carga().Iniciar();
            new VeiculoZ.Negocio.CargaVeiculoz().Iniciar();

            MenuFabrica.Construtor = new ConstrutorMenu();
            FormStackFactory.FormStack = formStack;

            formStack.Push(typeof(Forms.Inicio));
            try
            {
                formStack.Run();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Ocorreu um erro Crítico");
            }
        }
    }
}