using UnityEngine;
using System.Collections;

public class URL_texture : MonoBehaviour {
	public string url = "https://lh3.googleusercontent.com/rDOyKaphK1TO13HmTTy61wQctUyu6qXR_UduaZvvPIbX_Aa5JJhu71zbG7N1IHSJlqqf=w2247-h1264";

	IEnumerator Start()
	{
		if (Application.internetReachability != NetworkReachability.NotReachable)
		{
		if (null == url || url.Length < 1) {
			Debug.Log ("No url");
			yield return null;
		} else {
			Texture2D tex;
			tex = new Texture2D (4, 4, TextureFormat.DXT1, false);
			WWW www = new WWW (url);
			yield return www;
			www.LoadImageIntoTexture (tex);
			GetComponent<Renderer> ().material.mainTexture = tex;
		}
	}

	}
}