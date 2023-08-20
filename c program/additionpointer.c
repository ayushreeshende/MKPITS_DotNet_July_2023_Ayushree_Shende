#include<stdio.h>
void addition (int num1,int num2,int *result)
{
*result=num1+num2;
}
	void main()
	{
	int num1,num2,result;
	printf("enter 2 no");
	scanf("%d%d",&num1,&num2);
	addition(num1,num2,&result);
	printf("addition=%d",result);
}


