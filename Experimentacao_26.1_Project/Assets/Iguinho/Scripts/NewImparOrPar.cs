using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class NewImparOrPar : MonoBehaviour
{
    public int numeroEscolhido;
    [SerializeField]private int numeroComparado;
    bool isPar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (numeroEscolhido > numeroComparado)
        {
            Debug.Log("O numero " + numeroEscolhido + " é maior que " + numeroComparado);
        }
        else if (numeroEscolhido < numeroComparado)
        {
            Debug.Log("O numero " + numeroEscolhido + " é menor que " + numeroComparado);

        }
        else 
        {
            Debug.Log("O numero " + numeroEscolhido + " é igual que " + numeroComparado);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    
}
