using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用
 
public class SceneControl : MonoBehaviour
{
   public void Title()
    {
        ItemList.itemNames.Clear();

        SoundManager.Instance.PlaySE(SESoundData.SE.Click);
        SceneManager.LoadScene("TitleScene2");
    }

 public void Starts()
    {
        SceneManager.LoadScene("scene1");
    }

}
