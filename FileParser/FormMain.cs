﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZedGraph;
using JsonParser;

namespace FileParser
{
    public partial class FormMain : Form
    {
        private Welcome wl;

        private List<Color> color = new List<Color>();
        public FormMain()
        {
            InitializeComponent();

            color.Add(Color.Red);
            color.Add(Color.Orange);
            color.Add(Color.LimeGreen);
            color.Add(Color.ForestGreen);
            color.Add(Color.LightBlue);
            color.Add(Color.Blue);
            color.Add(Color.Violet);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitColors(zedGraphControl1, "  ", "us", "dB");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            
            if (res != DialogResult.OK)
                return;

            string readFile = openFileDialog.FileName;
            string writeFile = readFile.Substring(0, readFile.LastIndexOf('.')) + ".dat";

            StreamReader reader = new StreamReader(readFile);
            StreamWriter writer = new StreamWriter(writeFile, false, Encoding.ASCII);

            try
            {
                while(true)
                {
                    string bob = reader.ReadLine();
                    if (bob.Substring(0, 3) != ",,,")
                        continue;
                    if (bob.Substring(0, 4) == ",,, ")
                        continue;

                    bob = bob.Substring(3, bob.Length - 3);

                    bob = bob.Replace(",", ";");
                    bob = bob.Replace(".", ",");


                    double X = double.Parse(bob.Substring(0, bob.IndexOf(";")));
                    double Y = double.Parse(bob.Substring(bob.IndexOf(";") + 1, bob.LastIndexOf(";") - 1 -  bob.IndexOf(";")));
                    
                    writer.WriteLine((Y.ToString()).Replace(",",".") + ";" + (Y.ToString()).Replace(",", ".") + ";");
                }
            }
            catch (Exception ex)
            {

            }

            reader.Close();
            writer.Close();

        }

        private void InitColors(ZedGraphControl graphControl, string title, string xTitle, string yTitle)//, double shift)
        {
            GraphPane pane = graphControl.GraphPane;
            // !!!
            // Установим цвет рамки для всего компонента
            pane.Border.Color = Color.DarkGray;

            // Установим цвет рамки вокруг графика
            pane.Chart.Border.Color = Color.Green;

            // Закрасим фон всего компонента ZedGraph
            // Заливка будет сплошная
            pane.Fill.Type = FillType.Solid;
            pane.Fill.Color = Color.WhiteSmoke;

            // Закрасим область графика (его фон) 
            pane.Chart.Fill.Type = FillType.Solid;
            pane.Chart.Fill.Color = Color.WhiteSmoke;

            // Включим показ оси на уровне X = 0 и Y = 0, чтобы видеть цвет осей
            pane.XAxis.MajorGrid.IsZeroLine = true;
            pane.YAxis.MajorGrid.IsZeroLine = true;
            // Установим цвет осей
            pane.XAxis.Color = Color.Gray;
            pane.YAxis.Color = Color.Gray;

            // Включим сетку
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            // Установим цвет для сетки
            pane.XAxis.MajorGrid.Color = Color.DarkGreen;
            pane.YAxis.MajorGrid.Color = Color.DarkGreen;

            // Установим цвет для подписей рядом с осями
            pane.XAxis.Title.FontSpec.Family = "Courier";
            pane.YAxis.Title.FontSpec.Family = "Courier";
            pane.XAxis.Title.FontSpec.FontColor = Color.DarkGreen;
            pane.YAxis.Title.FontSpec.FontColor = Color.DarkGreen;

            // Установим цвет подписей под метками
            pane.XAxis.Scale.FontSpec.Family = "Courier";
            pane.XAxis.Scale.FontSpec.Size = 18;
            pane.YAxis.Scale.FontSpec.Family = "Courier";
            pane.YAxis.Scale.FontSpec.Size = 18;
            pane.XAxis.Scale.FontSpec.FontColor = Color.DarkGreen;
            pane.YAxis.Scale.FontSpec.FontColor = Color.DarkGreen;

            // Установим цвет заголовка над графиком
            pane.Title.FontSpec.FontColor = Color.DarkGreen;
            pane.Title.Text = title;
            pane.Tag = title;
            pane.Legend.IsVisible = true;


            if (String.IsNullOrEmpty(yTitle))
                pane.YAxis.Title.Text = "";
            else
                pane.YAxis.Title.Text = yTitle;

            if (String.IsNullOrEmpty(xTitle))
                pane.XAxis.Title.Text = "";
            else
                pane.XAxis.Title.Text = xTitle;

            //pane.YAxis.Scale.Min = controls.ScopeMinY;
            //pane.YAxis.Scale.Max = controls.ScopeMaxY;
            //pane.XAxis.Scale.Min = controls.ScopeMinX * board.Divider * 0.01;
            //pane.XAxis.Scale.Max = controls.ScopeMaxX * board.Divider * 0.01;

            pane.YAxis.Scale.MajorStepAuto = true;
            pane.XAxis.Scale.MajorStepAuto = true;
            pane.YAxis.Scale.MinorStepAuto = true;
            pane.XAxis.Scale.MinorStepAuto = true;
            pane.AxisChange();
            //pane.YAxis.Scale.MinorStepAuto = false;
            graphControl.Invalidate();
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wl = null;

            if (zedGraphControl1.GraphPane.CurveList.Count == 0)
                return;

            DialogResult res = MessageBox.Show("Are you sure?", "Clean the plot", MessageBoxButtons.OKCancel);

            if (res != DialogResult.OK)
                return;

            zedGraphControl1.GraphPane.CurveList.Clear();

            zedGraphControl1.Invalidate();

        }

