using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common : MonoBehaviour
{

    public GameObject target;       // 衝突対象
    protected Rigidbody targetRB;      // 衝突対象用Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        targetRB = target.GetComponent<Rigidbody>();
    }
}
