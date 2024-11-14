using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject[] _button;
    [SerializeField] private float _spacing = 2.0f;
    [SerializeField] private int _columns = 4; // N�mero de columnas
    [SerializeField] private int _rows = 3; // N�mero de filas
    [SerializeField] private float _verticalOffset;
    [SerializeField] private float _horizontalOffset;

    void Start()
    {
        // Aseguramos que el tama�o de _button sea suficiente para cubrir todas las filas y columnas.
       // Generar las filas y columnas
        for (int row = 0; row < _rows; row++)
        {
            for (int column = 0; column < _columns; column++)
            {
                // Calculamos la posici�n de cada bot�n (filas y columnas)
                Vector3 position = transform.position + transform.right * (column * _spacing) + transform.right* _horizontalOffset + transform.up * (-row * _spacing) + transform.up * _verticalOffset; ;
                int randomIndex = Random.Range(0, _button.Length);
                // Instanciamos el bot�n en la posici�n calculada
                GameObject newButton = Instantiate(_button[randomIndex], position, transform.rotation);

                // Establecemos el padre del bot�n
                newButton.transform.SetParent(this.transform);
                

                           }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DataButton(Image typeData)
    {
        typeData.gameObject.SetActive(true);
    }
}
