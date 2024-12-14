using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Dialogue_Tech_Demo : MonoBehaviour
{
    

    public GameObject textBox;      // The prefab reference for the UI element.

    public Sprite kaneSprite;       // Sprites displayed in the UI.
    public Sprite Leeman;
    public Sprite Daniel;
    

    public List<Character> newDialogue;
    public string blank = "";

    public TMP_Text currentDialogue;
    public UnityEngine.UI.Image currentSprite;

    public string test = "Debug";
    
    public class Character // Not the optimum way of doing this but it'll do for now.
    {
        public string name;
        public string testDialogue;


        public Character(string name, string testDialogue) => this.name = name;

    }
    // Start is called before the first frame update
    void Start()
    {
        // Time.timeScale = 0; // Might work

        currentDialogue = textBox.GetComponentInChildren<TMP_Text>();
        currentDialogue.text = test;
       
        currentSprite = textBox.GetComponentInChildren<UnityEngine.UI.Image>();
        currentSprite.sprite = Leeman;

        Instantiate(textBox);
        textBox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Press de 'E' man, ova");
            ProgressText();
        }
    }

    void ProgressText()
    {
        textBox.SetActive(false);
        currentDialogue.text = test;
        textBox.SetActive(true);
        
    }

    void TestDialog(Character x)
    {
        
    }
}
