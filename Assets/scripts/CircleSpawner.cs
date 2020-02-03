
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{

	public GameObject[] G_Circles;

	public List<GameObject[]> LG_circles;

	public int I_count;
	public float F_timing;
	float F_timer = -5;

	public int I_tup;



	private void OnEnable()
	{
		if(LG_circles != null)
		{
			LG_circles.Clear();
		}
	}

	void Start()
    {
		LG_circles = new List<GameObject[]>(G_Circles.Length);

		for(int i = 0; i < G_Circles.Length; i++)
		{
			GameObject[] G_type = new GameObject[I_count];

			for(int j = 0; j < I_count; j++)
			{
				G_type[j] = Instantiate(G_Circles[i], this.transform);
				G_type[j].SetActive(false);
			}

			LG_circles.Add(G_type);
		}

		Debug.Log(LG_circles.Count);
    }

   
    void Update()
    {
		//Timer
        if(Time.time > F_timer)
		{
			F_timer = Time.time + F_timing;

			Spawn(Random.Range(0,3));
		}

    }

	// To spawn circles
	void Spawn(int I_type)
	{
		for(int i = 0; i < LG_circles[I_type].Length; i++)
		{
			if(!LG_circles[I_type][i].activeSelf)
			{
				LG_circles[I_type][i].SetActive(true);
				break;
			}
		}
	}
}
