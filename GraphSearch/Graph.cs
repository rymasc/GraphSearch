using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearch {
    class Graph<T> {

        List<Edge<T>> Edges = new List<Edge<T>>();
        List<Vertex<T>> Vertices = new List<Vertex<T>>();

        public Vertex<T> clickedVertex;

        public void AddVertex(Vertex<T> vertex) {
            Vertices.Add(vertex);
        }

        public bool IsUniqueVertex(int x, int y) {
            foreach (Vertex<T> v in Vertices) {
                if (v.IsClicked(x,y)) {
                    clickedVertex = v;
                    return true;
                }
            }
            return false;
        }

    }
}
