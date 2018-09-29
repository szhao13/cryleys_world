#pragma strict

var X_COORD = 0.0;
var Y_COORD = 0.0;
var Z_COORD = 2.7;

var prefab : GameObject;

var NUM_OBJECTS = 100;
 
function Awake()
{
  for (var i = NUM_OBJECTS - 1; i >= 0; i--) {
    Instantiate(prefab, new Vector3(X_COORD + (i+1)*Random.Range(60.0,80.0), Y_COORD-0.5, Z_COORD), Quaternion.identity);
  }
   // var go1 = Instantiate(prefab, new Vector3(Z_COORD + 10, X_COORD, Y_COORD), Quaternion.identity);
   // var go2 = Instantiate(prefab, new Vector3(Z_COORD + 40, X_COORD, Y_COORD), Quaternion.identity);
   // var go3 = Instantiate(prefab, new Vector3(Z_COORD + 140, X_COORD, Y_COORD + 3), Quaternion.identity);
   // var go4 = Instantiate(prefab, new Vector3(Z_COORD + 180, X_COORD, Y_COORD), Quaternion.identity);
   // var go5 = Instantiate(prefab, new Vector3(Z_COORD + 180, X_COORD, Y_COORD+1), Quaternion.identity);  
   // var go6 = Instantiate(prefab, new Vector3(Z_COORD + 200, X_COORD, Y_COORD + 3), Quaternion.identity);
   // var go7 = Instantiate(prefab, new Vector3(Z_COORD + 500, X_COORD + 10, Y_COORD), Quaternion.identity);

}