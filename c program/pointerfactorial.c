#include<stdio.h>
void factorial(int num,int *fact)
	{
		while(num>0)
	{
	
	*fact=*fact*num;
	num=num-1;
}
}
void main()
{
	int num,fact=1;
	printf("enter number");
	scanf("%d",&num);
	factorial(num,&fact);
	printf("fact=%d",fact);
	
}


