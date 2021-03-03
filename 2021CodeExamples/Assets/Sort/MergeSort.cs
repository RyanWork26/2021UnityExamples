using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct mergeExample
{
    public int id;
    public string name;

}

public class MergeSorter
{
    
    public mergeExample[] MergeSort(mergeExample[] sortArray,int start,int end)
    {
        if (start < end)
        {
            Debug.Log("start:" + start + " End:" + end);
            int middle = start + (int)Mathf.Floor((end - start) / 2);

            mergeExample[] array1= MergeSort(sortArray, start, middle);
            mergeExample[] array2= MergeSort(sortArray, middle + 1, end);

            return Merge3(array1,array2);
        }
        else
        {
            mergeExample[] newArray = new mergeExample[1];
            newArray[0] = sortArray[start];
            return newArray;
        }

    }


    public mergeExample[] Merge(mergeExample[] array1, mergeExample[] array2)
    {
        mergeExample[] newArray = new mergeExample[array1.Length + array2.Length];
        if (Compare(array1[0], array2[0]))
        {
            array1.CopyTo(newArray, 0);
            array2.CopyTo(newArray, array1.Length);
        }
        else
        {
            array2.CopyTo(newArray, 0);
            array1.CopyTo(newArray, array2.Length);
        }
        return newArray;
    }

    public mergeExample[] Merge2(mergeExample[] sortArray, int start, int mid, int end)
    {
        mergeExample[] newArray = new mergeExample[end-start+1];

        //int subArray1Length = mid - start;
        //int subArray2Length = end - mid;
        int firstIndex = start;
        int secondIndex = mid + 1;
        int newArrayIndex = 0;

        while (firstIndex <= mid && secondIndex <= end)
        {
            if (Compare(sortArray[firstIndex], sortArray[secondIndex]))
            {
                newArray[newArrayIndex] = sortArray[firstIndex];
                firstIndex++;
            }
            else
            {
                newArray[newArrayIndex] = sortArray[secondIndex];
                secondIndex++;
            }
            newArrayIndex++;

        }
        while (firstIndex <= mid)
        {
            newArray[newArrayIndex] = sortArray[firstIndex];
            firstIndex++;
            newArrayIndex++;
        }
        while (secondIndex <= end)
        {
            newArray[newArrayIndex] = sortArray[secondIndex];
            secondIndex++;
            newArrayIndex++;
        }

        return newArray;

    }

    public mergeExample[] Merge3(mergeExample[] array1, mergeExample[] array2)
    {
        mergeExample[] newArray = new mergeExample[array1.Length + array2.Length];

        int firstIndex = 0;
        int secondIndex = 0;
        int newArrayIndex = 0;

        while (firstIndex < array1.Length && secondIndex < array2.Length)
        {
            if (Compare(array1[firstIndex], array2[secondIndex]))
            {
                newArray[newArrayIndex] = array1[firstIndex];
                firstIndex++;
            }
            else
            {
                newArray[newArrayIndex] = array2[secondIndex];
                secondIndex++;
            }
            newArrayIndex++;

        }
        while (firstIndex < array1.Length)
        {
            newArray[newArrayIndex] = array1[firstIndex];
            firstIndex++;
            newArrayIndex++;
        }
        while (secondIndex < array2.Length)
        {
            newArray[newArrayIndex] = array2[secondIndex];
            secondIndex++;
            newArrayIndex++;
        }

        return newArray;

    }

    public bool Compare(mergeExample a, mergeExample b)//if a has higher or equal priority then b return true else false
    {
        

        return a.id<=b.id;
    }
    
   
}
