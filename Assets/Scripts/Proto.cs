using System;
using System.IO;
using UnityEngine;

public static class Proto {
    public static byte[] Encode<T>(T t) {
        try {
            using (MemoryStream ms = new MemoryStream()) {
                ProtoBuf.Serializer.Serialize<T>(ms, t);
                byte[] result = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(result, 0, result.Length);
                return result;
            }
        } catch (Exception e) {
            Debug.LogError(e);
            return null;
        }
    }

    public static T Decode<T>(byte[] bytes) {
        try {
            using (MemoryStream ms = new MemoryStream()) {
                ms.Write(bytes, 0, bytes.Length);
                ms.Position = 0;
                T result = ProtoBuf.Serializer.Deserialize<T>(ms);
                return result;
            }
        } catch (Exception e) {
            Debug.LogError(e);
            return default(T);
        }
    }
}
