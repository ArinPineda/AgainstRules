using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ColorsGame : MonoBehaviour
{

    public Image greenImage;
    public Image redImage;
    public Image yellowImage;
    public List<Image> images;
    public Image test;

    public TMP_Text titleText;
    public TMP_Text removeText;


    public TMP_Text greenText;
    public TMP_Text redText;
    public TMP_Text yellowText;

    public List<string> words;

    public void Start()
    {
        setColorsGame();
    }

    public void setColorsGame()
    {

        words.Add("Green"); 
        words.Add("Red");
        words.Add("Yellow");

        

        int randomValue = Random.Range(0, words.Count);
        titleText.text = words[randomValue];

        switch (words[randomValue])
        {
            case "Green":
                test.color = Color.green;
           
                break;
            case "Red":
                test.color = Color.red;


                break;
            case "Yellow":
                test.color = Color.yellow;


                break;
        }


        randomValue = Random.Range(0, images.Count);
        images[randomValue].color = Color.red;
        images.RemoveAt(randomValue);

        randomValue = Random.Range(0, images.Count);
        images[randomValue].color = Color.green;
        images.RemoveAt(randomValue);


        randomValue = Random.Range(0, images.Count);
        images[randomValue].color = Color.yellow;
        images.RemoveAt(randomValue);


        randomValue = Random.Range(0, words.Count);
        greenText.text = words[randomValue];

        words.RemoveAt(randomValue);

        randomValue = Random.Range(0, words.Count);
        redText.text = words[randomValue];
        words.RemoveAt(randomValue);


        randomValue = Random.Range(0, words.Count);
        yellowText.text = words[randomValue];
        words.RemoveAt(randomValue);


    }

    public void ButtonSelect(string buttonPress)
    {



        switch (buttonPress)
        {
            case "Green":
                VerifyColorText(GameObject.Find(buttonPress));
                break;

            case "Red":
                VerifyColorText(GameObject.Find(buttonPress));

                break;

            case "Yellow":
                VerifyColorText(GameObject.Find(buttonPress));

                break;

        }


    
       
    }

    public void VerifyColorText( GameObject buttonPress)
    {
        

        GameObject childObject = buttonPress.transform.GetChild(0).gameObject;
        Image imgColor = buttonPress.GetComponent<Image>();
        string colorName = imgColor.color.ToString();
        TMP_Text textColor = childObject.GetComponent<TMP_Text>();
        string textColorLower = titleText.text.ToLower();
        if (textColor.text != titleText.text && test.color.ToString() != colorName)
        {
            removeText.transform.gameObject.SetActive(false);
            titleText.text = "Congratulations";
            Invoke("NextPanel", 2f);

        }

    }

    public void NextPanel()
    {
        UIManager.instance.panelColors.SetActive(false);
        UIManager.instance.ActivePanelRoulte();

    }

}
