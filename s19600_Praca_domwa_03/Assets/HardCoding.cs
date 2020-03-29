using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    //zmienne

    int a = 2;
    float b = 0.5f;
    bool c = true;
    bool d = false;
    string e = ("Programuję w C# ");
    string f = ("EPG ");
    
    // Start is called before the first frame update
    void Start()
    {
            //wyswietlanie zmiennych
        wyswietlenie();
             // warunki if
         warunki();
             //matoda Equals
        sprawdzenie();
             // tabelka koniunkcji c&&d
        koniunkcja();
        // tabelka altrnatywy c||d
        alternatywa();
     
    }

    void warunki()
    {
        if (a == b)
        {
            Debug.Log("TAK, a=b");
            if(a>=b)
            {
             Debug.Log("a>=b");
            }
            if (a <= b)
            {
             Debug.Log("a<=b");
            }
        }
        else if (a != b)
        {
            Debug.Log("Nie, a!=b");
            if (a > b)
            {
                Debug.Log("a>b");
            }
            else if (a < b)
            {
                Debug.Log("a<b");
            }
         

        }
    }

        void  sprawdzenie ()
        {
            if (e.Equals(f))
            {
                Debug.Log("e==f");
            }
            else
            {
                Debug.Log("e różne od f");
            }
        }

        void wyswietlenie()
        {
            Debug.Log(a);
            Debug.Log(b);
            Debug.Log(c);
            Debug.Log(d);
            Debug.Log(e);
            Debug.Log(f);
        }

    void koniunkcja()
    {
        if (c == true && d == true)
        {
            Debug.Log("Wynik koniunkcji = true");
        }
        else if ((c == false && d == false) || (c == false && d == true) || (c == true && d == false))
        {
            Debug.Log("Wynik koniunkcji = false");
        }

    }

    void alternatywa()
    {
        if (c == true || d == true)
        {
            Debug.Log("Wynik alternatywy = true");
        }
        else if (c == false && d == false)
        {
            Debug.Log("Wynik alternatywy = false");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
