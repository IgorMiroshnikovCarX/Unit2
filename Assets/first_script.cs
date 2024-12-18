using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class first_script : MonoBehaviour
{
    // Start is called before the first frame update
        int a = 3;
        int ab;
        //ab = 4;

        byte b;
        sbyte sb;
        short s;
        ushort us;
        int i;
        uint ui;
        long l;
        ulong ul;

        float f = 6.2f;
        double d = 5.7;

        char c = '5';

        string str = "Hello World!";

        bool bl;  
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Float variable:" + f);
        Debug.Log("Double variable:" + d);
        Debug.Log("Char variable:" + c);
        Debug.Log("String variable:" + str);
    }
}
