namespace Multiton
{
    public class Camera
    {
        private static readonly Dictionary<string, Camera> _cameras = [];
        private static readonly object _lock = new();
        public Guid Id { get; set; }

        private Camera()
        {
            Id = Guid.NewGuid();
        }

        public static Camera GetCamera(string key)
        {
            lock (_lock)
            {
                if (!_cameras.ContainsKey(key))
                {
                    _cameras[key] = new Camera();
                }
            }

            return _cameras[key];
        }
    }
}
