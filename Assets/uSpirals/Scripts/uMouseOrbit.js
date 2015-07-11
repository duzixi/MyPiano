var target : Transform;
var distance = 10.0;
var xSpeed = 300.0;
var ySpeed = 300.0;
var zoomRate = 50;

private var x = 0.0;
private var y = 0.0;
private var rot:boolean;

function Start () {
    var angles = transform.eulerAngles;
    x = angles.y;
    y = angles.x;
}


function Update () {
	if (target) {
	
      
		if(Input.GetMouseButtonDown(0)){
		rot = true;
		}else if(Input.GetMouseButtonUp(0)){
		rot = false;
		}
		
		if(rot){
		x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
        y -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
     	}
     	
        distance += -Input.GetAxis("Mouse ScrollWheel")* Time.deltaTime * zoomRate * Mathf.Abs(distance);
      
       		
 		
 		       
        var rotation = Quaternion.Euler(y, x, 0);
        var position = rotation * Vector3(0.0, 0.0, -distance) + target.position;
        
        transform.rotation = rotation;
        transform.position = position;
        
         
    }
	

}

