using UnityEngine;
using System.Collections.Generic;

public class Mochila : MonoBehaviour
{

    private string[] huecos;
    private int cantidadActual;

    // Constructor: inicializa la estructura interna con capacidad máxima N
    public Mochila(int capacidadMaxima)
    {
        huecos = new string[capacidadMaxima];
        cantidadActual = 0;
    }

    // === MÉTODOS DE ACCESO ===
    public bool EstaVacia()
    {
        return cantidadActual == 0;
    }

    public bool EstaLlena()
    {
        return cantidadActual == huecos.Length;
    }

    public int VerCantidad()
    {
        return cantidadActual;
    }

    public bool Guardar(string nuevoItem)
    {
        if (EstaLlena())
        {
            return false; // No cabe más en la mochila
        }
        huecos[cantidadActual] = nuevoItem;
        cantidadActual++;
        return true;
    }

    public string SacarUltimo()
    {
        if (EstaVacia())
        {
            return null;
        }
        cantidadActual--; //Selecciona el último item
        string itemExtraido = huecos[cantidadActual];
        huecos[cantidadActual] = null; // Limpiamos la casilla
        return itemExtraido;
    }
 
    public string SacarMedio()
    {

        if (EstaVacia())
        {
            return null;
        }

        int medio = cantidadActual / 2;
        string itemExtraido = huecos[medio];

        for(int i = 0; i < cantidadActual--; i++)
        {
            medio = medio++;
        }
        return itemExtraido;
    }




}
