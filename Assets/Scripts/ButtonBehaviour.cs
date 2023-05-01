using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public void Enlarge()
    {
        transform.localScale = new Vector3(
            Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.1f, 15.0f),
            Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.1f, 15.0f),
            Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.1f, 15.0f)
            );
    }

    public void Shrink()
    {
        transform.localScale = new Vector3(
            Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.1f, 15.0f),
            Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.1f, 15.0f),
            Mathf.Lerp(transform.localScale.z, transform.localScale.z - 0.1f, 15.0f)
            );
    }
}
