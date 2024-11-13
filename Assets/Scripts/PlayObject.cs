using System.Runtime.CompilerServices;
using UnityEngine;

namespace MakimonoNinja.emuogi.com {
    public class PlayObject : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }
    
        // Update is called once per frame
        void Update()
        {
            float delta = Time.deltaTime;
            PlayUpdate(delta);
        }

        virtual protected void PlayUpdate(float delta)
        {
            Debug.Log("PlayingObject.PlayUpdate");
        }

        protected void RemoveFromPlay()
        {
            Destroy(gameObject);
        }
    }
}
