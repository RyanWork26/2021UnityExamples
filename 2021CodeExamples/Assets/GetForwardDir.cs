using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GetForwardDir : MonoBehaviour
{
    public Vector3 dir;
    public Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        if (tf != null)
        {
            dir = tf.forward;
        }

    }
}
