using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
