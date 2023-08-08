//function with parameter and  no return a value
#include<stdio.h>
void area(int side)
{
	int result=side*side;
	printf("Area of square=%d",result);
}
void main()
{
	int side;
	printf("Enter side=");
	scanf("%d",&side);
	area(side);
}
		
