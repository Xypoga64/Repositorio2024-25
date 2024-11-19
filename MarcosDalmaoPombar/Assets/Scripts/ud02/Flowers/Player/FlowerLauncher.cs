using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerLauncher : MonoBehaviour
{
    //Variables 

    public GameObject Flower;
    public Transform PosRotFlower;
    private float thrustY = 200.0f,
                  thrustZ = 230.0f,
                  timeFlower = 5.0f;



    // Update is called once per frame
    void Update()
    {

        CreateFlower();
        
        
    }
    
    private void CreateFlower()
    {
      if (Input.GetMouseButtonDown(0))
      {

        GameObject cloneFlower = Instantiate(Flower, PosRotFlower.position, PosRotFlower.rotation);

        Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();

        rbFlower.AddForce(Vector3.up * thrustY);

        rbFlower.AddForce(transform.forward * thrustZ);

        Destroy(cloneFlower, timeFlower);

    
        
      }
    }
        

      
    

}
