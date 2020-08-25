using Assets.Scripts;
using UnityEngine;

public class Coin : FallingItem
{
    public override void Move()
    {
        Vector3 newPosition = Vector3.Lerp(startPosition, targetPosition, fallTime);
        transform.position = newPosition;
        fallTime += Time.deltaTime * (rocket.SpeedY + SpeedY);

        if (newPosition.y < -cameraSize)
            Destroy(gameObject, 0.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }
}
