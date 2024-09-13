using System.Collections;

namespace lab_01
{
    public partial class Form1 : Form
    {
        private readonly int _gridCeilSize = 20;
        private readonly int _drawDelay = 30;

        private Graphics _drawAreaGraphics;
        private CancellationTokenSource? _drawCancellationToken;
        private Task? _delayDrawTask;

        public Form1()
        {
            InitializeComponent();
            _drawAreaGraphics = drawArea.CreateGraphics();
        }

        private void OnDrawClick(object sender, EventArgs e) => DrawImageWithDelay();

        private void DrawImageWithDelay(int initialDelay = 0, bool drawDelay = true)
        {
            var drawCalls = DrawImageRoutine();
            _drawCancellationToken?.Cancel();
            _drawCancellationToken = new CancellationTokenSource();
            var token = _drawCancellationToken.Token;

            _delayDrawTask = Task.Run(async () =>
            {
                try
                {
                    await Task.Delay(initialDelay);
                    foreach (var drawCall in drawCalls)
                    {
                        if (drawDelay) await Task.Delay(_drawDelay, token);
                    }
                }
                catch (OperationCanceledException) { }
            }, token);
        }

        private IEnumerable DrawImageRoutine()
        {
            _drawAreaGraphics.Clear(Color.White);
            var width = drawArea.Width;
            var height = drawArea.Height;
            var pen = new Pen(Color.LightGray, 1);

            for (int i = 0; i <= height; i += _gridCeilSize)
            {
                _drawAreaGraphics.DrawLine(pen, 0, i, width, i);
                yield return null;
            }

            for (int i = 0; i <= width; i += _gridCeilSize)
            {
                _drawAreaGraphics.DrawLine(pen, i, 0, i, height);
                yield return null;
            }

            int wSize = 7 * _gridCeilSize;
            int hSize = 17 * _gridCeilSize;
            int xOffset = (int)((width / 2.0) - (wSize / 2.0));
            int yOffset = (int)((height / 2.0) - (hSize / 2.0));

            pen.Color = Color.Black;
            pen.Width = 4;

            // l ramp
            _drawAreaGraphics.DrawLine(pen,
                xOffset + (int)(3.5 * _gridCeilSize),
                yOffset,
                xOffset + (2 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize)
            );
            yield return null;

            // r ramp
            _drawAreaGraphics.DrawLine(pen,
                xOffset + (int)(3.5 * _gridCeilSize),
                yOffset,
                xOffset + (5 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize)
            );
            yield return null;

            // r body line
            _drawAreaGraphics.DrawLine(pen,
                xOffset + (5 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize),
                xOffset + (5 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize)
            );
            yield return null;

            // l body line
            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize),
                xOffset + (2 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize)
            );
            yield return null;

            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize),
                xOffset + (2 * _gridCeilSize) - _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize
            );
            yield return null;

            // l engine
            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize) - _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize,
                xOffset + (2 * _gridCeilSize) - _gridCeilSize - _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize
            );
            yield return null;

            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize) - _gridCeilSize - _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize,
                xOffset + (2 * _gridCeilSize) - _gridCeilSize - _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize - (4 * _gridCeilSize)
            );
            yield return null;

            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize) - _gridCeilSize - _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize - (4 * _gridCeilSize),
                xOffset + (2 * _gridCeilSize) - _gridCeilSize - _gridCeilSize + 2 * _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize - (4 * _gridCeilSize) - (3 * _gridCeilSize)
            );
            yield return null;

            //botom line
            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize),
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize)
            );
            yield return null;

            // r engine
            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize),
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize) + _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize
            );
            yield return null;

            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize) + _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize,
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize) + _gridCeilSize + _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize
            );
            yield return null;

            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize) + _gridCeilSize + _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize,
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize) + _gridCeilSize + _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize - (4 * _gridCeilSize)
            );
            yield return null;

            _drawAreaGraphics.DrawLine(pen,
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize) + _gridCeilSize + _gridCeilSize,
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize - (4 * _gridCeilSize),
                xOffset + (2 * _gridCeilSize) + (3 * _gridCeilSize) + _gridCeilSize + _gridCeilSize - (2 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize) + (11 * _gridCeilSize) + _gridCeilSize - (4 * _gridCeilSize) - (3 * _gridCeilSize)
            );
            yield return null;

            pen.Color = Color.Red;
            pen.Width = 3;

            // 1 circle
            _drawAreaGraphics.DrawEllipse(pen,
                xOffset + (3 * _gridCeilSize),
                yOffset + (5 * _gridCeilSize),
                _gridCeilSize,
                _gridCeilSize
            );
            yield return null;

            pen.Color = Color.Green;
            // 2 circle
            _drawAreaGraphics.DrawEllipse(pen,
                xOffset + (3 * _gridCeilSize),
                yOffset + (7 * _gridCeilSize),
                _gridCeilSize,
                _gridCeilSize
            );
            yield return null;

            pen.Color = Color.Blue;
            // 3 circle
            _drawAreaGraphics.DrawEllipse(pen,
                xOffset + (3 * _gridCeilSize),
                yOffset + (9 * _gridCeilSize),
                _gridCeilSize,
                _gridCeilSize
            );
            yield return null;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            DrawImageWithDelay(50);
        }

        private void OnFormResizeEnd(object sender, EventArgs e)
        {
            _drawAreaGraphics = drawArea.CreateGraphics();
            DrawImageWithDelay(25, false);
        }
    }
}
