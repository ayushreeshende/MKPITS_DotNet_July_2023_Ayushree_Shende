//function with parameter no return value
#include<stdio.h>
void average(float n1,float n2,float n3,float n4,float n5)
{
	float add=n1+n2+n3+n4+n5;
	float result=add/5.0f;
	printf("addition=%f\n",add);
	printf("average=%f",result);
}
void main()
{
	float n1,n2,n3,n4,n5,add,result;
	printf("enter 5 no=");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
	average(n1,n2,n3,n4,n5);
}

