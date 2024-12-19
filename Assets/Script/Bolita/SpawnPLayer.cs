using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script.Bolita
{
    public class SpawnPLayer : MonoBehaviour
    {
        public Transform vector1;
        public Transform vector2;
        public GameObject player;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                InstanceRandom();
            }
        }

        private void InstanceRandom()
        {
            float PosPlayerX = Random.Range(
                Mathf.Max(vector1.position.x, vector2.position.x),
                Mathf.Min(vector1.position.x, vector2.position.x));
        
            float PosPlayerY = Random.Range(
                Mathf.Max(vector1.position.y, vector2.position.y),
                Mathf.Min(vector1.position.y, vector2.position.y));
        
            Vector2 spawnPosition = new Vector2(PosPlayerX, PosPlayerY);
            Instantiate(player, spawnPosition, Quaternion.identity);
        }
    }
}
