using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject panelFood;
    public GameObject panelColors;
    public GameObject panelRoulete;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
           // DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }

    }

   
    public void ActivePanelFood()
    {
        panelFood.SetActive(true);
    }

    public void ActivePanelRoulte()
    {
        panelRoulete.SetActive(true);


    }

    public void RestarScene()
    {
        SceneManager.LoadScene(0);
    }


}
