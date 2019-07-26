using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    Button enButton;
    Button esButton;
    public Text title;
    public string resourceRoute;

    int banLanguage;
    void Start()
    {
        enButton = GameObject.Find("But_En").GetComponent<Button>();
        esButton = GameObject.Find("But_Es").GetComponent<Button>();
        
        enButton.onClick.AddListener(SetEnglish);
        esButton.onClick.AddListener(SetSpanish);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetEnglish()
    {
        resourceRoute = "English";
        PlayerPrefs.SetString("Resource_Route", resourceRoute);
        SceneManager.LoadScene("PickStoryScene");
    }
    void SetSpanish()
    {
        resourceRoute = "Spanish";
        PlayerPrefs.SetString("Resource_Route", resourceRoute);
        SceneManager.LoadScene("PickStoryScene");
    }
}
