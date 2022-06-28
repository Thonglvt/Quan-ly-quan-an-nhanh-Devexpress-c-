using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace BLL
{
    public class BLL_HamXuLy
    {
        //ảnh -> byte[]
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //Chuyển từ byte[] sang Image
        public static byte[] imageToByArray(string path)
        {
            MemoryStream mmStream = new MemoryStream();
            Image img = Image.FromFile(path);
            img.Save(mmStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return mmStream.ToArray();

            //Có thể dùng class file để chuyển
            //return File.ReadAllBytes(path);
        }

        //
        public static string convertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static bool CheckUsername(string username)
        {
            //Chuỗi định dạng email
            String reg = "^[a-zA-Z0-9]+$";
            Regex re = new Regex(reg);
            return re.IsMatch(username);
        }
        public static bool CheckPassword(string password)
        {
            //Chuỗi định dạng email
            String reg = @"^(.{0,7}|[^0-9]*|[^A-Z])$";
            Regex re = new Regex(reg);
            return re.IsMatch(password);//True:  pass ko hợp lê
        }
        //KIỂM TRA PHONE
        public static bool CheckPhone(string phone)
        {
            //Chuỗi định dạng email
            String reg = "^(0|\\+84)(\\s|\\.)?((3[2-9])|(5[689])"
                        + "|(7[06-9])|(8[1-689])|(9[0-46-9]))"
                        + "(\\d)(\\s|\\.)?(\\d{3})(\\s|\\.)?(\\d{3})$";
            Regex re = new Regex(reg);
            return re.IsMatch(phone);
        }
        //KIỂM TRA EMAIL
        public static bool CheckEmail(string Email)
        {
            //Chuỗi định dạng email
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            //String strRegex = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@((\\[[0-9]{1,3}"
            //            +"\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|"
            //            +"(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$";
            Regex re = new Regex(strRegex);
            return re.IsMatch(Email);
        }
        //Hàm MD5
        public static string MaHoaMD5(string str)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
            //MessageBox.Show(sb.ToString());
            ////nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa 
            //trong "X2" thành "x"
        }


        public int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }
    }
}
