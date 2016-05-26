#pragma strict
 
// The list of Waypoint you want the enemy to traverse
public var waypoint : Transform[];   

// The walking speed between Waypoints     
public var patrolSpeed : float = 6;  

// Do you want to keep repeating the Waypoints     
public var loop : boolean = true;       

// How slowly to turn
public var dampingLook = 4; 

// How long to pause at a Waypoint= 0;           
public var pauseDuration : float;
 
private var curTime : float;
private var currentWaypoint : int = 0;
private var character : CharacterController;
 
function Start(){
 
    character = GetComponent(CharacterController);
}
 
function Update(){
 
    if(currentWaypoint < waypoint.length){
       patrol();
       }else{    
    if(loop){
       currentWaypoint=0;
        } 
    }
}
 
function patrol(){
 
    var nextWayPoint : Vector3 = waypoint[currentWaypoint].position;
        
    // Keep waypoint at character's height
    nextWayPoint.y = transform.position.y; 
        
    // Get the direction we need to move to
    // reach the next waypoint
    var moveDirection : Vector3 = nextWayPoint - transform.position;
 

    if(moveDirection.magnitude < 1.5){
        Debug.Log("enemy is close to nextwaypoint");

    
    // This section of code is called only whenever the enemy
    // is very close to the new waypoint 
    // so it is called once after 4-5 seconds.

       if (curTime == 0)
           // Pause over the Waypoint 
           curTime = Time.time; 
                      
           if ((Time.time - curTime) >= pauseDuration){
               Debug.Log("increasing waypoint");

                currentWaypoint++;
                curTime = 0;
           }
    }
    else
    {     
    Debug.Log("reaching in rotation " + moveDirection.magnitude);
       // This code gets called every time update is called
       // while the enemy if moving from point 1 to point 2.
       // so it gets called 100's of times in a few seconds  

       // Now we need to do two things
       // 1) Start rotating in the desired direction
       // 2) Start moving in the desired direction 
       
       // 1) Let' calculate rotation need to look at waypoint
       // by simply comparing the desired waypoint & current transform
       var rotation = Quaternion.LookRotation(nextWayPoint - transform.position);
       
       // A slerp function allow us to slowly start rotating 
       // towards our next waypoint 
       transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 
                Time.deltaTime * dampingLook);
                
       // 2) Now also let's start moving towards our waypoint
       character.Move(moveDirection.normalized * patrolSpeed * Time.deltaTime);
    }  
}