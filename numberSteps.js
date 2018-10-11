var test1 = '010101010100111010101';
var test2 = '10010101';
var test3 = '0000001';
var test4 = '1111';

function numberSteps(S){

  console.log('Initial size: '+ S.length);
  console.log('Original string: '+ S);
  var tempString = S;
  var steps = 0;
  while (tempString.length > 1 && tempString > 0) {

    console.log((tempString[tempString.length-1] == 1? 'Odd ':'Even ')+tempString[tempString.length-1]);
    if(tempString[tempString.length-1] ==1){

      if( tempString[tempString.length-2] > 0){
        steps+= 2;
          console.log('2 steps ('+steps+')');
        }
      else {
        steps++;
          console.log('1 step ('+steps+')');
      }


      }
    else    {
      steps++;
      console.log('1 step ('+steps+')');
    }
      tempString = tempString.substring(0, tempString.length -1);
        console.log('New '+tempString);


  }

  if(tempString == 1)
    steps++;

  console.log(steps);
}


numberSteps(test4);
