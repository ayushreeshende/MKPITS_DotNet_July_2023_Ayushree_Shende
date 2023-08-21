//function without parameter no return value
#include<stdio.h>
void area() 
{
	int side,result;
	printf("Enter side:");
	scanf("%d",&side);
	result=side*side;
	printf("area of square=%d",result);
}
void main()
{
	int result,side;
	area(side,result);	
}
	

//Algorithm:
//	1)start
//	2)defin the function name area
//	3)declare side,result
//	4)print side
//	5)result=side*side
//	6)print area of square
//	7)go to main function
//	8)call the area function
//	9)stop
