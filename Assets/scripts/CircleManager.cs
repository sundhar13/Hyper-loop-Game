
using UnityEngine;

public class CircleManager : MonoBehaviour
{
	

	public virtual void MainMechanics()
	{
		float F_turn = Time.deltaTime * 800 *Input.GetAxis("Horizontal");
		transform.eulerAngles  = new Vector3(0,0,transform.eulerAngles.z+F_turn) ;


		transform.localScale = new Vector3(transform.localScale.x+Time.deltaTime* 0.1f,
			transform.localScale.y + Time.deltaTime * 0.1f, 0);

		if(transform.localScale.x > 1.5f)
		{
			gameObject.SetActive(false);
		}
	}

	public virtual void Begin()
	{
		transform.position = Vector3.zero;
		transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 180));
		transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
		gameObject.GetComponent<SpriteRenderer>().color = Color.white;

	}

	public virtual void End()
	{
		transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
	}
}
