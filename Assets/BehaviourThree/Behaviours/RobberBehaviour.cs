using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobberBehaviour : MonoBehaviour
{
    BehaviourTree BehaviourThree;
    
    
    // Start is called before the first frame update
    void Start()
    {
        BehaviourThree = new BehaviourTree("Tree");

        Node steal = new Node("Steal Something");
        Node goToDiamond = new Node("Go to diamond");
        Node gotToVan = new Node("Go to van");

        steal.AddChild(goToDiamond);
        steal.AddChild(gotToVan);
        BehaviourThree.AddChild(steal);

        Node eatSomething = new Node("Eat Something");
        Node goToPizzaShop = new Node("Go to pizza shop");
        Node eatPizza = new Node("Eat pizza");

        eatSomething.AddChild(goToPizzaShop);
        eatSomething.AddChild(eatPizza);
        BehaviourThree.AddChild(eatSomething);

        BehaviourThree.PrintTree();
        Debug.Log("Print");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
