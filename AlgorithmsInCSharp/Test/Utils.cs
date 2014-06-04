using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Utils
{
    public class ObjectUtils
    {
        public static long GetObjectSize(object obj)
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

