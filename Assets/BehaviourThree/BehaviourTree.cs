using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BehaviourTree : Node
{
    private string debugString = "";

    public BehaviourTree(){
        Name = "Tree";
    }

    public BehaviourTree(string name){
        Name = name;
    }

// Recursion tree printing
    // public void PrintTree(){
    //     AddNodeDebugLine(this);
    //     Debug.Log(debugString);
    // }

    // private void AddNodeDebugLine(Node node, int level = 0){
    //     string tabsAmount = string.Concat(Enumerable.Repeat("-", level));
    //     debugString += "\n" + tabsAmount + node.Name;

    //     if(node.Children.Count > 0){
    //         foreach (var childNode in node.Children)
    //         {
    //             AddNodeDebugLine(childNode, level + 1);
    //         }
    //     }
    // }

// Stack tree printing
    public void PrintTree(){
        string treePrintingString = "";
        Stack<NodeLevel> nodeStack = new Stack<NodeLevel>();
        nodeStack.Push(new NodeLevel(this, 0));

        while(nodeStack.Count > 0){
            NodeLevel lastNode = nodeStack.Pop();
            treePrintingString += "\n" + new string('-', lastNode.Level) + lastNode.Node.Name;

            for (int i = 0; i < lastNode.Node.Children.Count; i++)
            {
                NodeLevel newNode = new NodeLevel(lastNode.Node.Children[i], lastNode.Level);
                nodeStack.Push(newNode);
            }
        }

        Debug.Log(treePrintingString);
    }

    class NodeLevel{
        private int _level;
        private Node _node;

        public int Level{get;}
        public Node Node{get;}

        public NodeLevel(Node node, int level){
            _level = level;
            _node = node;
        }
    }
}
