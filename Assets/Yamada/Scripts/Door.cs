using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickDoor()
    {
        DaD.isDecorating = true;

        SceneManager.LoadScene("Decoration");
    }
}
