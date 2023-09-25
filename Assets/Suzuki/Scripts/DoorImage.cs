using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.Click);
    }
}
