using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSorter
{

    public mergeExample[] QuickSort(ref mergeExample[] sortArray,int start, int end)
    {
        if (start < end)
        {
            int sortPoint= Sort(ref sortArray, start, end);
            QuickSort(ref sortArray, start, sortPoint);
            QuickSort(ref sortArray, sortPoint+1, end);
            
        }
        return sortArray;

    }

    public int Sort(ref mergeExample[] sortArray,int start, int end)
    {
        int sortPointValue = sortArray[start].id;
        int sortPoint = start;
        int leftIndex = start;
        int rightIndex = end;

        while (leftIndex<rightIndex&& sortArray[leftIndex].id>sortPointValue)
        {


            leftIndex++;
        }
        while (rightIndex > leftIndex && sortArray[rightIndex].id > sortPointValue)
        {


            rightIndex--;
        }
        mergeExample temp = sortArray[sortPoint];
        Debug.Log("leftIndex" + leftIndex + " right" + rightIndex);
        if (sortArray[leftIndex].id < sortArray[rightIndex].id)
        {
            sortArray[sortPoint] = sortArray[leftIndex];
            sortArray[leftIndex] = temp;
            sortPoint = leftIndex;
        }
        else
        {
            sortArray[sortPoint] = sortArray[rightIndex];
            sortArray[rightIndex] = temp;
            sortPoint = rightIndex;
        }
        return sortPoint;

    }
    
}
