//function with parameter no return value
#include<stdio.h>
void check(int num,int rem)
{
	if(num%2==0)
	{
		printf("this is a even no");
	}
	else
	{
		printf("this is a odd no");
	}
}
void main()
{
	int num,rem=0;
	printf("enter no =");
	scanf("%d",&num);
	check(num,rem);
}
