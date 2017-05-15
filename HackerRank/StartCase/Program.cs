using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{

    public static int hasBalancedBrackets(string str)
    {
        Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>()
        {
            {'{',new List<int>()},
            {'}',new List<int>()},
            {'(',new List<int>()},
            {')',new List<int>()},
            {'<',new List<int>()},
            {'>',new List<int>()},
            {'[',new List<int>()},
            {']',new List<int>()}
        };
        for (var i = 0; i < str.Length; i++)
        {
            var symb = str[i];
            if (dict.ContainsKey(symb))
            {
                dict[symb].Add(i);
            }
        }

        for (var i = 0; i < dict.Count; i+=2)
        {
            var leftItem = dict.ElementAt(i);
            var leftVal = leftItem.Value;
            var rightItem = dict.ElementAt(i+1);
            var rightVal = rightItem.Value;
            if (leftVal.Count > 0 && rightVal.Count > 0)
            {
                if (leftVal.Count != rightVal.Count)
                {
                    return 0;
                }
                else
                {
                    for (int j = 0; j < leftVal.Count; j++)
                    {
                        if (leftVal[j] > rightVal[j])
                        {
                            return 0;
                        }
                    }
                }
            }
        }
        return 1;
    }


    /*   public static int hasBalancedBrackets(string str)
       {
          char[] symbLeft = { '{', '(', '<', '{' };
           char[] symbRight = { '}', ')', '<', '}' };
           int[] leftCount = new int[4] { 0, 0, 0, 0 };
           int[] rightCount = new int[4] { 0, 0, 0, 0 };
           foreach (var c in str)
           {
               for (var i = 0; i < 4; i++)
               {
                   if (c == symbLeft[i])
                   {
                       leftCount[i]++;
                   }
                   if (c == symbRight[i])
                   {
                       rightCount[i]++;
                   }
               }
           }

           for (int i = 0; i < 4; i++)
           {
               if (leftCount[i] != rightCount[i])
                   return 0;
           }
           return 1;
       }*/

    public static int bstDistance(int[] values, int n, int node1, int node2)
    {
        Node root = null;
        Tree t = new Tree();
        for (int i = 0; i < n; i++)
        {
            root = t.insert(root,null,values[i]);
        }
        var dist = 0;
        var node = t.search(Tree.Root, 2);
        var steps = Node.steps;
        return steps;
    }

    static void Main(String[] args)
    {
        //var i= hasBalancedBrackets("{}()[]<>");
        var i = bstDistance(new int[] {5,6,3,1,2,4},6,2,4);
       
    }
}

class Node
{
    public int value;
    public Node left;
    public Node right;
    public Node top;
    public static int steps;
}

class Tree
{
    public static Node Root;
    public Node insert(Node root,Node topNode, int v)
    {
        if (root == null)
        {
            root = new Node();
            root.value = v;
            if (Root == null)
            {
                Root = root;
            }
        }
        else if (v < root.value)
        {
            root.left = insert(root.left,root, v);
        }
        else
        {
            root.right = insert(root.right, root, v);
        }
        if (topNode != null)
        {
            root.top = topNode;
        }
        return root;
    }

   

    public Node search(Node root, int val)
    {
        if (root.value == val)
        {
            return root;
        }
        else
        {
            if (val < root.value)
            {
                Node.steps++;
                return search(root.left, val);
            }
            else
            {
                Node.steps++;
                return search(root.right, val);
            }
        }
    }
}
