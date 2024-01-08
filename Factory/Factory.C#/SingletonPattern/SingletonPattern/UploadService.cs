namespace SingletonPattern
{
     sealed class UploadService
     {
        private UploadService(){}
        public int Id { get; set; }

        private static UploadService _instance;
        private static readonly object _lock = new object();
        public static UploadService Instance(int id)
        {
            if(_instance == null)
            {
                lock(_lock) 
                {
                    if(_instance == null)
                    {
                        _instance = new UploadService();
                        _instance.Id = id;
                    }
                }
            }
            return _instance;
        }
    }
}
