using UnityEngine;

public class FollowCamra : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smothFactor;


    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 tragetPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, tragetPosition, smothFactor*Time.fixedDeltaTime);
        transform.position = smoothedPosition;

    }
}
