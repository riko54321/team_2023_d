using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemGet : MonoBehaviour
{
    public ItemList itemList;

    public AudioSource audioSource;
    public AudioClip se1;

    public void OnClickItem()
    {
        if (itemList.itemCount < 3)
        {
            this.gameObject.SetActive(false);
            itemList.addItem(this.gameObject);

            audioSource.PlayOneShot(se1);
        }
        else
        {
            Debug.Log("これ以上アイテムを拾えません");
            //UIに反映したい場合はこの中に処理を書きます

            Destroy(this.gameObject.GetComponent<EventTrigger>());
            Destroy(this.gameObject.GetComponent<ItemGet>());
        }
    }
}