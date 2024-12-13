using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue_Tech_Demo : MonoBehaviour
{
    public GameObject textBox;
    public Sprite kaneSprite;
    public List<Character> newDialogue;
    public string blank = "";
    public class Character // Not the optimum way of doing this but it'll do for now.
    {
        public string name;
        public string testDialogue;


        public Character(string name, string testDialogue) => this.name = name;

    }
    // Start is called before the first frame update
    void Start()
    {
        textBox.GetComponentInChildren<TMP_Text>().text = blank;
        Instantiate(textBox);
        textBox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
