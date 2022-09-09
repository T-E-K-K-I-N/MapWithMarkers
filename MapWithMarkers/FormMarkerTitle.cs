using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapWithMarkers
{
    public partial class FormMarkerTitle : Form
    {
        public FormMarkerTitle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переменная отвечающая за название маркера
        /// </summary>
        private string title = "";

        /// <summary>
        /// Переменная отвечающая за событие нажатия кнопки "Создание"
        /// </summary>
        private bool isCreateButtonPressed = false;

        /// <summary>
        /// Метод задающий или возвращающий данные о названии маркера
        /// </summary>
        public string GetMarkerTitle { get { return title; } private set { title = value;} }

        /// <summary>
        /// Метод задающий или возвращающий данные о событии нажатия на кнопку
        /// </summary>
        public bool IsCreateButtonPressed { get { return isCreateButtonPressed; } private set { isCreateButtonPressed = value; } } 


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxTitleMarker.Text)) || (string.IsNullOrWhiteSpace(textBoxTitleMarker.Text)))
            {
                MessageBox.Show("Введите название маркера!");
            }
            else
            {
                IsCreateButtonPressed = true;
                GetMarkerTitle = textBoxTitleMarker.Text;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IsCreateButtonPressed = false;
            Close();
        }

    }
}
