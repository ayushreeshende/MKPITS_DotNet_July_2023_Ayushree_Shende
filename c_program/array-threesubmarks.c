#include<stdio.h>
void main()
{
	int i;
	int sum=0;
int marks[3];
marks[0]=99;
marks[1]=88;
marks[2]=77;
for(i=0;i<3;i++)
{
	printf("\nmarks%d",marks[i]);
	sum=sum+marks[i];
	
}
printf("\n total marks=%d",sum);
}
