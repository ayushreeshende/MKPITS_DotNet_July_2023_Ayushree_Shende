

#include<stdio.h>
void main()
{
	int num,i,sum=0;
	printf("enter the number :"); 
	scanf("%d",&num);
	for(i=1 ;i<=num; i++)
	{
		printf("\n the odd no is %d",2*i-1);
		sum=sum+(2*i-1);
	}
	printf("\nthe sum of odd natural number upto %d terms:%d\n",num,sum);
	
}

