using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rigidBody;
    public float speed = 10f;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    public void ResetPaddle()
    {
        rigidBody.position= new Vector2 (rigidBody.position.x, 0.0f);
        rigidBody.velocity= Vector2.zero;
    }
}
