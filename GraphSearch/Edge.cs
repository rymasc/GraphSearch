using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearch {
    class Edge<T> {

        int weight;

        Vertex<T> v1;
        Vertex<T> v2;

        public int Weight { get { return weight;  } }

        public Vertex<T> V1 { get { return v1; } }
        public Vertex<T> V2 { get { return v2; } }

        public Edge(Vertex<T> vertex1, Vertex<T> vertex2, int weight) {
            v1 = vertex1;
            v2 = vertex2;
            this.weight = weight;
            v1.AddNeighbor(v2);
            v1.AddEdge(this);

        }
    }
}
