//TioTag Database
//Created By Gibson J. MacMillan
//January 2015
//Mr. T - ICS4U

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Imaging;

namespace TiotagDatabase
{
    public class dbObject
    {
        public string name, id, c1, c2, c3, c4, c5, img;

        public dbObject (string _name, string _id, string _c1, string _c2, string _c3, string _c4, string _c5, string _img)
        {
            name = _name;
            id = _id;
            c1 = _c1;
            c2 = _c2;
            c3 = _c3;
            c4 = _c4;
            c5 = _c5;
            img = _img;
        }
    }
}
