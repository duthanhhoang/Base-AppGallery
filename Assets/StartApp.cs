using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartApp : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject MainPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        StartPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void GoBack(){
        StartPanel.SetActive(true);
        MainPanel.SetActive(false);
    }
}
