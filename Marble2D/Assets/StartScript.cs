using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   

        Destroy(gameObject, 5);
    }
}
