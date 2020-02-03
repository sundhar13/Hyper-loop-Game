using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleClient : CircleManager
{
   
    void OnEnable()
    {
		Begin();
    }

   
    void FixedUpdate()
    {
		MainMechanics();
    }

	private void OnDisable()
	{
		End();
	}
}
