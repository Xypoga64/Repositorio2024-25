using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetMultiple3();
    }

    private void GetMultiple3 ()
    {


        int i = 3;
        
        while (i < 100)
        {

            Debug.Log(i);
            i = i + 3 ; 




        }



    }

}
