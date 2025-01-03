using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int plScore;
    private int AiScore;
    public Paddle PlayerPaddle;
    public Paddle AiPaddle;
    public Ball ball;
    public Text PlayerScoretxt;
    public Text AiScoretxt;



    public void PLScore()
    {
        plScore++;
        PlayerScoretxt.text = plScore.ToString();
        PlayerPaddle.ResetPaddle();
        AiPaddle.ResetPaddle();
        ball.ballReset();
    }
    public void AIScore()
    {
        AiScore++;
        AiScoretxt.text = AiScore.ToString();
        PlayerPaddle.ResetPaddle();
        AiPaddle.ResetPaddle();
        ball.ballReset();
    }
    
}
