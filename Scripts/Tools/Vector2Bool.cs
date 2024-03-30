namespace Lancy.Tools
{
    [System.Serializable]
    public class Vector2Bool
    {
        public bool x;
        public bool y;

        public static Vector2Bool False
        {
            get => new Vector2Bool(false, false);
        }

        public static Vector2Bool True
        {
            get => new Vector2Bool(true, true);
        }

        public Vector2Bool(bool x = false, bool y = false)
        {
            Set(x, y);
        }

        public void Set(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }
    }

}