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
    //isDecorationというbool型の変数を宣言
    public static bool isDecoration = false;



    private void Start()
    {
        initialPosition = gameObject.transform.position;

      
    }

    private void OnMouseDrag()
    {
        if (isDecoration == true)
        {
            transform.position = (Vector2)_cam.ScreenToWorldPoint(Input.mousePosition);
        }
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
                case "8491B7":
                   targetSpriteRenderer.color = new Color32(132, 145, 183, 255);
                    break;

                case "A2C5D1":
                    targetSpriteRenderer.color = new Color32(162, 197, 209, 255);
                    break;

                case "BD9DBF":
                    targetSpriteRenderer.color = new Color32(189, 157, 191, 255);
                    break;

                case "C29286":
                    targetSpriteRenderer.color = new Color32(194, 146, 134, 255);
                    break;

                case "D8B9A2":
                    targetSpriteRenderer.color = new Color32(216, 185, 162, 255);
                    break;

                case "D58F97":
                    targetSpriteRenderer.color = new Color32(213, 143, 151, 255);
                    break;

                case "DDA5B6":
                    targetSpriteRenderer.color = new Color32(221, 165, 182, 255);
                    break;   

                case "DFCF8C":
                    targetSpriteRenderer.color = new Color32(223, 207, 140, 255);
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




