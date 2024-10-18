using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{

    public int Number;



    // Start is called before the first frame update
    void Start()
    {

        AdditionNumber();


    }
    private void AdditionNumber()
    {


        int i = 0;
        int j = 0;

        while (j < Number)
        {
            j = j + 1;
            i = i + j;

            if (j == Number)

                Debug.Log(i);

        }
    }
}
