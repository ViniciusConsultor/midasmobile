﻿/*
 *  VeículoZ é um aplicativo para gerenciamento de abastecimentos e despesas
 *  de veículos.
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
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace Midas.VeiculoZ.Resolucao
{
    public sealed class CarregadorImagens
    {
        private CarregadorImagens() { }

        public static void ObterImagemCompativel(string imagem, PictureBox picture)
        {
            string diretorio = Ambiente.Instancia.ObterDiretorioImagensCompativeis();
            System.IO.Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Midas.VeiculoZ.Imagens." + diretorio + "." + imagem + ".png");
            if (stream == null)
            {
                stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Midas.VeiculoZ.Imagens._240x320." + imagem + ".png");
            }
            System.Drawing.Image img = new Bitmap(stream);
            picture.Image = img;
        }
    }
}
