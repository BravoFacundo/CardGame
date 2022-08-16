using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCards : MonoBehaviour
{



    private void Update()
    {
        //Si mantengo click izq
          //checkear pos X e Y del mouse en pantalla
          //Checkear si toco un elemento con el tag "Card"
          //llamar metodo "PickUpCard"

        //Si suelto click izq
          //llamar metodo "ReleaseCard"



    }

    private void PickUpCard()
    {
        //Parent = Null
        //Pos x e y Siguen a la pos x e y del mouse
    }
    private void ReleaseCard()
    {
        //Checkear donde esta la carta
        //Meter a ese layout en el orden correcto
    }


}
