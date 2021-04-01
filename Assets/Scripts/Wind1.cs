using UnityEngine;

// 参考URL：http://tyju.liblo.jp/archives/5670434.html

public class Wind1 : Common
{
    public float velocity;      // 風速

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Vector3 direction = new Vector3(15.0f, 0.0f, 0.0f);                                  // 方向
            float distance = Vector3.Distance(targetRB.transform.position, direction);          // 相対距離
            float drag = targetRB.drag;                                                         // 空気抵抗
            targetRB.AddForce(direction * drag * velocity / distance, ForceMode.Force);
        }
    }

}
