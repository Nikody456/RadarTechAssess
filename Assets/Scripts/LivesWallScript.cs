using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesWallScript : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        transform.position = new Vector3(transform.position.x, 2, transform.position.z + Random.Range(25, 50));
    }

    private void OnTriggerEnter(Collider other)
    {
        UIManager.instance.DecreaseLives();
    }
}
