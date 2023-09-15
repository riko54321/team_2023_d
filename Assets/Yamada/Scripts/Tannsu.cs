using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tannsu : MonoBehaviour
{
    [SerializeField]GameObject tannsuPanel;
    // Start is called before the first frame update
    void Start()
    {
        //tannsuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClickTannsu()
    {
        tannsuPanel.SetActive(true);
    }
}
