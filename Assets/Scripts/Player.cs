using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _jumpForce = 800f;
    private float moveSpeed = 17.0f;

    private bool _canJump = true;

    [SerializeField] private AudioClip _jumpSound;
    private AudioSource _audioSource;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canJump)
        {
            _rigidbody.AddForce(new Vector2(_rigidbody.velocity.x, _jumpForce));
            _canJump = false;
            _audioSource.PlayOneShot(_jumpSound);
            StartCoroutine("JumpCoroutine");
        }

        if (Input.GetKey(KeyCode.D))
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
    }

    private IEnumerator JumpCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        _canJump = true;
    }
}
