using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl : MonoBehaviour
{
    public static string input = "";
    public static bool firstClick = false; // her objede �al��mas� i�in static
    public bool active = true; //her harfi bir kere se�ebilmesi i�in
    public static bool control = false; // kelimenin do�ru olup olmad���n�n kontrol� i�in
    TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(firstClick == false)// her t�klama bitti�inde orjinal renge d�nmesi i�in
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
    public void OnMouseDown()//ilk t�kland���nda 
    {
        if(firstClick == false)
        {
            click();
            firstClick = true;
        }
        
    }
    public void OnMouseEnter()// �zerine geldi�inde
    {
        if (firstClick == true && active== true)
        {
            click();
            
        }
    }
    public void OnMouseUp()
    {
        firstClick = false;
        //input = "";  //b�rakt��� anda ��kt�n�n �zerine devam etmemesi i�in
        control = true;
     }
}
