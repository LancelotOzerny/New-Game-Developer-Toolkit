namespace Lancy.Tools
{
    [System.Serializable]
    public class Vector3Bool : Vector2Bool
    {
        public bool z;

        public new static Vector2Bool False
        {
            get => new Vector2Bool(false, false);
        }

        public new static Vector2Bool True
        {
            get => new Vector2Bool(true, true);
        }

        public Vector3Bool(bool x = false, bool y = false, bool z = false)
        {
            Set(x, y, z);
        }

        public void Set(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}