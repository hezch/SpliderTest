using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;

namespace spider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //http://news.baidu.com/
            WebRequest request = WebRequest.Create("https://user.qzone.qq.com/1227362277/main");
            WebResponse response = (WebResponse)request.GetResponse();

            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data, Encoding.UTF8);


            string rl;
            string text="";
            while ((rl = reader.ReadLine()) != null)
            {
                //string judge1 = "onClick=\"return js_callpage(this.href);\">";
                //string judge2 = "</a>";
                //int a = -1, b = -1; //用a,b来判断judge1和judge2是否存在
                //if ((a = rl.IndexOf(judge1)) != -1 && (b = rl.IndexOf(judge2)) != -1)
                //{
                //    //start和end用来表示需要截取内容的开头和末尾的索引
                //    int start = a + judge1.Length;
                //    int end = b;
                //    string title = rl.Substring(start, end - start);
                //    text += title;
                //}

                text += rl;
            }

            string temp = text;
        }
    }
}
