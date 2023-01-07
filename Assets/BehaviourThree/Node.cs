using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public enum Status{ SUCCESS, RUNNING, FAILURE }

    public Status NodeStatus;
    public List<Node> Children = new List<Node>();
    public int CurrentChild = 0;
    public string Name;

    public Node(){}

    public Node(string name){
        Name = name;
    }

    public void AddChild(Node node){
        Children.Add(node);
    }
}
