using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit_2_2_second_script : MonoBehaviour
{
    // Start is called before the first frame update
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Debug.Log(street + ", " + number);
            }
        }
    
    void Start()
    {
        /*int a = 5;
        int b = 5;
        int c = 10;*/

        /*if (a < b)
        {
            Debug.Log("Число " + b + " больше числа " + a);
        }*/

        /*if (a < b && c > b)
        {
            Debug.Log("Число " + c + " больше всех чисел ");
        }*/

        /*if (b < a)
        {
            Debug.Log("Число " + b + " больше числа " + a);
        }
        else
        {
            Debug.Log("Число " + b + " меньше числа " + a);
        }*/

        /*if (b > a)
        {
            Debug.Log("Число " + b + " больше числа " + a);
        }
        else if (b < a)
        {
            Debug.Log("Число " + b + " меньше числа " + a);
        }
        else
        {
            Debug.Log("Число " + b + " равно числу " + a);
        }*/

        /*for (int i = 1; i < 10; i++)
        {
            Debug.Log(i);
        }*/
        
        /*int i = 0;
        while (i <= 10)
        {
            Debug.Log(i);
            i++;
        }*/
        
        /*int[] numbers = new int[5];
        int[] numbers2 = {5, 6, 7, 8, 9};
        numbers2[4] = 15;
        Debug.Log(numbers2[4]);*/

        /*void HelloWorld()
        {
            Debug.Log("Hello World!");
        }

        HelloWorld();

        void Sum(int a, int b)
        {
            int sum = a+ b;
            Debug.Log(sum);
        }

        Sum(5, 7);

        void Human(string name, int age)
        {
            Debug.Log(name + ", " + age);
        }

        Human("Alexey", 25);*/

            House tower = new House();
            tower.street = "Red Street";
            tower.number = 50;

            tower.Print();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
