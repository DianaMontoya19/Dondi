using UnityEngine;

namespace Script.Bolita
{
    public class ValueValidation : MonoBehaviour
    {
        public string value;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log(value);
                Destroy(gameObject);
            }
        }
    }
}