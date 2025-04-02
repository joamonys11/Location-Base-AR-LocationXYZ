using UnityEngine;
using System.Collections;
using Parse;
using Parse.Utilities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;



public class ParseSample : MonoBehaviour {
	List<ParseObject> objectlist;
	// Use this for initialization
	void Start () {



		var point = new ParseGeoPoint(40.0,-30.0);
		var query = ParseObject.GetQuery ("Place");
		query.FindAsync ().ContinueWith (t => {
			IEnumerable<ParseObject> results = t.Result;
			foreach (var result in results) {

				if(result.IsDataAvailable)
				{
					result.Remove("PlaceName");
				}
				result.Add("PlaceName","ooo");


			
				Task savetask = result.SaveAsync();
				print( "Class "+result.ClassName);

				break;
			}


			results.GetEnumerator().


		



		});



		


	}
	
	// Update is called once per frame
	void Update () {


	
	}






}


