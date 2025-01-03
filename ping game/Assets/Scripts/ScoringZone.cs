using UnityEngine;
using UnityEngine.EventSystems;
    

public class NewMonoBehaviourScript : MonoBehaviour
{
    public EventTrigger.TriggerEvent ScoreTrigger;

    public Ball ball;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball = collision.GetComponent<Ball>();
        if (ball != null)
        {
            BaseEventData eventdata = new BaseEventData(EventSystem.current);
            ScoreTrigger.Invoke(eventdata);
        }
    }
}
