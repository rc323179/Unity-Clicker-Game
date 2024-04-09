using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject HowPanel;
    void Start()
    {
        HowPanel.SetActive(false);
    }
    // Start is called before the first frame update
    public void Return()
    {
        MenuPanel.SetActive(true);
        HowPanel.SetActive(false);
    }

    // Update is called once per frame
    public void How()
    {
        
        MenuPanel.SetActive(false);
        HowPanel.SetActive(true);
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
