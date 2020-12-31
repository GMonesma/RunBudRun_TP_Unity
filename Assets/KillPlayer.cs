using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    private GameObject OpenPanel = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            OpenPanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
        }
            
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOpenPanelActive)
        {
            OpenPanel.SetActive(false);
        }
    }
}
