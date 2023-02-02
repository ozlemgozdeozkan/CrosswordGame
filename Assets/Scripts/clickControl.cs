using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl : MonoBehaviour
{
    public static string input = "";
    public static bool firstClick = false; // her objede çalýþmasý için static
    public bool active = true; //her harfi bir kere seçebilmesi için
    public static bool control = false; // kelimenin doðru olup olmadýðýnýn kontrolü için
    TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(firstClick == false)// her týklama bittiðinde orjinal renge dönmesi için
        {
            text = GetComponent<TextMesh>();
            text.color = Color.white;
            active = true;
        }
        
    }
    public void click()
    {
        text = GetComponent<TextMesh>();
        text.color = Color.black;
        input += GetComponent<TextMesh>().text;
        Debug.Log(input);
        active = false;
    }
    public void OnMouseDown()//ilk týklandýðýnda 
    {
        if(firstClick == false)
        {
            click();
            firstClick = true;
        }
        
    }
    public void OnMouseEnter()// üzerine geldiðinde
    {
        if (firstClick == true && active== true)
        {
            click();
            
        }
    }
    public void OnMouseUp()
    {
        firstClick = false;
        //input = "";  //býraktýðý anda çýktýnýn üzerine devam etmemesi için
        control = true;
     }
}
