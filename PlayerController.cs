using UnityEngine;
using System.Collections;

public class PlayerController : CharaController
{
	public GameObject sightPrb;// ターゲット用の照準
	public GameObject sightObj = null;// 生成したsightPrbを登録する => 次回生成時に存在している場合、Destroyする

	void Update()
	{
		/*if(Input.GetMouseButton)
		{
			float horizontal = Input.GetAxis("Horizontal");
		}*/

		// タッチしたら
		if(Input.GetMouseButtonDown(0))
		{
			// Rayを飛ばす
			RaycastHit2D ray = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			// 何かがヒットしていたら
			if(ray.collider != null)
			{
				Sight(ray.collider.gameObject.transform.position);
			}
		}
	}
	// 移動関数
	private void Move()
	{
		//if(InputGet)
	}
	// pos => targetの座標
	private void Sight(Vector3 targetPos)
	{
		if(sightObj){Destroy(sightObj);}// sightObjがまだ存在していればDestroy
		sightObj = Instantiate(this.sightPrb.gameObject, targetPos, Quaternion.identity) as GameObject;
		sightObj.name = sightPrb.name;// リネーム => Clone取り
	}
}