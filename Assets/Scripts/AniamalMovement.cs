using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniamalMovement : MonoBehaviour
{   

    public float moveSpeed = 2f;
    public float destroyAnimal = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if(transform.position.z <destroyAnimal)
        {
            Destroy(gameObject);
        }
    }
}