using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphSearch {
    class Vertex<T> {

        //public Vertex(T value, params Vertex<T, U>[] parameters) : this(value, (IEnumerable<Vertex<T>>)parameters) { }



        //public Vertex(T value, IEnumerable<Vertex<T>> neighbors = null) {
        //    Value = value;
        //    Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
        //}

        public Vertex(T value, int x_position, int y_position, RectangleF r) {
            Value = value;
            X = x_position;
            Y = y_position;
            rectangle = r;
        }

        public T Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public T Cost { get; set; }
        public RectangleF rectangle;
        public List<Vertex<T>> Neighbors { get; }
        public List<Edge<T>> Edges { get; }
        public bool IsVisited { get; set; }
        public int NeighborCount => Neighbors.Count;

        public void AddEdge(Edge<T> edge) {
            Edges.Add(edge);
        }

        public void AddNeighbor(Vertex<T> vertex) {
            Neighbors.Add(vertex);
        }

        public override string ToString() {
            return Neighbors.Aggregate(new StringBuilder($"{Value}: "), (sb, n) => sb.Append($"{n.Value} ")).ToString();
        }

        public bool IsClicked(int x, int y) {
            return rectangle.Contains(x, y);
        }
    }
}
