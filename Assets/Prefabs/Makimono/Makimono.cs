using UnityEngine;

namespace MakimonoNinja.mogino.com {
    public class Makimono : PlayObject
    {
        static Vector3 BASE_POSITION = new Vector3(-4, 0, 1);

        [SerializeField] private Transform _rotateBase;
        [SerializeField] private SpriteRenderer _makimonoSprite;

        private int expanding = 0;
        private Vector2 expandDirection = new Vector2(0, 0);
        private float expandLength = 0.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        }

        private void OnTouchBackground(Vector2 position)
        {
            Debug.Log("Makimono.OnTouchBackground");
            Debug.Log(position);
        }

        override protected void PlayUpdate(float delta)
        {
            if (expanding == 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector2 localPosition = transform.InverseTransformPoint(touchPosition);
                    //Vector2 basePosition = new Vector2(transform.position.x, transform.position.y);
                    expanding = 1;
                    expandDirection = localPosition.normalized;
                    expandLength = 0.0f;

                    Debug.Log(expandDirection);

                    _rotateBase.localRotation = Quaternion.Euler(0, 0, Mathf.Atan2(expandDirection.y, expandDirection.x) * Mathf.Rad2Deg);
                    _makimonoSprite.transform.localPosition = BASE_POSITION;
                }
            }
            else
            {
                expandLength += 16f * delta * expanding;
                _makimonoSprite.transform.localPosition = BASE_POSITION + new Vector3(expandLength, 0, 0);
                if (expandLength > 8.0f)
                {
                    expanding = -1;
                }
                else if (expandLength < 0.0f)
                {
                    expanding = 0;
                    _makimonoSprite.transform.localPosition = BASE_POSITION;
                }
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Makimono.OnTriggerEnter");
            Debug.Log(other);
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Makimono.OnCollisionEnter");
            Debug.Log(collision);
        }
    }
}
