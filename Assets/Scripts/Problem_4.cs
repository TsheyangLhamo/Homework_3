using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    /* Create a List of numbers that are odd and are divisible by the number 7 between 1 and 144.
     * You should have a list that looks like this 7, 21, 35, 49, 63, 77, 91, 105, 119, 133
     * Declare an array that's half the size of the list and save every other number from the list into the array 
     * You should have a array that looks like this 7, 35, 63, 91, 119
    */
    void Start()
    {
        List<int> list = new List<int>();
        for (int i = 0; i<144; i++)
        {
            if (i % 2 != 0 && i % 7==0)
            {
                list.Add(i);
            }
        }
        int[] numbers = new int[list.Count/2];
        int n = 0;
        for (int i = 0; i < list.Count;i++) 
        {
            if (i%2 ==0)
            {
                numbers[n] = list[i];
                n++; 
            }
        }

    
    }
}
