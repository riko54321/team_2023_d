using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    //使用する4つのカメラ(東西南北)を入れるための配列
    //配列は0,1,2,3と、1ではなく0で始まる点に注意
    public GameObject[] Cameras;

    //使用するカメラを指定するための変数
    private int cameraCounter = 0;

    //右ボタンを押すと実行される関数
    public void CameraRight()
    {
        //現在アクティブになっているカメラを非アクティブ(チェックを外す)処理
        Cameras[cameraCounter].gameObject.SetActive(false);

        //cameraCounter変数に1足す
        cameraCounter++;

        //3番目がアクティブだった場合、0番目のカメラに変更するための条件分岐
        if (cameraCounter > 3)
        {
            cameraCounter = 0;
        }

        //ConsoleにcameraCounterの中身を表示するための処理
        //（デバッグ用の処理なので無くてもいい）
        Debug.Log(cameraCounter);

        //関数実行時にアクティブだったカメラ+1番目のカメラをアクティブにする処理
        Cameras[cameraCounter].gameObject.SetActive(true);

    }

    //左ボタンを押すと実行される関数
    public void CameraLeft()
    {
        Cameras[cameraCounter].gameObject.SetActive(false);

        //cameraCounter変数を1減らす
        cameraCounter--;

        if (cameraCounter < 0)
        {
            cameraCounter = 3;
        }

        Debug.Log(cameraCounter);

        Cameras[cameraCounter].gameObject.SetActive(true);
    }
}