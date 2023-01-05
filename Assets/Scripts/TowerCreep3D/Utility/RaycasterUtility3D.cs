using UnityEngine;
using UnityEngine.InputSystem;

namespace TowerCreep3D.Utility
{
    public class RaycasterUtility : MonoBehaviour
    {
        [SerializeField] private LayerMask layerMask;

        private Camera camera;
        private int hitCount;
        private RaycastHit[] hits;

        private void Awake()
        {
            camera = Camera.main;
            hits = new RaycastHit[10];
        }

        private void Update()
        {
            Vector2 mPos = Mouse.current.position.ReadValue();
            Ray ray = camera.ScreenPointToRay(mPos);


            hitCount = Physics.RaycastNonAlloc(ray, hits, float.MaxValue, layerMask);

            if (hitCount > 0)
            {
                for (int i = 0; i < hitCount; i++)
                {
                    RaycastHit hit = hits[i];
                    Debug.Log("Hit-" + i + ": " + hit.collider.gameObject.name);
                }
            }
        }

        private void OnDrawGizmos()
        {
            if (hits != null && hitCount > 0)
            {
                Gizmos.color = Color.red;
                for (int i = 0; i < hitCount; i++)
                {
                    RaycastHit hit = hits[i];
                    Gizmos.DrawSphere(
                        hit.point,
                        0.5f
                    );
                }
            }
        }
    }
}