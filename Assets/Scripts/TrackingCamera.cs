using UnityEditor.Rendering.Universal;
using UnityEngine;

namespace MakimonoNinja.emuogi.com {
    public class TrackingCamera : MonoBehaviour
    {
        [SerializeField] private Transform _trackingTarget;
        [SerializeField] private Rect trackingArea = new Rect(-5, -3, 0, 6);
        void Start()
        {
        }

        void LateUpdate()
        {
            float newX = transform.position.x;
            float newY = transform.position.y;
            Vector2 offset = _trackingTarget.position - transform.position;
            if (offset.x < trackingArea.x)
            {
                newX = _trackingTarget.position.x - trackingArea.x;
            }
            else if (offset.x > trackingArea.x + trackingArea.width)
            {
                newX = _trackingTarget.position.x - trackingArea.x - trackingArea.width;
            }
            if (offset.y < trackingArea.y)
            {
                newY = _trackingTarget.position.y - trackingArea.y;
            }
            else if (offset.y > trackingArea.y + trackingArea.height)
            {
                newY = _trackingTarget.position.y - trackingArea.y - trackingArea.height;
            }
            transform.position = new Vector3(newX, newY, transform.position.z);
        }
    }
}
