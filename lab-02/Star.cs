using System.Diagnostics;

namespace lab_02
{
    internal sealed class Star
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public float Speed { get; set; }
        public readonly int Size;
        public readonly Color Color;

        private float _velocityX;
        private float _velocityY;

        public Star(Color color, int size, float initialX, float initialY, float speed)
        {
            Color = color;
            Size = size;
            Speed = speed;
            X = initialX;
            Y = initialY;

            _velocityX = 0;
            _velocityY = 0;
        }

        public void Update(float dTime)
        {
            X += _velocityX * Speed * dTime;
            Y += _velocityY * Speed * dTime;
        }

        public void SetVelocity(float x, float y)
        {
            _velocityX = x;
            _velocityY = y;
        }
    }
}
