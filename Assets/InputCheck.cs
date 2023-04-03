using UnityEngine;

public class InputCheck : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Colliderboi;
    public bool IsCol;
    private void Update()
    {
        Ball = GameObject.Find("Ball");
        Colliderboi = GameObject.Find("Collider");
        if (IsCol && Input.GetKeyDown(KeyCode.A))
        {
            Ball.GetComponent<Move>().HasInputYet = true;
            Ball.name = "BallFinished";
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Colliderboi)
            IsCol = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Colliderboi)
            IsCol = false;
    }
}