using UnityEngine;

public class ChildRotation : MonoBehaviour
{
    public void LookAtDirection(Vector3 direction)
    {
        if (direction == Vector3.zero) return;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        Vector3 eulerAngles = targetRotation.eulerAngles;
        transform.rotation = Quaternion.Euler(0f, eulerAngles.y, 0f);
    }
}
