using Assets.Scripts;
using UnityEngine;

public class Cloud : FallingItem
{
    public override void Move()
    {
        Vector3 newPosition = Vector3.Lerp(startPosition, targetPosition, fallTime);
        transform.position = newPosition;
        fallTime += Time.deltaTime * (rocket.SpeedY);

        if (newPosition.y < -cameraSize)
            Destroy(gameObject, 0.5f);
    }

    private void FixedUpdate()
    {
        Move();
    }

}
