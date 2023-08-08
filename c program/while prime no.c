#include<stdio.h>
void main()	
{
int counter=2;
int rem=0;
int num;
printf("enter a number");
scanf("%d",&num);
while(counter<num)
{
	rem=num%counter;
	if (rem==0)
	{
	
	printf("it is not a prime number");
	break;
}

counter=counter+1;
}
if (num==counter);
{
	printf("it is a prime number");
}
}

