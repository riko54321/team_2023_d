using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    public ItemList itemList;

    public void OnClickItem()
    {
        if (itemList.itemCount < 3)
        {
            this.gameObject.SetActive(false);
            itemList.addItem(this.gameObject);
        }
        else
        {
            Debug.Log("これ以上アイテムを拾えません");
            //UIに反映したい場合はこの中に処理を書きます
        }
    }
}