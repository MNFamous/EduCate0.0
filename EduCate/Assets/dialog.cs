using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using System.IO;

public class dialog : MonoBehaviour
{
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    private int index;
    public float typingspeed;
    bool textfinished=false;
    AudioSource talking;
    int index2;
    public TextAsset text;
    private void ReadString()
    {
        foreach (char letter in text.ToString())
        {
            if (letter == 13)
            {
                index2++;
            }
            sentences[index2] += letter;
        }
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            talking.Play();//it should be playing for each letter. But instead, it playing once and breaking my foreach.
            textdisplay.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ReadString();
        talking = GameObject.Find("talkings").GetComponent<AudioSource>();
        StartCoroutine(Type());
    }

    // Update is called once per frame
    void Update()
    {

        if (textdisplay.text == sentences[index])
        {
            textfinished = true;
        }
        if(textfinished == true) {
            if (Input.GetKeyDown("space"))
            {
                if (index < sentences.Length - 1)
                {
                    index++;
                    textdisplay.text = "";
                    StartCoroutine(Type());
                }
                else
                {
                    textdisplay.text = "";
                }
                textfinished = false;
            }
        }
    }

}
