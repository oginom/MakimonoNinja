using UnityEngine;

namespace MakimonoNinja.emuogi.com
{
    public class Ninja : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _rigidbody2D.AddForceX(100);
        }
    
        // Update is called once per frame
        void Update()
        {
            _rigidbody2D.linearVelocityX = 5;
        }
    }
}
