using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    public int Numero_1;
    public int Numero_2;
    public int Numero_3;




    // Start is called before the first frame update
    void Start()
    {
        DePequeAGrande();
    }

    private void DePequeAGrande()
    {
        if (Numero_1 > Numero_2)
        {
            if (Numero_2 > Numero_3)
            {
                Debug.Log(Numero_3 + "\t" + Numero_2 + "\t" + Numero_1);
            }
            else
            {
                if (Numero_1 < Numero_3)
                {
                    Debug.Log(Numero_2 + "\t" + Numero_1 + "\t" + Numero_3);
                }
                else
                {
                    Debug.Log(Numero_2 + "\t" + Numero_3 + "\t" + Numero_1);
                }

            }
        }
        else
        {
            if (Numero_1 > Numero_3)
            {
                Debug.Log(Numero_3 + "\t" + Numero_1 + "\t" + Numero_2);
            }
            else
            {
                if (Numero_2 < Numero_3)
                {
                    Debug.Log(Numero_1 + "\t" + Numero_2 + "\t" + Numero_3);
                }
                else
                {
                    Debug.Log(Numero_1 + "\t" + Numero_3 + "\t" + Numero_2);
                }

            }
        }

    }
}