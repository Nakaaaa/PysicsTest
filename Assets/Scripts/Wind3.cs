using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 参考URL：http://ftvoid.com/blog/post/752

public class Wind3 : Common
{
    public float coefficient;   // 空気抵抗係数
    public Vector3 velocity;    // 風速

    //void OnTriggerStay(Collider col)
    //{
    //    if (col.rigidbody == null)
    //    {
    //        return;
    //    }

    //    // 相対速度計算
    //    var relativeVelocity = velocity - col.rigidbody.velocity;

    //    // 空気抵抗を与える
    //    col.rigidbody.AddForce(coefficient * relativeVelocity);
    //}

    private void OnTriggerStay(Collider other)
    {
        // 相対速度計算
        var relativeVelocity = velocity - other.attachedRigidbody.velocity;
        other.attachedRigidbody.AddForce(coefficient * relativeVelocity);
    }
}
