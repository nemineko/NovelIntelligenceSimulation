using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateUnit : MonoBehaviour
{
	public void OnClick()
	{
		GameManager.instance.UnitOnField();
	}
}
