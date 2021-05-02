using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BcatToolbox
{
    public class Utils
    {

        public static Bitmap GetBitmap(byte[] buffer)
        {
            //assuming buffer is in JPG format
            using MemoryStream ms = new MemoryStream(buffer);
            return (Bitmap)Image.FromStream(ms);
        }


        public static bool IsValidDeviceID(string id)
        {
            return Regex.IsMatch(id, "^(XA(J|W)[0-9]{11})$");
        }

        public static bool IsValidSdkVersion(string version)
        {

            string[] splitted = version.Split('.');

            if (splitted.Length != 4)
                return false;

            foreach (var s in splitted)
                if (!byte.TryParse(s, out byte res))
                    return false;

            return true;
        }

        //pass
        public static bool IsValidPassphrase(string pass)
        {
            return Regex.IsMatch(pass, "^[0-9a-fA-F]{64}$");
        }

        //title id
        public static string GetBaseTitle(long tid)
        {
            return GetBaseTitle(tid.ToString("X16"));
        }
        public static string GetBaseTitle(string tid)
        {
            return tid.Remove(13) + "000";
        }
        public static bool IsValidTid(string tid)
        {
            return Regex.IsMatch(tid, "^0100[0-9a-fA-F]{12}$");
        }
        public static bool IsValidTid(long tid)
        {
            return IsValidTid(tid.ToString("X16"));
        }

        //convertsion
        public static byte[] HexToBytes(string hex)
        {
            hex = hex.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
            return Enumerable.Range(0, hex.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
        }

        public static string BytesToHex(byte[] bytes, string separator)
        {
            return BitConverter.ToString(bytes).Replace("-", separator);
        }

        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using var ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            Image image = Image.FromStream(ms, true);
            return image;
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using var ms = new MemoryStream();

            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }

        public static byte[] ImageToByteStream(Image img)
        {
            byte[] data = new byte[0];
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                ms.Seek(0, 0);
                data = ms.ToArray();
            }
            return data;
        }

        public static void SaveFile(byte[] buffer, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.Write(buffer);
            sw.Flush();
            sw.Close();
        }

        public static byte[] ConvertImg(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        public static Image DownloadImageFromUrl(string imageUrl)
        {
            Image image = null;

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                WebResponse webResponse = webRequest.GetResponse();

                Stream stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }

            return image;
        }

        public static byte[] ReadFile(string path)
        {
            FileInfo info = new FileInfo(path);
            byte[] data = new byte[info.Length];

            using var stream = info.OpenRead();
            stream.Read(data, 0, data.Length);

            return data;
        }

        // https://stackoverflow.com/questions/18994685/how-to-handle-both-a-single-item-and-an-array-for-the-same-property-using-json-n
        public class SingleOrArrayConverter<T> : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(List<T>));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JToken token = JToken.Load(reader);
                if (token.Type == JTokenType.Array)
                {
                    return token.ToObject<List<T>>();
                }

                var auto = new List<T> { token.ToObject<T>() };
                return auto.ToString();
            }

            public override bool CanWrite
            {
                get { return false; }
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }

        public static List<T> DeserializeSingleOrList<T>(JsonReader jsonReader)
        {
            if (jsonReader.Read())
            {
                switch (jsonReader.TokenType)
                {
                    case JsonToken.StartArray:
                        return new JsonSerializer().Deserialize<List<T>>(jsonReader);

                    case JsonToken.StartObject:
                        var instance = new JsonSerializer().Deserialize<T>(jsonReader);
                        return new List<T> { instance };
                }
            }

            throw new InvalidOperationException("Unexpected JSON input");
        }

        public static string[] _saltLower =
        {
                    "a3e20c5c1cd7b720",
                    "7f4c637432c8d420",
                    "188d087d92a0c087",
                    "8e7d23fa7fafe60f",
                    "5252ae57c026d3cb",
                    "2650f5e53554f01d",
                    "b213a1e986307c9f",
                    "875d8b01e3df5d7c",
                    "c1b9a5ce866e00b1",
                    "6a48ae69161e0138",
                    "3f7b0401928b1f46",
                    "0e9db55903a10f0e",
                    "a8914bcbe7b888f9",
                    "b15ef3ed6ce0e4cc",
                    "f3b9d9f43dedf569",
                    "bda4f7a0508c7462",
                    "f5dc3586b1b2a8af",
                    "7f6828b6f33dd118",
                    "860de88547dcbf70",
                    "ccbacacb70d11fb5",
                    "b1475e5ea18151b9",
                    "5f857ca15cf3374c",
                    "cfa747c1d09d4f05",
                    "30e7d70cb6f98101",
                    "c8b3c78772bdcf43",
                    "533dfc0702ed9874",
                    "a29301cac5219e5c",
                    "5776f5bec1b0df06",
                    "1d4ab85a07ac4251",
                    "7c1bd512b1cf5092",
                    "2691cb8b3f76b411",
                    "4400abee651c9eb9"
        };

        public static string output = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string version = "1.0.0";

        public static byte[] ToByteArray(object source)
        {
            var formatter = new BinaryFormatter();
            using var stream = new MemoryStream();
            formatter.Serialize(stream, source);
            return stream.ToArray();
        }
    }
}