using System;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject _matchingDoor;

    private AudioSource _audioSource;
    private BoxCollider2D _boxCollider;
    private SpriteRenderer _spriteRenderer;
    private ParticleSystem _particleSystem;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
        _particleSystem = GetComponentInChildren<ParticleSystem>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _audioSource.Play();
            Destroy(_matchingDoor);

            _particleSystem.gameObject.SetActive(false);
            _boxCollider.enabled = false;
            _spriteRenderer.enabled = false;

            Invoke("Cleanup", 1);
        }
    }

    private void Cleanup()
    {
        Destroy(gameObject);
    }
}
