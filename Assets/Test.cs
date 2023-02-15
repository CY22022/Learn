using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Type type = Type.GetType("Mono.Runtime");
        if (type != null)
        {
            MethodInfo displayName = type.GetMethod("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
            if (displayName != null)
                Debug.Log(displayName.Invoke(null, null));
        }
    }
    // Update is called once per frame
    void Update()
    {
     
        Sprite sprite = GetComponent<Sprite>();

    }
}
