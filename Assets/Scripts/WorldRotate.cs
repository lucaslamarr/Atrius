using UnityEngine;

public class WorldRotate : MonoBehaviour
{
    private Vector3 _previousPositon = Vector3.zero;
    private Vector3 _positionDelta = Vector3.zero;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _positionDelta = Input.mousePosition - _previousPositon;
            if(Vector3.Dot(transform.up, Vector3.up) >= 0)
                transform.Rotate(transform.up, -Vector3.Dot(_positionDelta / 2, Camera.main.transform.right), Space.World);
            else
                transform.Rotate(transform.up, Vector3.Dot(_positionDelta / 2, Camera.main.transform.right), Space.World);

            transform.Rotate(Camera.main.transform.right, Vector3.Dot(_positionDelta / 2, Camera.main.transform.up), Space.World);
        }

        _previousPositon = Input.mousePosition;
    }
}
