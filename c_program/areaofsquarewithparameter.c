//function with parameter and return a value
#include<stdio.h>
void area(int side)
{
	int result=side*side;
	return result;
}
void main()
{
	int side,result;
	printf("Enter side:");
	scanf("%d",&side);
	result = area (side);
	printf("Area of square=%d",result);
}
		


