#include<stdio.h>
int main()
{
	int num,i;
	int square;
	int sum=0;
	printf("enter no:");
	scanf("%d",&num);
	printf("square from 1 to %d are:\n",num);
	for(i=1;i<=num;i++)
	{
		square=i*i;
		printf("%d\n",square);
		sum=sum+square;
	}
	printf("\n the sum of square natural no upto %d terms:%d \n",num,square,sum);
}
