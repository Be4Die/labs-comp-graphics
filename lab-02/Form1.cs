using System.Diagnostics;

namespace lab_02
{
    public partial class Form1 : Form
    {
        private Graphics _currentGraphics;
        private Star[] _stars;
        private readonly Random _random = new();
        private CancellationTokenSource? _updateCancellationToken;
        private readonly int _updateDelay = 50;
        private Task? _updateDrawTask;
        private bool _isPaused;

        public Form1()
        {
            InitializeComponent();
            _currentGraphics = drawArea.CreateGraphics();
            _stars = new Star[0];
            CreateStars(GetStarCount());
        }


        private void DrawStar(Star star)
        {
            var brush = new SolidBrush(star.Color);
            var x = (int)(star.X + (star.Size / 2));
            var y = (int)(star.Y + (star.Size / 2));

            int n = trackCheckBox.Checked ? 7 : 1;

            for (int i = 0; i < n; i++)
            {
                _currentGraphics.FillEllipse(brush,
                    (int)(x - ((star.Size * .5f) * i) * star.VelocityX),
                    (int)(y - ((star.Size * .5f) * i) * star.VelocityY),
                    star.Size,
                    star.Size
                );
            }
        }

        private void CreateStars(int n)
        {
            var width = drawArea.Width;
            var height = drawArea.Height;
            _stars = new Star[n];
            for (int i = 0; i < n; i++)
            {
                _stars[i] = new Star(
                    Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256)),
                    _random.Next(GetMinStarSize(), GetMaxStarSize()),
                    (float)_random.NextDouble() * width,
                    (float)_random.NextDouble() * height,
                    500f);
            }
        }

        private void OnFormResizeEnd(object sender, EventArgs e)
        {
            _currentGraphics = drawArea.CreateGraphics();
        }

        private void OnSimulationClick(object sender, EventArgs e)
        {
            _isPaused = false;
            _currentGraphics = drawArea.CreateGraphics();
            CreateStars(GetStarCount());

            _updateCancellationToken?.Cancel();
            _updateCancellationToken = new CancellationTokenSource();
            var token = _updateCancellationToken.Token;

            _updateDrawTask = Task.Run(async () =>
            {
                try
                {
                    while (!_updateCancellationToken.IsCancellationRequested)
                    {
                        if (!_isPaused)
                        {
                            _currentGraphics.Clear(Color.Black);
                            foreach (var star in _stars)
                            {
                                star.Update(_updateDelay / 1000.0f);
                                DrawStar(star);
                            }
                        }
                        await Task.Delay(_updateDelay, token);
                    }
                }
                catch (OperationCanceledException) { }
            }, token);
        }

        private void OnInCenterClick(object sender, EventArgs e)
        {
            var centerX = drawArea.Width * .5;
            var centerY = drawArea.Height * .5;
            foreach (var star in _stars)
            {
                // Вычисляем вектор направления от звезды к центру
                double directionX = centerX - star.X;
                double directionY = centerY - star.Y;

                // Нормализуем вектор, чтобы получить единичный вектор направления
                double length = Math.Sqrt(directionX * directionX + directionY * directionY);
                if (length > 0)
                {
                    directionX /= length;
                    directionY /= length;
                }
                star.SetVelocity((float)directionX, (float)directionY);
            }
        }

        private void OnOutCenterClick(object sender, EventArgs e)
        {
            var centerX = drawArea.Width * .5;
            var centerY = drawArea.Height * .5;

            foreach (var star in _stars)
            {
                // Вычисляем вектор направления от центра к звезде
                double directionX = star.X - centerX;
                double directionY = star.Y - centerY;

                // Нормализуем вектор, чтобы получить единичный вектор направления
                double length = Math.Sqrt(directionX * directionX + directionY * directionY);
                if (length > 0)
                {
                    directionX /= length;
                    directionY /= length;
                }

                // Устанавливаем скорость звезды в направлении от центра
                star.SetVelocity((float)directionX, (float)directionY);
            }
        }

        private void OnSpeedValueChanged(object sender, EventArgs e)
        {
            foreach (var star in _stars)
            {
                star.Speed = speedTrackBar.Value * 100f;
            }
        }

        private int GetStarCount()
        {
            if (int.TryParse(starCountTextBox.Text, out var n) && n > 0) return n;
            MessageBox.Show("Колличество звезд должно быть положительно!!");
            return 1000;
        }

        private int GetMinStarSize()
        {
            if (int.TryParse(minStarSizeTextBox.Text, out var n) && n > 0) return n;
            MessageBox.Show("Размер звезд должно быть положительно!!");
            return 1;
        }

        private int GetMaxStarSize()
        {
            if (int.TryParse(maxStarSizeTextBox.Text, out var n) && n > 0) return n;
            MessageBox.Show("Размер звезд должно быть положительно!!");
            return 1;
        }

        private void OnPauseClick(object sender, EventArgs e)
        {
            _isPaused = true;
        }

        private void OnResumeClick(object sender, EventArgs e)
        {
            _isPaused = false;
        }

        private void OnSpawnClick(object sender, EventArgs e)
        {

        }
    }
}
