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
    /// <returns>0.05 * 風速^2</returns>
    private float WindPressure(int speed)
    {
        int windSpeed = speed;

        float result = DEFAULT_VALUE * (windSpeed^2);
        return result;
    }

    /// <summary>
    /// 体積
    /// </summary>
    /// <returns>x * y * z</returns>
    private float Taiseki()
    {
         float x = targetRB.transform.lossyScale.x;
         float y = targetRB.transform.lossyScale.y;
         float z = targetRB.transform.lossyScale.z;

        return x * y * z;
    }

    /// <summary>
    /// 風力
    /// </summary>
    /// <returns>風圧 * 体積 / 時間^2</returns>
    private float WindPower()
    {
        return WindPressure(speed) + Taiseki() / (1 ^ 2);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log(WindPower());
            //targetRB.AddForce(new Vector3(WindPressure(speed), 0.0f, 0.0f), ForceMode.Impulse);
            targetRB.AddForce(new Vector3(WindPower(), 0.0f, 0.0f), ForceMode.Impulse);
        }
    }

}
