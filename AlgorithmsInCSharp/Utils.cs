using System;

namespace Utils
{
    public class ObjectUtils
    {
        private static long GetObjectSize(object obj)
        {
            var bf = new BinaryFormatter();
            var ms = new MemoryStream();
            bf.Serialize(ms, obj);
            var size = ms.Length;
            ms.Dispose();
            return size;
        }
    }
}

