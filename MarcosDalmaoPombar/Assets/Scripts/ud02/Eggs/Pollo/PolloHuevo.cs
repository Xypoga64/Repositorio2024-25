using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolloHuevo : MonoBehaviour
{
    //Variables 
    public GameObject Egg;
    public Transform PosRotEgg;
    private float thrustY = 10.0f,
                  thrustZ = 30.0f,
                  timeEgg = 3.0f;



    // Update is called once per frame
    void Update()
    {

        CreateEggs();

        
    }

    private void CreateEggs()
    {
      if (Input.GetMouseButtonDown(0))
      {

        GameObject cloneEgg = Instantiate(Egg, PosRotEgg.position, PosRotEgg.rotation);

        Rigidbody rbEgg = cloneEgg.GetComponent<Rigidbody>();

        rbEgg.AddForce(Vector3.up * thrustY);

        rbEgg.AddForce(transform.forward * thrustZ);

        Destroy(cloneEgg, timeEgg);
     }
    }
}