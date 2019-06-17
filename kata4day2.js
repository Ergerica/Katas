'use strict';
let expectedNum , actualNum;

function test1()
{
    expectedNum = 'I', actualNum = 1;
}
function test2()
{
    expectedNum = 'IV', actualNum = 4;
}
function test3()
{
    expectedNum = 'V', actualNum = 5;
}
function test4()
{
    expectedNum = 'IX', actualNum = 9;
}
test1();
test2();
test3();
test4();
let answer = "";
let romanNumeralsArray = ['I','X','L','C','D','M','V'];
let romanNumber=["","I","II","III","IV","V","VI","VII","VIII","IX"];
if(actualNum<=9)
    answer=romanNumber[actualNum];
else if(actualNum>9 && actualNum<40)
{
    
}
console.log(answer);






