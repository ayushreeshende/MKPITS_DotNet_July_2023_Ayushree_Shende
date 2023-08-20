#include<stdio.h>
void area()
{
	int side,result;
	area(side,result);
	result=side*side;
	return result;
 } 
 void main()
 {
 
 	int side,result;
	printf("Enter side:");
	scanf("%d",&side);
	result=side*side;
	printf("area of square=%d",result);
printf("Do  you  want to continue,press'y'");
fflush(stdin);
scanf("%d");
}

