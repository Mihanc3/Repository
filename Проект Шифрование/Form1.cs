using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_Шифрование
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GenerateKey()
        {
            Random rnd = new Random();
            int key = rnd.Next(1,65530);
            return key;
        }

        private void bSendUser1_Click(object sender, EventArgs e)
        {
            ushort key = Convert.ToUInt16(GenerateKey()); 


            string str = textUser1.Text; 

            str = EncodeDecrypt(str, key); 

            CheckMessage(lbUser1.Text,str,key);

            textUser1.Clear();

        }

        private void bSendUser2_Click(object sender, EventArgs e)
        {
            ushort key = Convert.ToUInt16(GenerateKey());

            string str = textUser2.Text; 

            str = EncodeDecrypt(str, key);

            CheckMessage(lbUser2.Text, str, key);

            textUser2.Clear();

        }

        public void CheckMessage(string user, string message, UInt16 key)
        {
            Server.WebService s = new Server.WebService();
            string text = s.DescritMessage(user, message, key);
            if (text == "error")
            {
                textMessages.Text = user + ": Ошибка получения сообщения";
            }
            else
                textMessages.Text = textMessages.Text +  "\r\n" + user + ": " + text;
        }


        public static string EncodeDecrypt(string str, ushort secretKey)
        {
            var ch = str.ToArray(); //преобразуем строку в символы
            string newStr = "";      //переменная которая будет содержать зашифрованную строку
            foreach (var c in ch)  //выбираем каждый элемент из массива символов нашей строки
                newStr += TopSecret(c, secretKey);  //производим шифрование каждого отдельного элемента и сохраняем его в строку
            return newStr;
        }

        public static char TopSecret(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey); //Производим XOR операцию
            return character;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textMessages.Clear();
        }
    }
}
