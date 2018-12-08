using UnityEngine;

public class Enemy : MonoBehaviour
{
	private void Start ()
	{
		Player.onEnemyHit += TakeDamage;
	}

	private void TakeDamage(Color color)
	{
		Debug.Log("Color changed to: " + color);
		transform.GetComponent<Renderer>().material.color = color;
	}

	private void OnDisable()
	{
		Debug.Log(transform.name + " removed");
		Player.onEnemyHit -= TakeDamage;
	}
}
