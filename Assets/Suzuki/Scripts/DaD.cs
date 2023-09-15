using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class DaD : MonoBehaviour
{
    [SerializeField] Camera _cam;

    private Vector2 initialPosition;

    //アイテムがフィールドにあるかどうかの判定
    private bool isItemField = false;
    //接触先のオブジェクト
    private GameObject targetObject;
    //接触元のオブジェクトのスプライトの画像
    private SpriteRenderer mySpriteRenderer;
    //接触先のオブジェクトのスプライト
    private SpriteRenderer targetSpriteRenderer;

    public GameObject nailListObj;
    private NailList nailList;

    private void Start()
    {
        initialPosition = gameObject.transform.position;

        nailList = nailListObj.GetComponent<NailList>();
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)_cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()//マウスを押したとき
    {
        //アイテムがフィールドにあるかどうかの判定
        if (isItemField == true)
        {
            Debug.Log("アイテム交換");
            //接触先のオブジェクトのスプライトを取得
            targetSpriteRenderer = targetObject.GetComponent<SpriteRenderer>();
            //接触元のオブジェクトのスプライトを取得
            mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

            NailChange();
            
            Debug.Log(targetSpriteRenderer.name);
            Debug.Log(targetSpriteRenderer.name);
            
        }
        
        //初期位置に戻す処理
        SetInitialPosition();
    }

    private void NailChange()
    {
        if (this.gameObject.tag == "Parts")
        {
            Debug.Log("parts");

            Transform childTransform = targetObject.transform.GetChild(0);
            targetObject = childTransform.gameObject;

            targetSpriteRenderer = targetObject.GetComponent<SpriteRenderer>();

            Debug.Log(targetSpriteRenderer);

            targetSpriteRenderer.sprite = mySpriteRenderer.sprite;
        }
        else
        {
            switch (this.gameObject.tag)
            {
                case "Pink":
                    targetSpriteRenderer.sprite = nailList.nailColors[0];
                    break;

                case "Blue":
                    targetSpriteRenderer.sprite = nailList.nailColors[1];
                    break;
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)//丸と四角が重なったとき
    {
        isItemField = true;
        targetObject = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isItemField = false;
    }

    //初期位置に戻す処理
    public void SetInitialPosition()
    {
        gameObject.transform.position = initialPosition;
    }
}




