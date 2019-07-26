using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PickStory : MonoBehaviour
{
    // Start is called before the first frame update
    Text titleText;
    void Start()
    {
        titleText = GameObject.Find("Text_Title").GetComponent<Text>();
        titleText.text = "Hola";
        string resourceRoute = PlayerPrefs.GetString("Resource_Route");
        var jsonInstructions = File.ReadAllText("Assets/Resources/English/instructions.json");
        Instructions instructions = JsonUtility.FromJson<Instructions>(jsonInstructions);
        
        Debug.Log(instructions.instructions.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
