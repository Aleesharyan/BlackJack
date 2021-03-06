using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{

    //The text object we'll be writing to
    Text myText;

    void OnEnable()
    {
        EventManager.OnWin += UpdateTheText;
    }

    // Start is called before the first frame update
    void Start()
    {
        //just hook up our own reference to the textbox
        myText = this.GetComponent<Text>();

    }

    //public function to take a string and print it to the text object
    void UpdateTheText(string newText)
    {
        myText.text = newText;
    }
}
