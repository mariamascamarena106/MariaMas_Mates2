using UnityEngine;

public class Entrega3ExpectedValue : MonoBehaviour
{

    [Header("Numero de cartas")]
    [SerializeField] private float n_As = 4;
    [SerializeField] private float n_Tres = 4, n_Rey = 4, n_Caballo = 4, n_Sota = 4, n_Siete = 4, n_Seis = 4, n_Cinco = 4, n_Cuatro = 4, n_Dos = 4;

    [Header("Valores de cartas")]
    [SerializeField] private float v_As = 11;
    [SerializeField] private float v_Tres = 10, v_Rey = 4, v_Caballo = 3, v_Sota = 2, v_Siete = 0, v_Seis = 0, v_Cinco = 0, v_Cuatro = 0, v_Dos = 0;

   

    void Start()
    {
        
    }
    public void CalcularProbabilidades()
    {
        float totalCartas = n_As + n_Tres + n_Rey + n_Caballo + n_Sota + n_Siete + n_Seis + n_Cinco + n_Cuatro + n_Dos;
        //Provabilidad
        Debug.Log("Provabilidad As " + n_As / totalCartas);
        Debug.Log("Provabilidad Tres " + n_Tres / totalCartas);
        Debug.Log("Provabilidad Rey " + n_Rey / totalCartas);
        Debug.Log("Provabilidad Caballo " + n_Caballo / totalCartas);
        Debug.Log("Provabilidad Sota " + n_Sota / totalCartas);
        Debug.Log("Provabilidad Siete " + n_Siete / totalCartas);
        Debug.Log("Provabilidad Seis " + n_Seis / totalCartas);
        Debug.Log("Provabilidad Cinco " + n_Cinco / totalCartas);
        Debug.Log("Provabilidad Cuatro " + n_Cuatro / totalCartas);
        Debug.Log("Provabilidad Dos " + n_Dos / totalCartas);
    }

    public void CalcularEsperanza()
    {
        float totalCartas = n_As + n_Tres + n_Rey + n_Caballo + n_Sota + n_Siete + n_Seis + n_Cinco + n_Cuatro + n_Dos;

        Debug.Log("Esperanza As " + (n_As / totalCartas) * v_As);
        Debug.Log("Esperanza Tres " + (n_Tres / totalCartas) * v_Tres);
        Debug.Log("Esperanza Rey " + (n_Rey / totalCartas) * v_Rey);
        Debug.Log("Esperanza Caballo " + (n_Caballo / totalCartas) * v_Caballo);
        Debug.Log("Esperanza Sota " + (n_Sota / totalCartas) * v_Sota);
        Debug.Log("Esperanza Siete " + (n_Siete / totalCartas) * v_Siete);
        Debug.Log("Esperanza Seis " + (n_Seis / totalCartas) * v_Seis);
        Debug.Log("Esperanza Cinco " + (n_Cinco / totalCartas) * v_Cinco);
        Debug.Log("Esperanza Cuatro " + (n_Cuatro / totalCartas) * v_Cuatro);
        Debug.Log("Esperanza Dos " + (n_Dos / totalCartas) * v_Dos);
    }

    void Update()
    {
        
    }
   
}
