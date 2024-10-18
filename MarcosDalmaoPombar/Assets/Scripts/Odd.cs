using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        GetOddNumber();
    }

    private void GetOddNumber ()
    {


        int i = 1;
        
        while (i < 100)
        {

            Debug.Log(i);
            i = i + 2 ; 




        }



    }



        
}
