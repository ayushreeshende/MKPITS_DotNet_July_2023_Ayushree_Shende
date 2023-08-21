#include<std
void main()
{
	int num,i,sum=0;
	printf("enter a number");
	scanf("%d",&num);
	printf("even numberfrom 1 to %d are:\n",num);
		for(i=1 ;i<=num; i++)
	{
		printf("\n the even no is %d",2*i);
		sum=sum+(2*i);
	}
	printf("\nthe sum of even natural number upto %d terms:%d\n",num,sum);
	
}

