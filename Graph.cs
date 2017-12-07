using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{

    public class Node
    {
        public string name;
        public ArrayList edges = new ArrayList();
        public Node(string name)
        {

            this.name = name;

        }


        public void addEdge(Node node)
        {
            Console.WriteLine(this.name);
            this.edges.Add(node);
            //foreach (Node i in this.edges)
            //{

            //    Console.WriteLine(i.name);
            //}
            //Console.WriteLine();
        }

    
       
        public void resolve()
        {
            Console.WriteLine(this.name);
            foreach(Node edge in this.edges)
            {
                edge.resolve();
            }

        }


        public void resolve(ArrayList resolved)
        {
            Console.WriteLine(this.name);
            foreach (Node edge in this.edges)
            {
                edge.resolve( resolved);
                resolved.Add(this.name);
            }
        }
    }
}



