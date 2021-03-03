using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSorter 
{
    //doing a buble sort this time

    public mergeExample[] bubbleSort(mergeExample[] sortArray)
    {
        mergeExample[] newArray = new mergeExample[sortArray.Length];
        int lowestIndex = 0;
        for (int i = 0; i < sortArray.Length; i++)
        {
            lowestIndex = i;
            for (int j = i+1; j < sortArray.Length; j++)
            {
                if (sortArray[lowestIndex].name.CompareTo(sortArray[j].name) > 0)
                {
                    lowestIndex = j;
                }

            }
            mergeExample temp = sortArray[i];
            sortArray[i] = sortArray[lowestIndex];
            sortArray[lowestIndex] = temp;
        }

        return sortArray;
    }



    public int compare(string s1, string s2)
    {


        return 0;
    }
}
