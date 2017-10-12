using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphSearch {
    public partial class GraphCreator : Form {

        public Graphics gfx;
        Graph<char> graph = new Graph<char>();
        char charLabel = '@';
        Font font = new Font("Arial", 10);

        public GraphCreator() {
            InitializeComponent();
            gfx = pictureBox1.CreateGraphics();
            gfx.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }


        private void pictureBox1_Click(object sender, EventArgs e) {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int x = mouseEvent.Location.X;
            int y = mouseEvent.Location.Y;
            PointF mouseClickPt = new PointF(x, y);

            if (mouseEvent.Button == MouseButtons.Left) {
                if (!graph.IsUniqueVertex(x, y)) {
                    charLabel++;
                    //MessageBox.Show("Clicked " + x + ", " + y + " Value is " + charLabel);
                    PointF topLeft = new PointF(x - 2, y - 2);
                    RectangleF rect = new RectangleF(topLeft, new SizeF(20, 20));
                    graph.AddVertex(new Vertex<char>(charLabel, x, y, rect));
                    gfx.FillRectangle(Brushes.Orange, rect);
                    gfx.DrawString(charLabel.ToString(), font, Brushes.Black, new PointF(x, y));
                    
                } else {
                    MessageBox.Show("You clicked Vertex " + graph.clickedVertex.Value);
                }

                
            }

            if (mouseEvent.Button == MouseButtons.Right) {
                MessageBox.Show(" ");
            }
        }
    }
}
