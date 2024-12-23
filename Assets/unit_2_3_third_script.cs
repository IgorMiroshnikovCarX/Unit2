using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_2_3_third_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        short s = 0;
        int i = 0;
        long l = 0;
        float f = 0;
        double d = 0;

        object o = d;
        double d2 = (double)o;

        i = (int)l;
        l = i;
        ushort a = 15050;
        byte b = (byte)a;

        TestFunk(ref i);

        var c = 0f;

        if (o!= null)
        {
            int i2 = (int)o;
        }

        int[] array = new int[10000];

        List<int> list = new List<int>(80);
    }

    public void TestFunk(ref int i)
    {
        i = 10;
        Debug.Log(i);
    }

    /*public void Exp()
    {
        int i = 1;
        object o = i;
        int j = (int)o;
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
