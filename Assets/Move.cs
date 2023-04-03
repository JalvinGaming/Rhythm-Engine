using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public float Gravity;
    public bool HasInputYet;
    public float YVel;
    public GameObject ColBall;
    public GameObject badBall;
    public GameObject ByeBall;
    private void Start()
    {
        HasInputYet = false;
        ColBall = GameObject.Find("Baller");
        badBall = GameObject.Find("Ballend");
        ByeBall = GameObject.Find("ByeBall");
        Speed = GameObject.Find("Main Camera").GetComponent<Variables>().BPM / 120 * 12;
    }
    private void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0);
        if (HasInputYet)
        {
            YVel -= Gravity * Time.deltaTime;
            transform.Translate(0, YVel * Time.deltaTime, 0);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == ColBall)
            gameObject.name = "Ball";
        if (collision.gameObject == badBall)
            gameObject.name = "BadBall";
        if (collision.gameObject == ByeBall)
            Destroy(gameObject);
    }
}
