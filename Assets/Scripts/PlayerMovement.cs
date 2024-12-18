using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float characterMovement;
    public GameObject foodProjectil;
    public Transform shootPoint;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
          Movement(Vector3.right);  
        }

        if(Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.left);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Shoot();
        }


    }

    private void Movement(Vector3 direction){
        transform.Translate(direction * characterMovement * Time.deltaTime);
    }

    private void Shoot()
    {
        Instantiate(foodProjectil, shootPoint.position, Quaternion.identity);
    }
}
