using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainedItems : MonoBehaviour
{
    void Start()
    {
        if (this.gameObject.name == "Item1")
        {
            Instantiate(Resources.Load<GameObject>(ItemList.itemNames[0]), this.gameObject.transform);
        }
        else if (this.gameObject.name == "Item2")
        {
            Instantiate(Resources.Load<GameObject>(ItemList.itemNames[1]), this.gameObject.transform);
        }
        else if (this.gameObject.name == "Item3")
        {
            Instantiate(Resources.Load<GameObject>(ItemList.itemNames[2]), this.gameObject.transform);
        }
    }
}
