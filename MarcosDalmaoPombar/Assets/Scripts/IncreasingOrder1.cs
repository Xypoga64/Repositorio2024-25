using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    public int Numero_1;
    public int Numero_2;
    public int Numero_3;

    // Start is called before the first frame update
    void Start()
    {
    OrdenIncremento();
    }

    private void OrdenIncremento()
    {


        if (Numero_1 < Numero_2)
        {
            if (Numero_2 < Numero_3)
            {
                Debug.Log(Numero_1 + "\t" + Numero_2 + "\t" + Numero_3 + " Es Creciente");
            }
            else
            {
                Debug.Log("Los numeros introducidos no son crecientes");
            }
        }
        else
        {
            Debug.Log("Los numeros introducidos no son crecientes");

        }

    }
}
