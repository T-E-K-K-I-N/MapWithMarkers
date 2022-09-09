using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Data.SqlClient;

namespace MapWithMarkers
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Строка подключения к БД
        /// </summary>
        private readonly string connectionString = "Server=(localdb)\\mssqllocaldb;Database=MarkersOnMap;Trusted_Connection=True;";

        /// <summary>
        /// Объект подключения к БД
        /// </summary>
        SqlConnection connection;

        /// <summary>
        /// Объект SQL-команды
        /// </summary>
        SqlCommand command;

        /// <summary>
        /// Объект слоя маркеров
        /// </summary>
        private GMapOverlay markersOverlay;

        /// <summary>
        /// Объект выбранного маркера
        /// </summary>
        private GMapMarkerGoogleRed currentMarker;

        /// <summary>
        /// Объект маркера
        /// </summary>
        private GMapMarkerGoogleRed marker;

        /// <summary>
        /// Переменная состояния нажатия ЛКМ
        /// </summary>
        private bool isLeftButtonDown = false;

        /// <summary>
        /// Переменная состояния нажатия СКМ
        /// </summary>
        private bool isMiddleButtonDown = false;


        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; // выбор подгрузки карты – онлайн или из ресурсов

            gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; // какой провайдер карт используется (в нашем случае гугл) 

            gMap.MinZoom = 2; //минимальный зум

            gMap.MaxZoom = 18; //максимальный зум

            gMap.Zoom = 6; // какой используется зум при открытии

            gMap.Position = new GMap.NET.PointLatLng(55, 83);// точка в центре карты при открытии (Новосибирск)

            gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter; // как приближает (просто в центр карты или по положению мыши)

            gMap.CanDragMap = true; // перетаскивание карты мышью

            gMap.DragButton = MouseButtons.Right; // какой кнопкой осуществляется перетаскивание

            gMap.ShowTileGridLines = false; // показывать или скрывать тайлы

            gMap.MarkersEnabled = true; // показывать маркеры (созданные в ручную)

            markersOverlay = new GMapOverlay(gMap, "Markers");

            markersOverlay.Markers.Clear();

            gMap.Overlays.Clear();

            connection = new SqlConnection(connectionString);
           
            using(connection)
            {
                connection.Open();
                command = new SqlCommand();

                command.CommandText = "SELECT * FROM Markers;";
                command.Connection = connection;
                SqlDataReader SQL = command.ExecuteReader();

                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        double x = Convert.ToDouble(SQL.GetValue(2));
                        double y = Convert.ToDouble(SQL.GetValue(3));
                        marker = new GMapMarkerGoogleRed(new PointLatLng(x, y));

                        string text = Convert.ToString(SQL.GetValue(1));
                        marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                        marker.ToolTipText = text;

                        markersOverlay.Markers.Add(marker);
                    }
                }
                gMap.Overlays.Add(markersOverlay);
            }
        }

        private void buttonCreateMarker_Click(object sender, EventArgs e)
        {

            if (textBoxXCreate.Text != "" && textBoxYCreate.Text != "")
            {
                double x = Convert.ToDouble(textBoxXCreate.Text);
                double y = Convert.ToDouble(textBoxYCreate.Text);

                CreateMarker(x, y);
            }
            else
            {
                CreateMarker(gMap.Position.Lat, gMap.Position.Lng);
            }

        }

        /// <summary>
        /// Вывод информации о текущей позиции (Курсор), перемещение маркера
        /// </summary>
        private void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = gMap.FromLocalToLatLng(e.X, e.Y);

            string x = string.Format("{0:f4}", point.Lat);
            string y = string.Format("{0:f4}", point.Lng);

            labelXInfo.Text = x;
            labelYInfo.Text = y;

            if (currentMarker != null)
            {
                if (e.Button == MouseButtons.Left && isLeftButtonDown)
                {
                    currentMarker.Position = point;
                }
            }

        }

        /// <summary>
        /// Отключаем возможность вводить в текстбоксы все, кроме чисел и знака ","
        /// </summary>
        private void textBoxXCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= 47 || e.KeyChar >= 58) ||
                (e.KeyChar == '\b') || (e.KeyChar == 44))
            {
                return;
            }
            else { e.Handled = true; }
        }

        private void textBoxYCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= 47 || e.KeyChar >= 58) ||
                (e.KeyChar == '\b') || (e.KeyChar == 44))
            {
                return;
            }
            else { e.Handled = true; }
        }


        /// <summary>
        /// Проверка на нажатие кнопки мыши, проверка на то, какой маркер был выбран
        /// </summary>
        private void gMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { isLeftButtonDown = true; }
            if (e.Button == MouseButtons.Middle) { isMiddleButtonDown = true; }

            currentMarker = (GMapMarkerGoogleRed)gMap.Overlays
            .SelectMany(o => o.Markers)
            .FirstOrDefault(m => m.IsMouseOver == true);

            // Удаляем маркер, если была нажата СКМ
            if (isMiddleButtonDown)
            {
                markersOverlay.Markers.Remove(currentMarker);
            }
        }

        /// <summary>
        /// Проверка на нажатие кнопки мыши
        /// </summary>
        private void gMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { isLeftButtonDown = false; }
            if (e.Button == MouseButtons.Middle) { isMiddleButtonDown = false; }
        }

        /// <summary>
        /// Сохранение маркеров в базу, после закрытия приложения
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection = new SqlConnection(connectionString);
            using (connection)
            {
                connection.Open();
                command = new SqlCommand();
                command.CommandText = "DBCC CHECKIDENT ('dbo.Markers', RESEED, 0);";
                command.Connection = connection;
                command.ExecuteNonQuery();

                if (checkBoxSaveMarkers.Checked is true)
                {

                    command.CommandText = "DELETE FROM Markers;";
                    command.ExecuteNonQuery();

                    foreach (var marker in markersOverlay.Markers)
                    {
                        command.Parameters.AddWithValue("@ToolTipText", marker.ToolTipText);
                        command.Parameters.AddWithValue("@X", marker.Position.Lat);
                        command.Parameters.AddWithValue("@Y", marker.Position.Lng);

                        command.CommandText = "INSERT INTO Markers (MarkerName, СoordinateX, СoordinateY) VALUES (@ToolTipText, @X, @Y);";
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }

                }
                connection.Close();
            }
        }

        private void checkBoxSaveMarkers_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(checkBoxSaveMarkers, "Сохранение всех изменений, связанных с маркерами (положение, добавленные / удаленные маркера)");
        }

        private void CreateMarker(double x, double y)
        {
            marker = new GMapMarkerGoogleRed(new PointLatLng(x, y));

            marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
            FormMarkerTitle formMarkerTitle = new FormMarkerTitle();
            formMarkerTitle.ShowDialog();

            if (formMarkerTitle.IsCreateButtonPressed is true)
            {
                marker.ToolTipText = formMarkerTitle.GetMarkerTitle;
                markersOverlay.Markers.Add(marker);
            }
            else
            {
                return;
            }
        }
    }
}
