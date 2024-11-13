using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

namespace MakimonoNinja.emuogi.com {
    public class PlayManager : MonoBehaviour
    {
        public static PlayManager Instance { get; private set; }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Instance = this;
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
