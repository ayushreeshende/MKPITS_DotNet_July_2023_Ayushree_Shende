#include<stdio.h>
int main()
{
	int counter;
	int num;
	int result;
	printf("enter table :");
	scanf("%d",&num);
	while(counter<10)
	{
		result=num*counter;
		counter=counter+1;
		printf("%d*%d=%d\n",num,counter,num*counter);
	}
	return 0;
}
