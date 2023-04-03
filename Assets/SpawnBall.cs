using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ballspawn;
    public GameObject Trigger;
    public Transform ballspawner;
    private void Start()
    {
        Trigger = GameObject.Find("Collider");
        ballspawner = GameObject.Find("Ball Spawner").transform;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Trigger)
        {
            Instantiate(Ballspawn, ballspawner);
        }
    }
}
