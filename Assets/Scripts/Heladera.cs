using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladera : MonoBehaviour
{
    public string gustoDeHelado;
    public int cantidadEnGramos;
    float precioPorGramo = 1.25f;  // Precio por gramo sin descuento
    int cantidadMinima = 250;
    int cantidadMaxima = 3000;
    float precioFinal;

    // Start is called before the first frame update
    void Start()
    {
        if (gustoDeHelado != "CHO" && gustoDeHelado != "FRU" && gustoDeHelado != "DDL")
        {
            Debug.Log("Código de gusto no válido.");
            return; 
        }

        if (cantidadEnGramos < cantidadMinima || cantidadEnGramos > cantidadMaxima)
        {
            Debug.Log("Cantidad de helado no válida. Debe ser entre 250 y 3000 gramos.");
            return;
        }

        precioFinal = cantidadEnGramos * precioPorGramo;

        if (gustoDeHelado == "FRU")
        {
            precioFinal *= 0.9f;  // Aplicar un 10% de descuento
        }

        Debug.Log("El precio del pedido es: $" + precioFinal);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
