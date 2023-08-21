#include<stdio.h>
void calculate(int r,float*a,float*c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
	
}
void main()
{
	int radius;
	float area,circ;
	printf("enter radius:");
	scanf("%d",&radius);
	calculate(radius,&area,&circ);
	printf("area of circle=%f\n",area);
	printf("circ=%f",circ);
}






























#include<stdio.h>


