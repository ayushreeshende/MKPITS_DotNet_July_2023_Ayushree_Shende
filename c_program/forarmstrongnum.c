#include<stdio.h>
void main()
{
	int num,r,sum=0,i;
	printf("input a number:");
	scanf("%d",&num);
	for(i=num;num!=0;num=num/10)
	{
	
	r=num%10;
	sum=sum+(r*r*r);
}
if(sum==i)
printf("%d is an armstrong number.\n",i);
else 
printf("%d is not an armstrong number.\n",i);
}
