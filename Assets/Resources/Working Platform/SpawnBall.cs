using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ballspawn;
    public GameObject Trigger;
    public Transform ballspawner;
    public AudioSource BallAudio;
    public AudioClip Ballspawnaudio;
    private void Start()
    {
        Trigger = GameObject.Find("Collider");
        ballspawner = GameObject.Find("Ball Spawner").transform;
        BallAudio = GameObject.Find("BallAudio").GetComponent<AudioSource>();
        Ballspawnaudio = Resources.Load<AudioClip>("Working Platform/huh");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Trigger)
        {
            Instantiate(Ballspawn, ballspawner);
            BallAudio.PlayOneShot(Ballspawnaudio);
        }
    }
}
