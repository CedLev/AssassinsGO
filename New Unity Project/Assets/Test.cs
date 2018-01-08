using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int monEntier;
    public bool maBool = false;

    public const int TAILLE_MAX = 5;

    public int[] tabEntier = { 5, 3, 4, 5, 5 };

    void Start()
    {
        monEntier = 5;
    }

    void Update()
    {
        for (int i = 0; i < TAILLE_MAX; i = i + 2) // nimportekoi
        {
            tabEntier[0] = 12;
        }


    }


    public bool MaFonction(int x)
    {

        if (x != 5)
        {
            return false;
        }
        else
        {
            return true;
        }
    }



}
