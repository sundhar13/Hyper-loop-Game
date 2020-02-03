using UnityEngine;

public class Player : MonoBehaviour
{
	public float F_distance1, F_distance2;
	public GameObject panel;

    void Update()
    {
		NearbyCheck();

		transform.Translate(0, 0.05f * Time.deltaTime,0);

		if(transform.position.y > -2.1)
		{
			//win
		}
    }

	void NearbyCheck()
	{

		RaycastHit2D[] hit = new RaycastHit2D[4];
		Vector2[] dir = new Vector2[4];

		dir[0] = Vector2.up;
		dir[1] = -Vector2.up;
		dir[2] = Vector2.right;
		dir[3] = -Vector2.right;

		for (int i = 0; i < hit.Length; i++)
		{
			hit[i] = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), dir[i], 2);


			if (hit[i].transform != null)
			{
				if (Vector2.Distance(hit[i].point, transform.position) < 0.5f)
				{
					hit[i].transform.GetComponent<SpriteRenderer>().color = Color.red;
					Time.timeScale = 0.3f;
					Invoke("Rest", 1);
				}
			}
		}
		
	}


	private void Rest()
	{
		Time.timeScale = 1;
		panel.SetActive(true);
	}
}
