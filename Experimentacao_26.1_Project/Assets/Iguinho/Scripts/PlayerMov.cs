using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float moveSpeed;
    float direction;
    Rigidbody2D rb;

     InputPlayer control;


    private void OnEnable()
    {
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }
    private void Awake()
    {
        control = new InputPlayer();
    }

    void InputPlayer()
    {
        direction = control.Iguinho.Move.ReadValue<float>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       InputPlayer();   
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.linearVelocityX = (direction * (moveSpeed * Time.deltaTime));
       // rb.LinearVelocity = new Vector2 (rb.position.x + direction * (moveSpeed * Time.deltaTime), rb.position.y));
      
    }
}
