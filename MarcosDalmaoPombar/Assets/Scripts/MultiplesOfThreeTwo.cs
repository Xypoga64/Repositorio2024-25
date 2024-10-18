using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
  void Start()
    {
        GetMultiple3and2();
    }

    private void GetMultiple3and2()
    {


        for (int i = 3; i < 100; i += 3)
        {

            for ( int j =2; j < 100; j +=2)
            {
                if (j == i)
                {
                    Debug.Log (j);
                }

            }


        }


    }

}


