using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp13_Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<short, string> dict1 = new Dictionary<short, string>();
            //dict1.Add(1, "dfs");
            //dict1.Add(1, "dfs21"); // does'nt allow duplicate keys -- runtime argument exception 

            //Hashtable ht = new Hashtable();
            //ht.Add(1, "dfs");
            //ht.Add(1, "dfs21");// does'nt allow duplicate keys -- runtime argument exception 
            //ht.Add("AA", 12); // allow keys of any type

            //List<int> lst = new List<int>();
            //lst.Add(1);
            //lst.Add(1);

            //ArrayList arrLst = new ArrayList();
            //arrLst.Add(1);
            //arrLst.Add(1);
            //arrLst.Add("erq"); // allow values of any type

            //HashSet<int> hst = new HashSet<int>();
            //hst.Add(1);
            //hst.Add(1); // NOT throws any exception BUT add only once

            //---------------------------------------------------------------------------------------------------------------------------------------

            Graph graph = new Graph();

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            Console.WriteLine("The graph adjacency list representation:");
            graph.PrintAdjanceyList();

            Console.Read();
        }
    }

    public class Graph
    {
        Dictionary<short, string> dict = new Dictionary<short, string>();

        public void AddEdge(short u, short v, bool biDir = true)
        {
            if (!dict.ContainsKey(u))
                dict.Add(u, Convert.ToString(v));
            else
                dict[u] = dict[u] + " , " + Convert.ToString(v);

            if (biDir)
            {
                if (!dict.ContainsKey(v))
                    dict.Add(v, Convert.ToString(u));
                else
                    dict[v] = dict[v] + " , " + Convert.ToString(u);
            }
        }

        public void PrintAdjanceyList()
        {
            foreach (var d in dict)
            {
                Console.WriteLine(d.Key + " -> " + d.Value);
            }
        }
    }
}
