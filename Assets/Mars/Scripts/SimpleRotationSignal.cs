using UnityEngine;

public class SimpleRotationSignal : MonoBehaviour
{
    bool rotating = false;

    void Update()
    {
        if (!rotating) return;

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            Quaternion.Euler(0, 90, 0),
            90f * Time.deltaTime);

        if (Quaternion.Angle(transform.rotation, Quaternion.Euler(0, 90, 0)) < 0.1f)
            rotating = false;
    }

    public void ApplyRotation()
    {
        rotating = true;
    }
}
