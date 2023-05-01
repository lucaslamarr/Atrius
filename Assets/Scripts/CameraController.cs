using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 _maxPosition;
    private Vector3 _minPosition;

    private void Start()
    {
        _maxPosition = gameObject.transform.position;
        _minPosition = gameObject.transform.position + new Vector3(0, 0, -30);
    }

    private void Update()
    {
        if (Input.mouseScrollDelta.y < 0)
        {
            if (gameObject.transform.position.z > _minPosition.z)
            {
                gameObject.transform.position -= new Vector3(0, 0, 1);
            }
        }
        else if (Input.mouseScrollDelta.y > 0)
        {
            if (gameObject.transform.position.z < _maxPosition.z)
            {
                gameObject.transform.position += new Vector3(0, 0, 1);
            }
        }
    }
}
