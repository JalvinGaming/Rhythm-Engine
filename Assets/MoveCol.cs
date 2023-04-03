using UnityEngine;

public class MoveCol : MonoBehaviour
{
    public float Speed;
    private void Start()
    {
        Speed = GameObject.Find("Main Camera").GetComponent<Variables>().BPM / 60;
    }
    private void Update()
    {
        transform.Translate(-Speed * Time.deltaTime, 0, 0);
    }
}
