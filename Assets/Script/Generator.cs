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

        public void id(int data)
        {
            if(data == 1)
            {
             panel.enabled = true;

            }
           Debug.Log("Perdiste" + data);
            
        }
        public void DataButton(Image typeData)
        {

            typeData.gameObject.SetActive(true);
            
        }

  

    }
}
