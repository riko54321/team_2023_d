using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField]GameObject boxPanel;
    // Start is called before the first frame update
    void Start()
    {
        //boxPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClickBox()
    {
        boxPanel.SetActive(true);
    }
}
