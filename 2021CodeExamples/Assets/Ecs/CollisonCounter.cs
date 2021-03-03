using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisonCounter : MonoBehaviour
{
    public Text colText;
    public int colsNum;
    static CollisonCounter instance;

    public void Awake()
    {
        instance = this;
    }

    public static CollisonCounter Instance()
    {
        return instance;
    }

    public void AddCol()
    {

        colsNum++;
    }

    // Update is called once per frame
    void Update()
    {
        colText.text = colsNum.ToString();
        
    }
}
