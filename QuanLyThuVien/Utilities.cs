using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class Utilities
    {
        private static Utilities _instance;

        public static Utilities Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Utilities();
                return _instance;
            }
        }

        public string NextID(string prefix, string fullID)
        {
            //tính ID tiếp theo
            int nextID = int.Parse(fullID.Remove(0, prefix.Length)) + 1;

            //tính độ dài tối đa của ID 
            int length = fullID.Length - prefix.Length;

            string zero = "";

            for(int i=1; i<=length;i++)
            {
                if(nextID < Math.Pow(10,i))
                {
                    for(int j = i; j <= length - 1;j++)
                    {
                        zero += "0";
                    }
                    return prefix + zero + nextID.ToString();
                }
            }
            return prefix + nextID.ToString();
        }
    }
}
