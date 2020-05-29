using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2
{
    static class RelationshipsDrawer
    {
        static public List<Relationship> relationships = new List<Relationship>();
        static public PaintEventArgs e;
        static public List<TableInDiagram> tables = new List<TableInDiagram>();

        static public void DrawingRelationships()
        {
            foreach (Relationship r in relationships)
            {
                if (r.constraintName != "PRIMARY")
                {
                    Point startPoint = GetPoint(r.tableName, r.columnName);
                    Point finishPoint = GetPoint(r.referencedTableName, r.referencedColumnName);
                    Drawing(startPoint, finishPoint);
                }
            }
        }

        static private Point GetPoint(string tableName, string columnName)
        {
            foreach (TableInDiagram t in tables)
            {
                if (t.nameTable == tableName)
                {
                    foreach (Field f in t.Fields)
                    {
                        if (f.name == columnName)
                            return new Point(f.Marker.X, f.Marker.Y + t.Height / 2);
                    }
                }

            }
            return new Point();
        }

        static private void Drawing(Point startPoint, Point finishPoint)
        {
            int width = tables[0].Width;
            //Вторая таблица справа от первой
            if (startPoint.X + width < finishPoint.X)
            {
                startPoint.X += width;
                DrawSymbols(0, startPoint);

                e.Graphics.DrawLine(Pens.Black, new Point(startPoint.X + 10, startPoint.Y),
                    new Point(finishPoint.X - 10, finishPoint.Y));

                DrawSymbols(2, finishPoint);
            }
            //Вторая таблица слева от первой
            else if (startPoint.X > finishPoint.X + width)
            {
                finishPoint.X += width;
                DrawSymbols(1, startPoint);

                e.Graphics.DrawLine(Pens.Black, new Point(startPoint.X - 10, startPoint.Y),
                    new Point(finishPoint.X + 10, finishPoint.Y));

                DrawSymbols(3, finishPoint);
            }
            //Если они друг под другом
            else
            {
                bool firstTop = startPoint.Y > finishPoint.Y ? true : false;
                if (startPoint.X < finishPoint.X)
                {
                    DrawSymbols(1, startPoint);
                    e.Graphics.DrawLine(Pens.Black, new Point(startPoint.X - 10, startPoint.Y),
                        new Point(startPoint.X - 10, finishPoint.Y));
                    e.Graphics.DrawLine(Pens.Black, new Point(startPoint.X - 10, finishPoint.Y),
                                        new Point(finishPoint.X - 10, finishPoint.Y));
                    DrawSymbols(2, finishPoint);
                }
                else
                {
                    startPoint.X += width;
                    finishPoint.X += width;
                    DrawSymbols(0, startPoint);
                    e.Graphics.DrawLine(Pens.Black, new Point(startPoint.X + 10, startPoint.Y),
                        new Point(startPoint.X + 10, finishPoint.Y));
                    e.Graphics.DrawLine(Pens.Black, new Point(startPoint.X + 10, finishPoint.Y),
                                        new Point(finishPoint.X + 10, finishPoint.Y));
                    DrawSymbols(3, finishPoint);
                }
            }
        }

        static private void DrawSymbols(int type, Point point)
        {
            // 0 <- 1 -> 2 -| 3 |-
            switch (type)
            {
                case 0:
                    e.Graphics.DrawLine(Pens.Black, point, new Point(point.X + 10, point.Y));
                    e.Graphics.DrawLine(Pens.Black, point, new Point(point.X + 10, point.Y + 5));
                    e.Graphics.DrawLine(Pens.Black, point, new Point(point.X + 10, point.Y - 5));
                    break;
                case 1:
                    e.Graphics.DrawLine(Pens.Black, new Point(point.X - 10, point.Y), point);
                    e.Graphics.DrawLine(Pens.Black, point, new Point(point.X - 5, point.Y - 5));
                    e.Graphics.DrawLine(Pens.Black, point, new Point(point.X - 5, point.Y + 5));
                    break;
                case 2:
                    e.Graphics.DrawLine(Pens.Black, new Point(point.X - 10, point.Y), point);
                    break;
                case 3:
                    e.Graphics.DrawLine(Pens.Black, new Point(point.X + 10, point.Y), point);
                    break;
            }
        }
    }
}
