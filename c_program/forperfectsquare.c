#include<stdio.h>
void main()
{
	int num,i,sum=0;
	printf("enter a number:");
	scanf("%d",&num);
	printf("excluding of %d are:\n",num);
	for(i=1;i<num;i++);
	{
		if(num%i==0)
		{
			printf("%d\n",i);
			sum=sum+i;
		}
		}
		if(sum==num)
		printf("%d is a perfect number:\n",num);
		else
		printf("%d is not a perfect number:\n",num);
	}

