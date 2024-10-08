﻿namespace lab_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            drawArea = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            unpuaseButton = new Button();
            pauseButton = new Button();
            simulationButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            outCenterButton = new Button();
            inCenterButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            trackCheckBox = new CheckBox();
            spawnButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            starCountTextBox = new TextBox();
            speedTrackBar = new TrackBar();
            maxStarSizeTextBox = new TextBox();
            minStarSizeTextBox = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drawArea).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(drawArea, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            tableLayoutPanel1.Size = new Size(1143, 750);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // drawArea
            // 
            tableLayoutPanel1.SetColumnSpan(drawArea, 3);
            drawArea.Dock = DockStyle.Fill;
            drawArea.Location = new Point(4, 5);
            drawArea.Margin = new Padding(4, 5, 4, 5);
            drawArea.Name = "drawArea";
            drawArea.Size = new Size(1135, 407);
            drawArea.TabIndex = 0;
            drawArea.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Controls.Add(unpuaseButton, 0, 2);
            tableLayoutPanel2.Controls.Add(pauseButton, 0, 1);
            tableLayoutPanel2.Controls.Add(simulationButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(769, 425);
            tableLayoutPanel2.Margin = new Padding(7, 8, 7, 8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(367, 317);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // unpuaseButton
            // 
            unpuaseButton.Dock = DockStyle.Fill;
            unpuaseButton.Location = new Point(4, 215);
            unpuaseButton.Margin = new Padding(4, 5, 4, 5);
            unpuaseButton.Name = "unpuaseButton";
            unpuaseButton.Size = new Size(359, 97);
            unpuaseButton.TabIndex = 2;
            unpuaseButton.Text = "Продолжить";
            unpuaseButton.UseVisualStyleBackColor = true;
            unpuaseButton.Click += OnResumeClick;
            // 
            // pauseButton
            // 
            pauseButton.Dock = DockStyle.Fill;
            pauseButton.Location = new Point(4, 110);
            pauseButton.Margin = new Padding(4, 5, 4, 5);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(359, 95);
            pauseButton.TabIndex = 1;
            pauseButton.Text = "Пауза";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += OnPauseClick;
            // 
            // simulationButton
            // 
            simulationButton.Dock = DockStyle.Fill;
            simulationButton.Location = new Point(4, 5);
            simulationButton.Margin = new Padding(4, 5, 4, 5);
            simulationButton.Name = "simulationButton";
            simulationButton.Size = new Size(359, 95);
            simulationButton.TabIndex = 0;
            simulationButton.Text = "Симуляция";
            simulationButton.UseVisualStyleBackColor = true;
            simulationButton.Click += OnSimulationClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.Controls.Add(outCenterButton, 0, 1);
            tableLayoutPanel3.Controls.Add(inCenterButton, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Controls.Add(spawnButton, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(390, 427);
            tableLayoutPanel3.Margin = new Padding(9, 10, 9, 10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(363, 313);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // outCenterButton
            // 
            outCenterButton.Dock = DockStyle.Fill;
            outCenterButton.Location = new Point(4, 83);
            outCenterButton.Margin = new Padding(4, 5, 4, 5);
            outCenterButton.Name = "outCenterButton";
            outCenterButton.Size = new Size(355, 68);
            outCenterButton.TabIndex = 1;
            outCenterButton.Text = "Расхождение звезд из центра";
            outCenterButton.UseVisualStyleBackColor = true;
            outCenterButton.Click += OnOutCenterClick;
            // 
            // inCenterButton
            // 
            inCenterButton.Dock = DockStyle.Fill;
            inCenterButton.Location = new Point(4, 5);
            inCenterButton.Margin = new Padding(4, 5, 4, 5);
            inCenterButton.Name = "inCenterButton";
            inCenterButton.Size = new Size(355, 68);
            inCenterButton.TabIndex = 0;
            inCenterButton.Text = "Схождение звезд в центр";
            inCenterButton.UseVisualStyleBackColor = true;
            inCenterButton.Click += OnInCenterClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.8888855F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.Controls.Add(trackCheckBox, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 156);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(363, 78);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // trackCheckBox
            // 
            trackCheckBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            trackCheckBox.AutoSize = true;
            trackCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            trackCheckBox.Location = new Point(4, 24);
            trackCheckBox.Margin = new Padding(4, 5, 4, 5);
            trackCheckBox.Name = "trackCheckBox";
            trackCheckBox.Size = new Size(314, 29);
            trackCheckBox.TabIndex = 0;
            trackCheckBox.Text = "Включить след:";
            trackCheckBox.TextAlign = ContentAlignment.MiddleRight;
            trackCheckBox.UseVisualStyleBackColor = true;
            // 
            // spawnButton
            // 
            spawnButton.Dock = DockStyle.Fill;
            spawnButton.Location = new Point(4, 239);
            spawnButton.Margin = new Padding(4, 5, 4, 5);
            spawnButton.Name = "spawnButton";
            spawnButton.Size = new Size(355, 69);
            spawnButton.TabIndex = 3;
            spawnButton.Text = "Создать объекты";
            spawnButton.UseVisualStyleBackColor = true;
            spawnButton.Click += OnSpawnClick;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.Controls.Add(label4, 0, 3);
            tableLayoutPanel5.Controls.Add(label3, 0, 2);
            tableLayoutPanel5.Controls.Add(label2, 0, 1);
            tableLayoutPanel5.Controls.Add(starCountTextBox, 1, 0);
            tableLayoutPanel5.Controls.Add(speedTrackBar, 1, 1);
            tableLayoutPanel5.Controls.Add(maxStarSizeTextBox, 1, 2);
            tableLayoutPanel5.Controls.Add(minStarSizeTextBox, 1, 3);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(9, 427);
            tableLayoutPanel5.Margin = new Padding(9, 10, 9, 10);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(363, 313);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(4, 248);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 50);
            label4.TabIndex = 7;
            label4.Text = "Мин. размер точки (px)";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(4, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 50);
            label3.TabIndex = 6;
            label3.Text = "Макс. размер точки (px)";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(4, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 5;
            label2.Text = "Скорость:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // starCountTextBox
            // 
            starCountTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            starCountTextBox.Location = new Point(149, 23);
            starCountTextBox.Margin = new Padding(4, 5, 4, 5);
            starCountTextBox.Name = "starCountTextBox";
            starCountTextBox.Size = new Size(210, 31);
            starCountTextBox.TabIndex = 0;
            starCountTextBox.Text = "1000";
            // 
            // speedTrackBar
            // 
            speedTrackBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            speedTrackBar.Location = new Point(149, 83);
            speedTrackBar.Margin = new Padding(4, 5, 4, 5);
            speedTrackBar.Minimum = 1;
            speedTrackBar.Name = "speedTrackBar";
            speedTrackBar.Size = new Size(210, 68);
            speedTrackBar.TabIndex = 1;
            speedTrackBar.Value = 5;
            speedTrackBar.ValueChanged += OnSpeedValueChanged;
            // 
            // maxStarSizeTextBox
            // 
            maxStarSizeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maxStarSizeTextBox.Location = new Point(149, 179);
            maxStarSizeTextBox.Margin = new Padding(4, 5, 4, 5);
            maxStarSizeTextBox.Name = "maxStarSizeTextBox";
            maxStarSizeTextBox.Size = new Size(210, 31);
            maxStarSizeTextBox.TabIndex = 2;
            maxStarSizeTextBox.Text = "5";
            // 
            // minStarSizeTextBox
            // 
            minStarSizeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            minStarSizeTextBox.Location = new Point(149, 258);
            minStarSizeTextBox.Margin = new Padding(4, 5, 4, 5);
            minStarSizeTextBox.Name = "minStarSizeTextBox";
            minStarSizeTextBox.Size = new Size(210, 31);
            minStarSizeTextBox.TabIndex = 3;
            minStarSizeTextBox.Text = "1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(4, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 4;
            label1.Text = "Кол-во точек:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResizeEnd += OnFormResizeEnd;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drawArea).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox drawArea;
        private TableLayoutPanel tableLayoutPanel2;
        private Button pauseButton;
        private Button simulationButton;
        private Button unpuaseButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button inCenterButton;
        private Button outCenterButton;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox trackCheckBox;
        private Button spawnButton;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox starCountTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TrackBar speedTrackBar;
        private TextBox maxStarSizeTextBox;
        private TextBox minStarSizeTextBox;
        private Label label1;
    }
}
