// Code goes here

function Test1()
{
    let numToChange = 1;
    let expectedRomanNum = 'I';
    console.log(numToChange, expectedRomanNum);
}
function Test2()
{
    let numToChange = 4;
    let expectedRomanNum = 'IV';
    console.log(numToChange, expectedRomanNum);
}
//Test1();
Test2();
//ook no paso nada fallo el caso
//mejor crear un arreglo
 let arrayOfRomanNumerals = ['I','V'];
 let numToChange = 4;
 let expectedRomanNum = 'IV';
 let actualRomanNum = "";
 if(numToChange < 4)
 {
     for(let i = 0; i < 3; i++)
         actualRomanNum += arrayOfRomanNumerals[0] ;
     console.log(numToChange, actualRomanNum);
 }
  //ok test 1 pasa
 if(numToChange == 4)
 {
      actualRomanNum = arrayOfRomanNumerals[0] + arrayOfRomanNumerals[1];
      console.log(numToChange, actualRomanNum);
 }

