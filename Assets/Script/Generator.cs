using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Script
{
    public class Generator : MonoBehaviour
    {
        [SerializeField] private GameObject[] button;
        [SerializeField] private float spacing = 100f;
        [SerializeField] private int columns = 4; // N�mero de columnas
        [SerializeField] private int rows = 3; // N�mero de filas
        [SerializeField] private float verticalOffset;
        [SerializeField] private float horizontalOffset;
        public Image panel;
        public bool lose, win;
        public static Generator instance;

        private void Awake()
        {
            instance = this;
            //if(instance != null )
            //{
            //    instance.
            //}
        }

        void Start()
        {
            // Aseguramos que el tamaño de button sea suficiente para cubrir todas las filas y columnas.
            // Generar las filas y columnas
            lose = false;
            if (panel != null)
            {
                panel.gameObject.SetActive(false);
            }
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    // Calculamos la posici�n de cada bot�n (filas y columnas)
                    Vector3 position = transform.position + transform.right * (column * spacing) + transform.right* 
                        horizontalOffset + transform.up * (-row * spacing) + transform.up * verticalOffset;
                    
                    int randomIndex = Random.Range(0, button.Length);
                    // Instanciamos el bot�n en la posici�n calculada
                    GameObject newButton = Instantiate(button[randomIndex], position, transform.rotation);

                    // Establecemos el padre del bot�n
                    newButton.transform.SetParent(this.transform);
                }
            }
        }

        public void Update()
        {
        }

        public void id(int data)
        {
            if(data == 1)
            {
                if (panel != null)
                {
                    panel.gameObject.SetActive(true);
                }
                lose = true;
                Debug.Log("Perdiste: " + data);

                // Asegurarse de que el Manager se entere de la pérdida
                Manager manager = FindObjectOfType<Manager>();
                if (manager != null)
                {
                    manager.LoseCondition(lose);
                }
            }
           
            
        }
        public void DataButton(Image typeData)
        {

            typeData.gameObject.SetActive(true);
            
        }

  

    }
}
