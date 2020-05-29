using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2
{
    /// <summary>
    /// Класс реализует построение таблицы в pictureBox 
    /// </summary>
    public class TableInDiagram
    {
        public Point startPoint;
        public Point endPoint;
        public Rectangle rect;
        private int _width = 140;
        private int _height = 20;
        private Font _font = new Font("Times New Roman", 8);
        private Brush _brush = Brushes.Black;

        public string nameTable;
        private List<Field> _fields = new List<Field>();
        private List<string> _functions = new List<string>();
        private List<string> _indexes = new List<string>();

        public List<Field> Fields { get => _fields; set => _fields = value; }
        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }

        public TableInDiagram()
        {
            startPoint = new Point(100, 100);
            nameTable = "table1";
            Fields.Add(new Field("PK","field1","INT"));
            Fields.Add(new Field("PK", "field2", "BOOL"));
            Fields.Add(new Field("PK", "field3", "DOUBLE"));
            Fields.Add(new Field("PK", "field4", "INT"));
            _functions.Add("exampleFunction()");
        }

        public TableInDiagram(Point startPoint, string nameTable, List<Field> fields, List<string> functions)
        {
            this.startPoint = startPoint;
            this.nameTable = nameTable;
            Fields = fields;
            _functions = functions;
        }

        public void DrawingTable(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(startPoint, new Size(Width, Height)));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(startPoint, new Size(Width, Height)));
            e.Graphics.DrawString(nameTable, _font, _brush, startPoint.X + (Width * (float)0.16), startPoint.Y + (Height / 2 - _font.Size ));
            Point bufPoint = new Point(startPoint.X, startPoint.Y + Height);
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(bufPoint, new Size(Width, Fields.Count * Height)));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(bufPoint, new Size(Width, Fields.Count*Height)));
            int step = 0;
            for (int i = 0; i < Fields.Count; i++)
            {
                Field f = Fields[i];
                e.Graphics.DrawString(f.key + " " + f.name + " " + f.type.ToString(),
                                    _font, f.Brush, bufPoint.X + (Width * (float)0.1), bufPoint.Y + (Height / 2 - _font.Size) + step * Height);
                f.Marker = new Point(bufPoint.X, bufPoint.Y + step * Height);
                Fields[i] = f;
                step++;
            }
            bufPoint = new Point(bufPoint.X, startPoint.Y + Height * (step + 1));
            step = 0;
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(bufPoint, new Size(Width, _functions.Count * Height)));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(bufPoint, new Size(Width, _functions.Count * Height)));
            foreach (string s in _functions)
            {
                e.Graphics.DrawString(s, _font, _brush, bufPoint.X + (Width * (float)0.1), bufPoint.Y + (Height / 2 - _font.Size) + step * Height);
                step++;
            }

            endPoint = new Point(startPoint.X + Width, bufPoint.Y + Height * step);
            rect = new Rectangle(startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
        }



    }
}
