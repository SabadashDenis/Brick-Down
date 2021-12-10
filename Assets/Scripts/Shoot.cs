using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private int damage = 1;

    public List<GameObject> balls;

    public int Damage
    {
        get { return damage; }
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void ShootBall()
    {
        StartCoroutine(ShootBallsWithDelay());
    }

    IEnumerator ShootBallsWithDelay()
    {
        for (int i = 0; i < 10; i++)
        {
            balls.Add(Instantiate(ball, ball.transform.position, ball.transform.rotation));
            yield return new WaitForSeconds(0.1f);
            balls[i].GetComponent<Rigidbody>().AddForce(ball.transform.forward * 800f, ForceMode.Acceleration);
        }
        Destroy(ball);
        yield break;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(collision.impulse.normalized * 800, ForceMode.Acceleration);
    }

}
