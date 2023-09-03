using System.Collections;
using System.Collections.Generic;
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

private void Start()
    {
        initialPosition = gameObject.transform.position;
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
            //接触先のオブジェクトのスプライトを接触元のオブジェクトのスプライトに変更
            targetObject.GetComponent<SpriteRenderer>().sprite = mySpriteRenderer.sprite;//SpriteRenderer画像の情報だけ出してきたやつ
            //接触元のオブジェクトのスプライトを接触先のオブジェクトのスプライトに変更
            gameObject.GetComponent<SpriteRenderer>().sprite = targetSpriteRenderer.sprite;
            Debug.Log(targetSpriteRenderer.name);
            Debug.Log(targetSpriteRenderer.name);
            
        }
        
        //初期位置に戻す処理
        SetInitialPosition();
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
 
