using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortTester : MonoBehaviour
{
    public mergeExample[] mergeTestArray;
    MergeSorter mergeSorter;
    QuickSorter quickSorter;
    StringSorter bubbleSorter;
    public mergeExample[] mergeSortResult;
    public Text resultDisplay;
    // Start is called before the first frame update
    void Start()
    {
        mergeSorter = new MergeSorter();
        quickSorter = new QuickSorter();
        bubbleSorter = new StringSorter();
    }

    public void SortByMerge()
    {
        mergeSortResult= mergeSorter.MergeSort(mergeTestArray, 0, mergeTestArray.Length-1);
        resultDisplay.text = mergeSortResult.ToString();

    }

    public void SortByQuick()
    {
        mergeSortResult = quickSorter.QuickSort(ref mergeTestArray, 0, mergeTestArray.Length-1);
        resultDisplay.text = mergeSortResult.ToString();


    }

    public void bubbleSortByString()
    {
        mergeSortResult = bubbleSorter.bubbleSort(mergeTestArray);
        resultDisplay.text = mergeSortResult.ToString();

    }
    
}
