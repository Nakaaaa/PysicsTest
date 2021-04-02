using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 参考URL：https://www.youtube.com/watch?v=_7b2ur3HQ08

public class Wind2 : Common
{
    public int speed = 100;     // 風速
    private const float DEFAULT_VALUE = 0.05f; // 基準値

    /// <summary>
    /// 風圧を算出する。
    /// </summary>
    private float WindPressure(int speed)
    {
        int windSpeed = speed;

        float result = DEFAULT_VALUE * (windSpeed^2);
        return result;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            targetRB.AddForce(new Vector3(WindPressure(speed), 0.0f, 0.0f), ForceMode.Impulse);
        }
    }

}
