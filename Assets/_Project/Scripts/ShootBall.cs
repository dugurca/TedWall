using UnityEngine;

namespace Assets._Project.Scripts
{
    public class ShootBall : MonoBehaviour
    {
        public GameObject BallPrefab;

        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        void Shoot()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject ball = Instantiate(BallPrefab);
                ball.transform.position = transform.position;
                Vector3 forceDir = hit.point - transform.position;
                ball.GetComponent<Rigidbody>().velocity = forceDir * 5f;
            }
        }
    }
}
