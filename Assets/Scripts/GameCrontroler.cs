using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameCrontroler : MonoBehaviour
{
    public string Word = "after";
    public TextMeshProUGUI MainWord;
    public TextMeshProUGUI OurInput;
    public TMP_InputField InputField;



    // Start is called before the first frame update
    void Start()
    {
        MainWord.text = Word;
    }

    public void OnImputCanged(string input)
    {
        OurInput.text = input;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
