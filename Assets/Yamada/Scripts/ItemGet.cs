using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    public ItemList itemList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickItem()
    {
        this.gameObject.SetActive(false);
        itemList.addItem(this.gameObject.name);
    }
}
