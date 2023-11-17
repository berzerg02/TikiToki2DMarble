using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class StarGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        for (int i = 0; i < 100; i++) 
        { Instantiate(myPrefab, new Vector3(0, 15, 10), Quaternion.identity); }
        
    }

    // Update is called once per frame
    void Update()
    {

        Destroy(gameObject, 5);


    }
}
