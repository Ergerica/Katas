#include <bits/stdc++.h>
using namespace std;
vector<char> oneDimension;
vector<vector<char>> squaresMatrix;
int row,column;
string generation = "";
//TEST
 void Test()
{
  generation = "Generation 1";
  row=1;
  column = 1;
  char block = '.';
  oneDimension.push_back(block);
  squaresMatrix.push_back(oneDimension);
  //Expecte print: .

}

int main() {
  Test();
  for(int i = 0; i < row; i++)
  {
    int liveNeighbors = 0,deadNeighbors = 0;
    for(int j = 0; j < column; j++)
    {
         if((i-1)>=0)
         {

         }

    }
  }
	return 0;
}



// Your last C# code is saved below:
// using System;

// public class Test
// {
// 	public static void Main()
// 	{
// 		  '.'
// 	}

// }



