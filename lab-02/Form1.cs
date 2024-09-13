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

        public Form1()
        {
            InitializeComponent();
            _currentGraphics = drawArea.CreateGraphics();
            _stars = new Star[0];
            CreateStars(1000);
        }


        private void DrawStar(Star star)
        {
            var brush = new SolidBrush(star.Color);
            _currentGraphics.FillEllipse(brush,
                (int)(star.X + (star.Size / 2)),
                (int)(star.Y + (star.Size / 2)),
                star.Size,
                star.Size
            );
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
                    _random.Next(1, 5),
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
            _currentGraphics = drawArea.CreateGraphics();
            CreateStars(1000);

            _updateCancellationToken?.Cancel();
            _updateCancellationToken = new CancellationTokenSource();
            var token = _updateCancellationToken.Token;

            _updateDrawTask = Task.Run(async () =>
            {
                try
                {
                    while (!_updateCancellationToken.IsCancellationRequested)
                    {
                        _currentGraphics.Clear(Color.Black);
                        foreach (var star in _stars)
                        {
                            star.Update(_updateDelay / 1000.0f);
                            DrawStar(star);
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
    }
}
