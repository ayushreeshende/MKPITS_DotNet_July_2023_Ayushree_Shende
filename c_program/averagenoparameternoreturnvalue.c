//without parameter and no return value

#include<stdio.h>
void average()
{
	float floatn1,floatn2,floatn3,floatn4,floatn5,floatadd;
	float result;
	printf("enter 5 no=");
	scanf("%f%f%f%f%f",&n1,n2,n3,n4,n5);
	add=n1+n2+n3+n4+n5;
	printf("addition=%f\n",add);
	result=add/5.0f;
	printf("average=%f",result);
	
}
void main()
{
	float n1,n2,n3,n4,n5,add;
	float result;
	average(n1,n2,n3,n4,n5,add,result);
}
