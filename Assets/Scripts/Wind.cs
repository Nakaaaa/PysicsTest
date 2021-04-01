using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 参考URL：http://ftvoid.com/blog/post/742

public class Wind : MonoBehaviour
{
    public GameObject target;
    private Rigidbody rb;

    public float coefficient;
    public Vector3 velocity;

    void Start()
    {
        rb = target.GetComponent<Rigidbody>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Vector3 relativeVelocity = velocity - other.attachedRigidbody.velocity;
            other.attachedRigidbody.AddForce(coefficient * relativeVelocity);
        }
    }
}
