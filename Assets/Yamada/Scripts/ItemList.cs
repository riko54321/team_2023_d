using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemList : MonoBehaviour
{
    List<string> itemList = new List<string>();//string型のListを定義
    [SerializeField]GameObject item1, item2, item3;
    int itemNum;
    Sprite sprite;
     Image image; 
    // Start is called before the first frame update
    void Start()
    {
        itemNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(string itemName){
        itemList.Add(itemName);
        for(int i = 0; i < itemList.Count; i++)
        {
            Debug.Log(itemList[i]);
        }
        if (itemNum == 0){
            if (itemName == "red"){
            sprite = Resources.Load<Sprite>("red");
            image = item1.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
            if (itemName == "blue"){
            sprite = Resources.Load<Sprite>("blue");
            image = item1.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
            if (itemName == "yellow"){
            sprite = Resources.Load<Sprite>("yellow");
            image = item1.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
        } else if (itemNum == 1){
            if (itemName == "red"){
            sprite = Resources.Load<Sprite>("red");
            image = item2.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
            if (itemName == "blue"){
            sprite = Resources.Load<Sprite>("blue");
            image = item2.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
            if (itemName == "yellow"){
            sprite = Resources.Load<Sprite>("yellow");
            image = item2.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
        } else if (itemNum == 2){
            if (itemName == "red"){
            sprite = Resources.Load<Sprite>("red");
            image = item3.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
            if (itemName == "blue"){
            sprite = Resources.Load<Sprite>("blue");
            image = item3.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
            if (itemName == "yellow"){
            sprite = Resources.Load<Sprite>("yellow");
            image = item3.GetComponent<Image>();
            image.sprite = sprite;
            itemNum++;
            }
        }
    } 
}
