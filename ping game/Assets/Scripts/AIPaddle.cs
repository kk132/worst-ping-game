using UnityEngine;

public class AIPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate(){
        if (ball.velocity.x > 0.0f){
            if (ball.position.y > transform.position.y){
                rigidBody.AddForce(Vector2.up * speed);
            }
            else if (ball.position.y < transform.position.y){
                rigidBody.AddForce(Vector2.down * speed);
            }
            else{
                if (transform.position.y > 0.0f){
                    rigidBody.AddForce(Vector2.down * speed);
                }
                else if (transform.position.y < 0.0f){
                    rigidBody.AddForce(Vector2.up * speed);
                }
            }
        }
    }
}
