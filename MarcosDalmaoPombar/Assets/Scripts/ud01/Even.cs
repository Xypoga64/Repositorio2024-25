using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
        void Start()
    {
        GetEvenNumber();
    }

    private void GetEvenNumber ()
    {


        int i = 0;
        
        while (i < 101)
        {

            Debug.Log(i);
            i = i + 2 ; 




        }



    }

}
