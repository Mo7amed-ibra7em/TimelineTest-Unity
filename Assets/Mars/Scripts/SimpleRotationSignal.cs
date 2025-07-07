using UnityEngine;

public class SimpleRotationSignal : MonoBehaviour
{
    public Vector3 targetRotation = new Vector3(0, 90, 0);
    public float rotationSpeed = 90f;
    private bool rotating = false;
    void Update()
    {
        if (!rotating) return;

        Quaternion target = Quaternion.Euler(targetRotation);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, rotationSpeed * Time.deltaTime);

        if (Quaternion.Angle(transform.rotation, target) < 0.1f)
        {
            transform.rotation = target;
            rotating = false;
        }
    }
    public void ApplyRotation()
    {
        rotating = true;
    }
}
