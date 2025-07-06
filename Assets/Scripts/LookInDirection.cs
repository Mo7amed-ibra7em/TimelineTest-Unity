using UnityEngine;

public class LookInDirection : MonoBehaviour
{
    public Vector3[] rotations;
    public int targetIndex = -1;
    public float turnSpeed = 5f;

    private Quaternion startRotation;

    private void Awake()
    {
        startRotation = transform.localRotation;
    }

    private void LateUpdate()
    {
        Quaternion rotation = targetIndex < 0 || targetIndex >= rotations.Length ? startRotation : Quaternion.Inverse(transform.parent.rotation) * Quaternion.Euler(rotations[targetIndex]);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, rotation, turnSpeed * Time.deltaTime);
    }
}
