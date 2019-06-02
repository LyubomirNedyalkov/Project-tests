using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelEscToggle : MonoBehaviour
{
    [SerializeField] GameObject panel;
  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            panel.gameObject.SetActive(!panel.gameObject.activeSelf);
        }
    }
}
