using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int totalTargets;
    private GameObject parede1;
    private GameObject parede2;
    private GameObject parede3;
    private GameObject parede4;
    private GameObject parede5;
    private GameObject parede6;
    void Start()
        
    {
        parede1 = GameObject.Find("Parede1");
        parede2 = GameObject.Find("Parede2");
        parede3 = GameObject.Find("Parede3");
        parede4 = GameObject.Find("Parede4");
        parede5 = GameObject.Find("Parede5");
        parede6 = GameObject.Find("Parede6");
    }

    
    void Update()
    {
        totalTargets = GameController.instance.getTotalTargets();
        Debug.Log("Total targets: " + totalTargets);
        if (totalTargets >= 5)
        {
            Destroy(parede1);
        }
        if (totalTargets >= 11)
        {
            Destroy(parede2);
        }
        if (totalTargets >= 14)
        {
            Destroy(parede3);
        }
        if (totalTargets >= 18)
        {
            Destroy(parede4);
        }
        if (totalTargets >= 21)
        {
            Destroy(parede5);
        }
        if (totalTargets >= 23)
        {
            Destroy(parede6);
        }
    }
}
