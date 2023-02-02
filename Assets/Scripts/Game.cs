using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public List<Transform> squares;
    public List<int[]> vocabs = new List<int[]>();//3 harfliler için dizi
    public int[] vocab1;
    public int[] vocab2;
    public int[] vocab3;
    public int[] vocab4;
    public int[] vocab5;

    
    

    public List<string> words;
    

    // Start is called before the first frame update
    void Start()
    {        
        vocabs.Add(vocab1);
        vocabs.Add(vocab2);
        vocabs.Add(vocab3);
        vocabs.Add(vocab4);
        vocabs.Add(vocab5);
                
    }

    // Update is called once per frame
    void Update()
    {
        if (clickControl.control==true)
        {
            clickControl.control = false;//1 kere çalýþmasý için
            for(int i = 0; i< words.Count; i++)
            {
                if (clickControl.input == words[i])
                {
                    int[] indis = vocabs[i];
                    for (int j = 0; j < words[i].Length; j++)//string olduðu için length kullanmam gerek)
                    {
                        squares[indis[j]].GetComponent<TextMesh>().text = clickControl.input[j].ToString();
                    }
                   
                }
                    
             }
            clickControl.input = "";//her kelimeden sonra harf eklenmemesi için sýfýrlamak gerek
        }

        
    }
    
 }

