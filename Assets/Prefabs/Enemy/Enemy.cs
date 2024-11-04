using UnityEngine;

namespace MakimonoNinja.mogino.com
{
    public class Enemy : PlayObject
    {
        [SerializeField] private SpriteRenderer _enemySprite;

        private bool alive = true;
        private float deadTime = 0.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }
    
        // Update is called once per frame
        override protected void PlayUpdate(float delta)
        {
            if (!alive) {
                transform.localPosition += new Vector3(0, -10, 0) * delta;
                deadTime += delta;
                if (deadTime > 1.0f) {
                    RemoveFromPlay();
                }
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (!alive) return;
            Debug.Log("Enemy.OnTriggerEnter2D");
            Debug.Log(other);

            _enemySprite.flipY = true;
            alive = false;
        }
    }
}
