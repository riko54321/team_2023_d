using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public ItemList itemList;
    
    public void TextDisplay()
    {   
        if (itemList.itemCount >= 3)
        {
            this.gameObject.SetActive(true);

            Debug.Log("active");
        }
    }
}
