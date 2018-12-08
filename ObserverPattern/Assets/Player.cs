using UnityEngine;

public class Player : MonoBehaviour
{
	public Enemy[] Enemies;
	
	private static Player _instance;
	public static Player Instance;

	public delegate void ChangeEnemyColor(Color color);
	public static event ChangeEnemyColor onEnemyHit;
	
	// Update is called once per frame
	private void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (onEnemyHit != null)
			{
				onEnemyHit(Color.red);
			}
			//ChangeColor(); ///Original way to change color of the cubes
		}
	}

	private void ChangeColor()
	{
		foreach (var Enemy in Enemies)
		{
			Enemy.GetComponent<Renderer>().material.color = Color.red;
		}
	}
}
