using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 4f;

    private Rigidbody2D _rb;
    private Vector2 _movementInput;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        _movementInput = new Vector2(horizontalInput, verticalInput).normalized;
    }

    private void FixedUpdate()
    {
        _rb.velocity = _movementInput * _moveSpeed;
    }
}
