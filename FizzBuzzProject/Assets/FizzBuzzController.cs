using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzzController : MonoBehaviour
{
    //REMAINDER
    //I FORGOT WHAT HE SAID ABOUT CODE
    //SHIT.
    //Encapsate everythiNG
    [SerializeField]
    private int AmountOfNums;

    private void Start()
    {
        FizzBuzzFunction();
    }

    private void FizzBuzzFunction()
    {
        for (int i = 1; i < AmountOfNums; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Debug.Log("Fizz Buzz " + i);
            else if (i % 3 == 0)
                Debug.Log("fizz " + i);
            else if (i % 5 == 0)
                Debug.Log("buzz " + i);
            else
                Debug.Log(i);
        }
    }
}
