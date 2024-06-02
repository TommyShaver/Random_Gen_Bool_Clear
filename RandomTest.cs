using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
    public bool[] testBoolArry = new bool[5];
    public bool[] testBoolArrt2 = new bool[10];

    public void ThisIsTheOtherFunction()
    {
        ReturnThisNumber(testBoolArrt2);
    }

    public void ThisIsAFunction()
    {
        ReturnThisNumber(testBoolArry);
    }

    private int ReturnThisNumber(bool[] whichBool)
    {
        List<int> result = new List<int>();
        result.Clear();
        bool allTrue = Array.TrueForAll(whichBool, b  => b);
        if (allTrue)
        {
            for (int j = 0; j < whichBool.Length; j++)
            {
                whichBool[j] = false;
            }
        }
        for (int i = 0; i < whichBool.Length; i++)
        {
            if (whichBool[i] == false)
            {
                result.Add(i); 
                //Debug.Log(randomNumber + "This is the randomNumber in the list");

            }
        }

        int randomNumber = result[(UnityEngine.Random.Range(0, result.Count))];
        Debug.Log(randomNumber);
        whichBool[randomNumber] = true;
        Debug.Log(randomNumber + "This is the randomNumber in that was chosen");
        return randomNumber;
    }
}
