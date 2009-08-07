/*
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manco.Chart.CF.Layout;
using Manco.Chart.CF.Data;
using Manco.Chart.CF.Shapes;
using Midas.Nucleo.Form;
using System.Collections;
using Midas.VeiculoZ.Objetos;
using Midas.VeiculoZ.Resolucao;

namespace Midas.VeiculoZ.Forms
{
    public partial class GraficoDespesas: StackForm
    {
        private ChartSettings m_oChart;
        private bool ok = false;

        static GraficoDespesas()
        {
            Manco.Chart.CF.ChartControl.LicenseAssembly = typeof(GraficoDespesas).Assembly;
            Manco.Chart.CF.ChartControl.UnlockKey = "MCEE14-74AA-EA15-1B78-E44A-940C-A319-6D2E-FBAB-9AF6-1156-057E-53E4-54B8-2092-DD98-6448-892F-4DCE-6D42-BF6B-3318-2A1F-DC11-D56A-3BCF";
        }

        public GraficoDespesas()
        {
            InitializeComponent();
            CarregadorImagens.ObterImagemCompativel("Logo", pLogo);
        }

		private void ChartFromArrayExample_Load(object sender, EventArgs e)
		{
		}

        private void Carregar()
        {
            this.m_ChartControl.Charts.Clear();
            PrepareChart();
            m_ChartControl.Draw();
            ok = true;
        }

		/// <summary>
		/// Prepares chart
		/// </summary>
		private void PrepareChart()
		{

			// suspend chart specific events
			m_ChartControl.SuspendChartLayout();

			// configure layout, title and footer
			ConfigureControlLayout();
			CreateTitle();
			CreateFooter();

			// setup chart to bar type
			m_oChart = m_ChartControl.Charts[0];
			m_oChart.ChartType = ChartType.Bar;

			// configure chart, chart legend and value axis properties
			ConfigureChart();
			CreateChartLegend();
			CreateValueAxis();

			// configure chart categories
			ConfigureCategories();

			// generate sample data
			m_oChart.Data = GenareteData();

			// configure chart series list
			ConfigureSeriesList();

			// resume chart layout without chart drawing
			m_ChartControl.ResumeChartLayout(false);
		}

        public override void TratarDados()
        {
            this.Carregar();
        }

		/// <summary>
		/// Generates data for the sample
		/// </summary>
		/// <returns></returns>
        private ArrayDataSource GenareteData()
        {
            IList percursos = GerenciadorDados.Instancia.GetLista();
            double[,] loDataArray = new double[percursos.Count-1, 1];
            for (int j = 0; j < percursos.Count; j++)
            {
                Percurso percurso = (Percurso)percursos[j];
                if (percurso.ConsumoMedio > 0)
                {
                    loDataArray[j, 0] = percurso.ConsumoMedio;
                }
            }
            return new ArrayDataSource(loDataArray, DataOrientation.CategoryInRow);
        }

		/// <summary>
		/// Configures layout of the control
		/// </summary>
        private void ConfigureControlLayout()
        {
            m_ChartControl.Charts.ControlLayout.Color = Color.White;
            m_ChartControl.Charts.ControlLayout.BorderColor = Color.Transparent;
            m_ChartControl.Charts.ControlLayout.BorderWidth = 1;
            m_ChartControl.Charts.ControlLayout.RadiusX = 20;
            m_ChartControl.Charts.ControlLayout.RadiusY = 20;
        }

		/// <summary>
		/// Creates title of chart
		/// </summary>
		private void CreateTitle()
		{
            if (!ok)
            {
                m_ChartControl.Charts.ControlLayout.Titles.Distance = 5;
                FormattedData title = m_ChartControl.Charts.ControlLayout.Titles.CreateTitle();
                title.Data = "Gráfico de Consumo Médio";
                title.Font.Size = 12;
                title.Font.Bold = true;
                title.Color = Color.Transparent;
                title.BorderColor = Color.Transparent;
                title.BorderWidth = 1;
                title.Foreground = Color.Black;
            }
		}

		/// <summary>
		/// Creates footer
		/// </summary>
		private void CreateFooter()
		{
            if (!ok)
            {
                m_ChartControl.Charts.ControlLayout.Footers.Distance = 5;

                FormattedData title = m_ChartControl.Charts.ControlLayout.Footers.CreateTitle();
                title.Data = "VeículoZ";
                title.Font.Size = 11;
                title.Font.Bold = true;
                title.Color = Color.Transparent;
                title.BorderColor = Color.Transparent;
                title.BorderWidth = 1;
                title.Foreground = Color.Transparent;
            }
		}

		/// <summary>
		/// Configures the chart
		/// </summary>
		private void ConfigureChart()
		{
			m_oChart.Color = Color.Transparent;
			m_oChart.Location.X = 0;
			m_oChart.Location.Y = 0;
			m_oChart.Size.Width = 100;
			m_oChart.Size.Height = 100;
		}

		/// <summary>
		/// Creates chart legend
		/// </summary>
		private void CreateChartLegend()
		{
			m_oChart.Legend.Placement = LegendPlacement.TopCenter;
			m_oChart.Legend.Format = "{0}";
			m_oChart.Legend.Font.Size = 10;
			m_oChart.Legend.BorderColor = Color.LightGray;
			m_oChart.Legend.BorderWidth = 1;
			m_oChart.Legend.RadiusX = 5;
			m_oChart.Legend.RadiusY = 5;
			m_oChart.Legend.Foreground = Color.Black;
		}

		/// <summary>
		/// Creates value axis
		/// </summary>
		private void CreateValueAxis()
		{
			ValueAxis axis = m_oChart.ValueAxisList.CreateValueAxis();
			axis.Title.Data = "Consumo";
			axis.Title.Font.Size = 14;
			axis.Title.Foreground = Color.Black;
			axis.Title.Font.Bold = true;
			axis.Title.Alignment = TextAlignment.Center;
			axis.Label.Format = "{0:F1}";
			axis.Label.Foreground = Color.Black;
			axis.Label.Rotation = 0;
			axis.Thickness = 1;
			axis.Color = Color.LightGray;
			axis.MajorTicks = 5;
			axis.MinorTicks = 2;
			axis.MinorTick.Length = 2;
			axis.ZeroLine.Color = Color.Violet;
			axis.ZeroLine.Thickness = 2;

			ChartTypeProperties loChartProps = new ChartTypeProperties(m_oChart.ChartType);
			axis.Orientation = (loChartProps.IsVerticalValue ?
				Manco.Chart.CF.Layout.Orientation.Vertical :
				Manco.Chart.CF.Layout.Orientation.Horizontal);
			axis.Alignment = (loChartProps.IsVerticalValue ?
				AxisAlignment.Left :
				AxisAlignment.Right);
		}

		/// <summary>
		/// Configures categories
		/// </summary>
		private void ConfigureCategories()
		{
            m_oChart.Element.ShowValues = true;
            m_oChart.Element.Label.Format = "{0:F2}";
            m_oChart.Element.Label.Rotation = 0;
            m_oChart.Element.Label.Foreground = Color.Black;
            m_oChart.Element.Gap = 0;
		}

		/// <summary>
		/// Configures series list
		/// </summary>
		private void ConfigureSeriesList()
		{
			m_oChart.SeriesList.Title.Foreground = Color.Transparent;
            m_oChart.SeriesList.Title.BorderColor = Color.Transparent;
            m_oChart.SeriesList[0].Fill.Color = Color.Blue;
            m_oChart.SeriesList[0].Title = "Consumo Médio";
            m_oChart.SeriesList[0].Shape = ShapeType.Pie;
 			for (int i = 0; i < m_oChart.SeriesList.Count; i++)
			{
				m_oChart.SeriesList[i].Fill.BorderColor = Color.Black;
				m_oChart.SeriesList[i].Fill.BorderWidth = 1;
			}   
		}
	}
 
}