using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 0, 5 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
