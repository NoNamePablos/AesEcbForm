using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesEncryption
{
    public class Logger
    {
        private static string _title;
        private static string _message;
        private static StringBuilder _messageString;
        
        public static string messageString
        {
            get {
                return _messageString.ToString();
            }
            set {
                _messageString.Append(value);
            }
        
        }
        public Logger() { 
        _messageString=new StringBuilder();
        _messageString.Append("Начало");
        }

        Logger(string title) { 
            _title=title;
        }

        public static string log(byte[] bytes)
        {
            
            return BitConverter.ToString(bytes);
        }
        public static string ToString(byte[] bytes)
        {
            string response = string.Empty;

            foreach (byte b in bytes)
                response += (Char)b;

            return response;
        }

        public static byte[] convertArray(byte[,] arr) {
            int rows = arr.GetUpperBound(0) + 1;    // количество строк
            int columns = arr.Length / rows;        // количество столбцов
            byte[] bytes = new byte[rows * columns];
            int z = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    bytes[z] = arr[i, j];
                    z++;
                }
            }
            return bytes;
        }

        public static string Log2Arr(byte[,] arr) {
            int rows = arr.GetUpperBound(0) + 1;    // количество строк
            int columns = arr.Length / rows;        // количество столбцов
            string str = "";                                           // или так
                                                                       // int columns = numbers.GetUpperBound(1) + 1;
            byte[] bytes = new byte[rows * columns];
            int z = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    bytes[z] = arr[i, j];
                    z++;
                }
            }
            str += log(bytes);
            return str;
        }
        public static string ByteArrayToString(byte[] ba)
        {
            string str="";
            for (int i = 0; i < ba.Length; i++) {
                str += convert(ba[i])+" ";
            }
            _messageString.Append(str);
            return str;
        }
        public static string ByteArrayToString(byte[,] ba)
        {
            int rows = ba.GetUpperBound(0) + 1;    // количество строк
            int columns = ba.Length / rows;        // количество столбцов
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    str+=convert(ba[i, j])+" ";
                }
                str += "\n ";
            }
            _messageString.Append(str);
            return str;
        }

        public static String convert(byte b)
        {
            StringBuilder str = new StringBuilder(8);
            int[] bl = new int[8];

            for (int i = 0; i < bl.Length; i++)
            {
                bl[bl.Length - 1 - i] = ((b & (1 << i)) != 0) ? 1 : 0;
            }

            foreach (int num in bl) str.Append(num);

            return str.ToString();
        }

    }
}
