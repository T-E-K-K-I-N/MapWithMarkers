namespace MapWithMarkers
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelYInfo = new System.Windows.Forms.Label();
            this.labelXInfo = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCreateMarker = new System.Windows.Forms.Button();
            this.textBoxYCreate = new System.Windows.Forms.TextBox();
            this.textBoxXCreate = new System.Windows.Forms.TextBox();
            this.labelYCreate = new System.Windows.Forms.Label();
            this.labelXCreate = new System.Windows.Forms.Label();
            this.checkBoxSaveMarkers = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gMap.CanDragMap = true;
            this.gMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gMap.GrayScaleMode = false;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(13, 13);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(431, 425);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDown);
            this.gMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            this.gMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelYInfo);
            this.groupBox1.Controls.Add(this.labelXInfo);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Location = new System.Drawing.Point(451, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущая позиция";
            // 
            // labelYInfo
            // 
            this.labelYInfo.AutoSize = true;
            this.labelYInfo.Location = new System.Drawing.Point(63, 47);
            this.labelYInfo.Name = "labelYInfo";
            this.labelYInfo.Size = new System.Drawing.Size(14, 13);
            this.labelYInfo.TabIndex = 3;
            this.labelYInfo.Text = "Y";
            // 
            // labelXInfo
            // 
            this.labelXInfo.AutoSize = true;
            this.labelXInfo.Location = new System.Drawing.Point(63, 20);
            this.labelXInfo.Name = "labelXInfo";
            this.labelXInfo.Size = new System.Drawing.Size(14, 13);
            this.labelXInfo.TabIndex = 2;
            this.labelXInfo.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(7, 47);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(50, 13);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Долгота";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(7, 20);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(48, 13);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Широта:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCreateMarker);
            this.groupBox2.Controls.Add(this.textBoxYCreate);
            this.groupBox2.Controls.Add(this.textBoxXCreate);
            this.groupBox2.Controls.Add(this.labelYCreate);
            this.groupBox2.Controls.Add(this.labelXCreate);
            this.groupBox2.Location = new System.Drawing.Point(451, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание маркера";
            // 
            // buttonCreateMarker
            // 
            this.buttonCreateMarker.Location = new System.Drawing.Point(9, 99);
            this.buttonCreateMarker.Name = "buttonCreateMarker";
            this.buttonCreateMarker.Size = new System.Drawing.Size(121, 23);
            this.buttonCreateMarker.TabIndex = 4;
            this.buttonCreateMarker.Text = "Создать маркер";
            this.buttonCreateMarker.UseVisualStyleBackColor = true;
            this.buttonCreateMarker.Click += new System.EventHandler(this.buttonCreateMarker_Click);
            // 
            // textBoxYCreate
            // 
            this.textBoxYCreate.Location = new System.Drawing.Point(66, 64);
            this.textBoxYCreate.Name = "textBoxYCreate";
            this.textBoxYCreate.Size = new System.Drawing.Size(64, 20);
            this.textBoxYCreate.TabIndex = 3;
            this.textBoxYCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYCreate_KeyPress);
            // 
            // textBoxXCreate
            // 
            this.textBoxXCreate.Location = new System.Drawing.Point(66, 38);
            this.textBoxXCreate.Name = "textBoxXCreate";
            this.textBoxXCreate.Size = new System.Drawing.Size(64, 20);
            this.textBoxXCreate.TabIndex = 2;
            this.textBoxXCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxXCreate_KeyPress);
            // 
            // labelYCreate
            // 
            this.labelYCreate.AutoSize = true;
            this.labelYCreate.Location = new System.Drawing.Point(7, 67);
            this.labelYCreate.Name = "labelYCreate";
            this.labelYCreate.Size = new System.Drawing.Size(53, 13);
            this.labelYCreate.TabIndex = 1;
            this.labelYCreate.Text = "Долгота:";
            // 
            // labelXCreate
            // 
            this.labelXCreate.AutoSize = true;
            this.labelXCreate.Location = new System.Drawing.Point(7, 41);
            this.labelXCreate.Name = "labelXCreate";
            this.labelXCreate.Size = new System.Drawing.Size(48, 13);
            this.labelXCreate.TabIndex = 0;
            this.labelXCreate.Text = "Широта:";
            // 
            // checkBoxSaveMarkers
            // 
            this.checkBoxSaveMarkers.AutoSize = true;
            this.checkBoxSaveMarkers.Checked = true;
            this.checkBoxSaveMarkers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSaveMarkers.Location = new System.Drawing.Point(450, 256);
            this.checkBoxSaveMarkers.Name = "checkBoxSaveMarkers";
            this.checkBoxSaveMarkers.Size = new System.Drawing.Size(138, 30);
            this.checkBoxSaveMarkers.TabIndex = 3;
            this.checkBoxSaveMarkers.Text = "Сохранять изменения\r\nна карте";
            this.checkBoxSaveMarkers.UseVisualStyleBackColor = true;
            this.checkBoxSaveMarkers.MouseEnter += new System.EventHandler(this.checkBoxSaveMarkers_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.checkBoxSaveMarkers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Map";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelYInfo;
        private System.Windows.Forms.Label labelXInfo;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreateMarker;
        private System.Windows.Forms.TextBox textBoxYCreate;
        private System.Windows.Forms.TextBox textBoxXCreate;
        private System.Windows.Forms.Label labelYCreate;
        private System.Windows.Forms.Label labelXCreate;
        private System.Windows.Forms.CheckBox checkBoxSaveMarkers;
    }
}

