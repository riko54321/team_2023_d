using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dresser : MonoBehaviour
{
    [SerializeField]GameObject dresserPanel;
    // Start is called before the first frame update
    void Start()
    {
        dresserPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClickDresser()
    {
        dresserPanel.SetActive(true);
    }
}
