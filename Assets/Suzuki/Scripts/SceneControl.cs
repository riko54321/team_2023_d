using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用
 
public class SceneControl : MonoBehaviour
{
   public void Title()
    {
         SceneManager.LoadScene("TitleScene2");
        }

        public void Start()
    {
         SceneManager.LoadScene("scene1");
        }
    }
