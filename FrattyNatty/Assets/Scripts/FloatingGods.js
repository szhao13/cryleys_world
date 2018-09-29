#pragma strict

var X_COORD = 0.0;
var Y_COORD = 0.0;
var Z_COORD = 2.7;

var prefab : GameObject;

var NUM_OBJECTS = 100;
 
function Awake()
{
  for (var i = NUM_OBJECTS - 1; i >= 0; i--) {
    Instantiate(prefab, new Vector3(X_COORD + (i+1)*Random.Range(80.0,160.0), Y_COORD+Random.Range(5.0, 6.0), Z_COORD-1.5), Quaternion.AngleAxis(180, Vector3.up));
  }

}