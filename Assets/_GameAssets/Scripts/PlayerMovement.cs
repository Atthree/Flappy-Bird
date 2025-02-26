using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private GameObject _deathScreen;
    [SerializeField] private AudioSource _dieSFX;
    [SerializeField] private AudioSource _pointSFX;
    [SerializeField] private AudioSource _flySFX;
    private Rigidbody2D _playerRb;

    private void Start()
    {
        Time.timeScale = 1;
        _deathScreen.SetActive(false);
        _playerRb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _playerRb.linearVelocity = Vector2.up * _jumpForce;
            _flySFX.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Scoring"))
        {
            FindAnyObjectByType<GameManager>().IncreaseScore();
            _pointSFX.Play();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            _dieSFX.Play();
            _deathScreen.SetActive(true);
            Time.timeScale = 0;
        }        
    }
}
