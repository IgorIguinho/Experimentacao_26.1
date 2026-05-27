using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float moveSpeed;
    float direction;
    Rigidbody2D rb;

     InputPlayer control;

    private void Awake()
    {
        control = new InputPlayer();
        control.Enable();

        control.Iguinho.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePlayer();
    }
    
    void MovePlayer()
    {
  
        rb.AddForce (new Vector2(moveSpeed * direction, 0));
      
    }
}
