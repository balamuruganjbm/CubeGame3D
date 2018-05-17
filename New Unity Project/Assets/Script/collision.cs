using UnityEngine;

public class collision : MonoBehaviour {
	public first move;

	void OnCollisionEnter(Collision colinfo)
	{
		if (colinfo.collider.tag == "obs") 
		{
			move.enabled = false;
		}
		
	}
}
