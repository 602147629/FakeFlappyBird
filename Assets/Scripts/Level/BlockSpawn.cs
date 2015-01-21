using UnityEngine;
using Level;
namespace Level
{
	public class BlockSpawn : MonoBehaviour
	{
		public Transform spwanPoint;
		public GameObject spwanResource;

		void Awake()
		{
			InvokeRepeating("Spawn", 0, 1);
		}

		void Spawn()
		{
			var spawn = GameObject.Instantiate(spwanResource) as GameObject;
			spawn.transform.parent = spwanPoint;
			spawn.transform.localPosition = Vector3.zero;
			ChangeScale (spawn);
		}

		void ChangeScale (GameObject spawn)
		{
			Vector3 orginScale = spawn.transform.localScale;
			spawn.transform.localScale = new Vector3 (orginScale.x, orginScale.y * Random.Range (1, 4), orginScale.z);
		}
	}
}

