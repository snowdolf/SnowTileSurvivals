using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float offsetX = 0f;
    public float offsetY = 0f;
    public float offsetZ = -10f;

    Vector3 cameraPosition;
    float cameraSpeed = 10f;

    public GameObject cameraTarget;

    private void LateUpdate()
    {
        cameraPosition.x = cameraTarget.transform.position.x + offsetX;
        cameraPosition.y = cameraTarget.transform.position.y + offsetY;
        cameraPosition.z = cameraTarget.transform.position.z + offsetZ;

        transform.position = Vector3.Lerp(transform.position, cameraPosition, cameraSpeed * Time.deltaTime);
    }
}