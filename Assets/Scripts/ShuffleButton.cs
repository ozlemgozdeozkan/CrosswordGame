using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleButton : MonoBehaviour
{
    public List<Transform> buttons;
    public List<string> letters;
    public List<int> indis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void random()
    {
        int i;
        indis.Clear();// her shuffle butonuna basýldýðýnda bu fonsiyon çalýþacak, indisin dizisindeki deðerler rastgele gelen sayýlara eþit olcaðý için
        for(i = 0; i<letters.Count; i++)
        {
            indis.Add(-1);
        }

        i = 0;
        while (true)
        {
            if(i == letters.Count)
            {
                break;
            }
            int random = Random.Range(0, letters.Count);
            int count = 0;
            for (int j = 0; j < letters.Count; j++)
            {
                if(indis[j] == random)
                {
                    count++;
                    break;
                }

            }
            if (count > 0)
            {
                continue;//while döngüsüne geri dön
            }
            else
            {
                indis[i] = random;
                i++;
            }
        }
        for (i=0; i<letters.Count; i++)
        {
            buttons[i].GetComponent<TextMesh>().text = letters[indis[i]];
        }
    }
    public void OnMouseDown()
    {
        random();
    }
}
