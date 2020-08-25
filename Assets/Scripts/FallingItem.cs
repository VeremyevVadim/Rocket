using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace Assets.Scripts
{
    public abstract class FallingItem : MonoBehaviour
    {
        protected float cameraSize;

        protected Rocket rocket;

        protected float speedY = 2;
        public float SpeedY { get { return speedY / 10; } set { } }

        protected Vector3 startPosition;
        protected Vector3 targetPosition;
        protected float fallTime = 0;

        void Start()
        {
            cameraSize = Camera.main.orthographicSize;
            rocket = FindObjectOfType<Rocket>();

            BoxCollider2D itemCollider = GetComponent<BoxCollider2D>();
            startPosition = transform.position;

            float spawnerCameraDist = startPosition.y - cameraSize;
            float cameraHeight = cameraSize * 2;
            float itemHeight = itemCollider.size.y / 2 * transform.localScale.y;

            targetPosition = startPosition - Vector3.up * (spawnerCameraDist + cameraHeight + itemHeight);
        }

        public abstract void Move();
    }
}
