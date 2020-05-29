using System;
using System.Drawing;

namespace Diplom2
{
    public struct Field
    {
        public string key;
        public string name;
        public string type;
        public string nul;
        public string defaul;
        public string extra;
        private Brush brush;
        private Point marker;

        public Field(string key, string name, string type, string nul = "", string defaul = "", string extra = "",
                                                                                        Point marker = new Point())
        {
            this.key = key;
            this.name = name;
            this.type = type;
            this.nul = ""; 
            this.defaul = "";
            this.extra = "";
            this.marker = new Point();
            this.brush = Brushes.Black;
        }

        public Point Marker { get => marker; set => marker = value; }
        public Brush Brush { get => brush; set => brush = value; }

        public void ChangeMarker(Point point)
        {
            Marker = point;
        }
    }
}