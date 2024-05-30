namespace GraphLib
{
    public class DirectedGraph
    {
        public int NumVertices { get => Vertices.Count; }
        public List<Vertex> Vertices = new List<Vertex>();

        public Vertex AddVertex(string label)
        {
            Vertex v = new Vertex(label);
            

            Vertices.Add(v);

            return v;
        }
       

        public int[,] CreateAdjMatrix()

           

        {
            int[,] AdjMatrix = new int[Vertices.Count, Vertices.Count];
            for (int i = 0; i < Vertices.Count; i++) 
            {
                Vertex v1 = Vertices[i];

                for (int j = 0; j < Vertices.Count; j++) 
                {

                    Vertex v2 = Vertices[j];
                    Edge edge = v1.Edges.FirstOrDefault(e => e.Child == v2);
                    if(edge != null)
                    {
                        AdjMatrix[i,j] = edge.Weight;
                    }
                }

            }

            return AdjMatrix;
            
        }
        public void PrintMatrix()
        {
            int[,] matrix = CreateAdjMatrix();

            Console.Write("\t");
            for (int i = 0; i < Vertices.Count; i++)
            {
                Console.Write($"{Vertices[i].Label}\t");
            }
            Console.WriteLine();
            
            for (int i = 0;i < Vertices.Count;i++)
            {
                Console.Write($"{Vertices[i].Label}\t");
                for (int j = 0;j < Vertices.Count; j++)
                {
                    Console.Write($"[{matrix[i,j]}]\t");
                }
                Console.WriteLine();
            }
        }
        
    }
}
