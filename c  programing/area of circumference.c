#include<stdio.h>
void main()
{
	float radius;
	float area,circumference;
	printf("enter radius");
	scanf("%d",&radius);
	area=3.14*radius*radius;
	circumference=2*3.14*radius;
	printf("area=%f\n",area),
	printf("circumference=%f",circumference);
}
