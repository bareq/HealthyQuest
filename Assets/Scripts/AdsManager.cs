using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
	
	void OnGUI() {
		if(GUI.Button(new Rect(10, 10, 150, 50), Advertisement.IsReady() ? "Show Ad" : "Waiting...")) {
			// Show with default zone, pause engine and print result to debug log
			Advertisement.Show(null, new ShowOptions {
				resultCallback = result => {
					Debug.Log(result.ToString());
				}
			});
		}
	}
}