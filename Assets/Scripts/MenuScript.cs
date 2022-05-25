using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject menu;
    public GameObject lostText;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseMenu()
    {
        button.SetActive(false);
        menu.SetActive(false);
        Time.timeScale = 1f;
        lostText.SetActive(false);
    }
}
