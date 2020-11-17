using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlmasManager : MonoBehaviour
{
    private int contadorAlmas = 0;
    public Text itemsCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarAlma()
    {
        contadorAlmas++;
        itemsCount.text = "Almas Restantes: " + contadorAlmas;
    }

    public void RestarAlma()
    {
        contadorAlmas--;
        itemsCount.text = "Almas Restantes: " + contadorAlmas; 
    }

}
