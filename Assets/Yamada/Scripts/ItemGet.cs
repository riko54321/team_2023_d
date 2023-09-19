using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemGet : MonoBehaviour
{
    public ItemList itemList;

    public void OnClickItem()
    {
        if (itemList.itemCount < 3)
        {
            this.gameObject.SetActive(false);
            itemList.addItem(this.gameObject);

            if (TryGetComponent<EventTrigger>(out var eventTrigger))
            {
                Destroy(eventTrigger);
            }

            if (TryGetComponent<ItemGet>(out var itemGet))
            {
                Destroy(itemGet);
            }

            DaD daD = this.gameObject.GetComponent<DaD>();
            daD.enabled = true;

        }
        else
        {
            Debug.Log("これ以上アイテムを拾えません");
            //UIに反映したい場合はこの中に処理を書きます
        }
    }
}