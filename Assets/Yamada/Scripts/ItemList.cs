using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemList : MonoBehaviour
{
    public List<GameObject> itemList = new List<GameObject>(); //GameObject型のListを定義

    [SerializeField] private GameObject item1, item2, item3;
    [System.NonSerialized] public int itemCount;
    private Image image1, image2, image3;
    public GameObject TextMP;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        image1 = item1.GetComponent<Image>();
        image2 = item2.GetComponent<Image>();
        image3 = item3.GetComponent<Image>();

        TextMP = GameObject.Find("ItemLimit");
        TextMP.SetActive(false);
    }

    public void addItem(GameObject gottenItem){

        itemList.Add(gottenItem);

        for(int i = 0; i < itemList.Count; i++)
        {
            Debug.Log(itemList[i]);
        }

        if (itemCount == 0)
        {
            itemList[0] = gottenItem;
            image1.sprite = gottenItem.GetComponent<SpriteRenderer>().sprite;
            itemCount++;

            item1_Decoration.Item1_Decoration(gottenItem);
        }
        else if (itemCount == 1)
        {
            itemList[1] = gottenItem;
            image2.sprite = gottenItem.GetComponent<SpriteRenderer>().sprite;
            itemCount++;

            item2_Decoration.Item2_Decoration(gottenItem);
        }
        else if (itemCount == 2)
        {
            itemList[2] = gottenItem;
            image3.sprite = gottenItem.GetComponent<SpriteRenderer>().sprite;
            itemCount++;

            item3_Decoration.Item3_Decoration(gottenItem);

            TextMP.SetActive(true);
            Debug.Log("active");
        }

    } 
}