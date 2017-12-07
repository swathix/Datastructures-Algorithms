using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            ArrayList resolved = new ArrayList();
            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node e = new Node("e");
            a.addEdge(b);
            a.addEdge(d);
            b.addEdge(c);
            b.addEdge(e);
            c.addEdge(d);
            c.addEdge(e);
            a.resolve();
            a.resolve(resolved);
            foreach(Node i in resolved)
            {
                Console.WriteLine(i.name);
            }

        }
    }
}