        private void matLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open MatLab *.txt file";
            DialogResult res = openFileDialog.ShowDialog();

            if (res != DialogResult.OK)
                return;

            PointPairList pointsOld = new PointPairList();
            PointPairList pointsNew = new PointPairList();
            int pointer = 0;

            string readFile = openFileDialog.FileName;
            string fileName = readFile.Substring(readFile.LastIndexOf('\\') + 1, readFile.Length - readFile.LastIndexOf('\\') - 1);

            {
                LineItem myCurve = zedGraphControl1.GraphPane.AddCurve(fileName,
                                                                   pointsNew,
                                                                   color[zedGraphControl1.GraphPane.CurveList.Count % color.Count],
                                                                   SymbolType.None);

            }

            StreamReader reader = new StreamReader(readFile);

            try
            {
                while (true)
                {
                    string bob = reader.ReadLine();

                    bob = bob.Replace(".", ",");

                    double X = 0.01 * pointer++;
                    double Y = double.Parse(bob);

                    pointsOld.Add(new PointPair(X, Y));
                }
            }
            catch (Exception ex)
            {

            }

            // Поиск огибающей
            pointer = 0;

            while (pointer < pointsOld.Count - 2)
            {
                if (pointsOld[pointer + 1].Y > pointsOld[pointer].Y &
                    pointsOld[pointer + 1].Y > pointsOld[pointer + 2].Y)
                {
                    pointsNew.Add(new PointPair(pointsOld[pointer + 1].X, pointsOld[pointer + 1].Y));
                    pointer += 2;
                }
                else
                {
                    pointer += 1;
                }
            }
            // Удаление лишних точек

            double max = double.MinValue;
            int maxi = 0;

            for (int i = pointsNew.Count; i > 0; i--)
                if (pointsNew[i - 1].Y == 0)
                {
                    pointsNew.RemoveRange(i, pointsNew.Count - i);
                    break;
                }
            for (int i = 0; i < pointsNew.Count; i++)
                if (pointsNew[i].Y > max)
                {
                    max = pointsNew[i].Y;
                    maxi = i;
                }

            pointsNew.RemoveRange(0, maxi);

            for (int i = pointsNew.Count; i > 0; i--)
                pointsNew[i - 1].X -= pointsNew[0].X;



            reader.Close();

            zedGraphControl1.GraphPane.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void cassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open Cassiopeia *.cass file";
            DialogResult res = openFileDialog.ShowDialog();

            if (res != DialogResult.OK)
                return;


            string fileName = openFileDialog.FileName;

            Welcome wl = Welcome.FromJson(fileName);

            DrawCass(wl);
        }

        private void DrawCass(Welcome wl)
        {
            zedGraphControl1.GraphPane.CurveList.Clear();

            PointPairList pointsAscan = new PointPairList();
            PointPairList pointsThreshold = new PointPairList();


            {
                LineItem myCurve = zedGraphControl1.GraphPane.AddCurve("",
                                                                   pointsAscan,
                                                                   Color.DarkBlue,
                                                                   SymbolType.None);

                myCurve = zedGraphControl1.GraphPane.AddCurve("",
                                                                   pointsThreshold,
                                                                   Color.Blue,
                                                                   SymbolType.None);
            }

           // for (int i = 0; )

            zedGraphControl1.GraphPane.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
}
